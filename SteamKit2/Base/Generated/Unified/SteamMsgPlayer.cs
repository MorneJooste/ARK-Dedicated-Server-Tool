//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_player.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetGameBadgeLevels_Request")]
  public partial class CPlayer_GetGameBadgeLevels_Request : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetGameBadgeLevels_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetGameBadgeLevels_Response")]
  public partial class CPlayer_GetGameBadgeLevels_Response : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetGameBadgeLevels_Response() {}
    

    private uint _player_level = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint player_level
    {
      get { return _player_level; }
      set { _player_level = value; }
    }
    private readonly global::System.Collections.Generic.List<CPlayer_GetGameBadgeLevels_Response.Badge> _badges = new global::System.Collections.Generic.List<CPlayer_GetGameBadgeLevels_Response.Badge>();
    [global::ProtoBuf.ProtoMember(2, Name=@"badges", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPlayer_GetGameBadgeLevels_Response.Badge> badges
    {
      get { return _badges; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Badge")]
  public partial class Badge : global::ProtoBuf.IExtensible
  {
    public Badge() {}
    

    private int _level = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }

    private int _series = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"series", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int series
    {
      get { return _series; }
      set { _series = value; }
    }

    private uint _border_color = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"border_color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint border_color
    {
      get { return _border_color; }
      set { _border_color = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetLastPlayedTimes_Request")]
  public partial class CPlayer_GetLastPlayedTimes_Request : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetLastPlayedTimes_Request() {}
    

    private uint _min_last_played = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"min_last_played", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint min_last_played
    {
      get { return _min_last_played; }
      set { _min_last_played = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetLastPlayedTimes_Response")]
  public partial class CPlayer_GetLastPlayedTimes_Response : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetLastPlayedTimes_Response() {}
    
    private readonly global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> _games = new global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game>();
    [global::ProtoBuf.ProtoMember(1, Name=@"games", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> games
    {
      get { return _games; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Game")]
  public partial class Game : global::ProtoBuf.IExtensible
  {
    public Game() {}
    

    private int _appid = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private uint _last_playtime = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"last_playtime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint last_playtime
    {
      get { return _last_playtime; }
      set { _last_playtime = value; }
    }

    private int _playtime_2weeks = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playtime_2weeks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int playtime_2weeks
    {
      get { return _playtime_2weeks; }
      set { _playtime_2weeks = value; }
    }

    private int _playtime_forever = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"playtime_forever", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int playtime_forever
    {
      get { return _playtime_forever; }
      set { _playtime_forever = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayer_AcceptSSA_Request")]
  public partial class CPlayer_AcceptSSA_Request : global::ProtoBuf.IExtensible
  {
    public CPlayer_AcceptSSA_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayer_AcceptSSA_Response")]
  public partial class CPlayer_AcceptSSA_Response : global::ProtoBuf.IExtensible
  {
    public CPlayer_AcceptSSA_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPlayer_LastPlayedTimes_Notification")]
  public partial class CPlayer_LastPlayedTimes_Notification : global::ProtoBuf.IExtensible
  {
    public CPlayer_LastPlayedTimes_Notification() {}
    
    private readonly global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> _games = new global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game>();
    [global::ProtoBuf.ProtoMember(1, Name=@"games", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> games
    {
      get { return _games; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IPlayer
    {
      CPlayer_GetGameBadgeLevels_Response GetGameBadgeLevels(CPlayer_GetGameBadgeLevels_Request request);
    CPlayer_GetLastPlayedTimes_Response ClientGetLastPlayedTimes(CPlayer_GetLastPlayedTimes_Request request);
    CPlayer_AcceptSSA_Response AcceptSSA(CPlayer_AcceptSSA_Request request);
    
    }
    
    
    public interface IPlayerClient
    {
      NoResponse NotifyLastPlayedTimes(CPlayer_LastPlayedTimes_Notification request);
    
    }
    
    
}
#pragma warning restore 1591