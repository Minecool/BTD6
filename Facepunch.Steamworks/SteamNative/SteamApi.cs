namespace SteamNative;

internal class SteamApi : IDisposable
{
	internal Interface platform; //Field offset: 0x10

	internal SteamApi() { }

	public override void Dispose() { }

	public HSteamPipe SteamAPI_GetHSteamPipe() { }

	public HSteamUser SteamAPI_GetHSteamUser() { }

	public bool SteamAPI_Init() { }

	public void SteamAPI_RegisterCallback(IntPtr pCallback, int callback) { }

	public void SteamAPI_RunCallbacks() { }

	public void SteamAPI_Shutdown() { }

	public void SteamAPI_UnregisterCallback(IntPtr pCallback) { }

	public void SteamGameServer_Shutdown() { }

	public IntPtr SteamInternal_CreateInterface(string version) { }

}

