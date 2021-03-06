﻿/*
 * This file is subject to the terms and conditions defined in
 * file 'license.txt', which is part of this source code package.
 */

using System.Net;
using SteamKit2.Internal;

namespace SteamKit2
{
    /// <summary>
    /// This handler is used for requesting server list details from Steam.
    /// </summary>
    public sealed partial class SteamMasterServer : ClientMsgHandler
    {
        /// <summary>
        /// Details used when performing a server list query.
        /// </summary>
        public sealed class QueryDetails
        {
            /// <summary>
            /// Gets or sets the AppID used when querying servers.
            /// </summary>
            public uint AppID { get; set; }

            /// <summary>
            /// Gets or sets the filter used for querying the master server.
            /// Check https://developer.valvesoftware.com/wiki/Master_Server_Query_Protocol for details on how the filter is structured.
            /// </summary>
            public string Filter { get; set; }
            /// <summary>
            /// Gets or sets the region that servers will be returned from.
            /// </summary>
            public ERegionCode Region { get; set; }

            /// <summary>
            /// Gets or sets the IP address that will be GeoIP located.
            /// This is done to return servers closer to this location.
            /// </summary>
            public IPAddress GeoLocatedIP { get; set; }

            /// <summary>
            /// Gets or sets the maximum number of servers to return.
            /// </summary>
            public uint MaxServers { get; set; }
        }


        internal SteamMasterServer()
        {
        }


        /// <summary>
        /// Requests a list of servers from the Steam game master server.
        /// Results are returned in a <see cref="QueryCallback"/>.
        /// </summary>
        /// <param name="details">The details for the request.</param>
        /// <returns>The Job ID of the request. This can be used to find the appropriate <see cref="QueryCallback"/>.</returns>
        public JobID ServerQuery( QueryDetails details )
        {
            var query = new ClientMsgProtobuf<CMsgClientGMSServerQuery>( EMsg.ClientGMSServerQuery );
            query.SourceJobID = Client.GetNextJobID();

            query.Body.app_id = details.AppID;

            if ( details.GeoLocatedIP != null )
                query.Body.geo_location_ip = NetHelpers.GetIPAddress( details.GeoLocatedIP );

            query.Body.filter_text = details.Filter;
            query.Body.region_code = ( uint )details.Region;

            query.Body.max_servers = details.MaxServers;

            this.Client.Send( query );

            return query.SourceJobID;
        }


        /// <summary>
        /// Handles a client message. This should not be called directly.
        /// </summary>
        /// <param name="packetMsg">The packet message that contains the data.</param>
        public override void HandleMsg( IPacketMsg packetMsg )
        {
            switch ( packetMsg.MsgType )
            {
                case EMsg.GMSClientServerQueryResponse:
                    HandleServerQueryResponse( packetMsg );
                    break;
            }
        }


        #region ClientMsg Handlers
        void HandleServerQueryResponse( IPacketMsg packetMsg )
        {
            var queryResponse = new ClientMsgProtobuf<CMsgGMSClientServerQueryResponse>( packetMsg );

            var callback = new QueryCallback(queryResponse.TargetJobID, queryResponse.Body);
            Client.PostCallback( callback );
        }
        #endregion

    }
}
