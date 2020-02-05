#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkMusicPlaylistCallbackInfo : AkEventCallbackInfo {
  private global::System.IntPtr swigCPtr;

  internal AkMusicPlaylistCallbackInfo(global::System.IntPtr cPtr, bool cMemoryOwn) : base(AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkMusicPlaylistCallbackInfo obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal override void setCPtr(global::System.IntPtr cPtr) {
    base.setCPtr(AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_SWIGUpcast(cPtr));
    swigCPtr = cPtr;
  }

  ~AkMusicPlaylistCallbackInfo() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkMusicPlaylistCallbackInfo(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint playlistID { get { return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_playlistID_get(swigCPtr); } 
  }

  public uint uNumPlaylistItems { get { return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_uNumPlaylistItems_get(swigCPtr); } 
  }

  public uint uPlaylistSelection { get { return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_uPlaylistSelection_get(swigCPtr); } 
  }

  public uint uPlaylistItemDone { get { return AkSoundEnginePINVOKE.CSharp_AkMusicPlaylistCallbackInfo_uPlaylistItemDone_get(swigCPtr); } 
  }

  public AkMusicPlaylistCallbackInfo() : this(AkSoundEnginePINVOKE.CSharp_new_AkMusicPlaylistCallbackInfo(), true) {
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.