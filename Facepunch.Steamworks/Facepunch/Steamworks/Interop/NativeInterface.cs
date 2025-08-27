namespace Facepunch.Steamworks.Interop;

internal class NativeInterface : IDisposable
{
	internal SteamApi api; //Field offset: 0x10
	internal SteamClient client; //Field offset: 0x18
	internal SteamUser user; //Field offset: 0x20
	internal SteamApps apps; //Field offset: 0x28
	internal SteamAppList applist; //Field offset: 0x30
	internal SteamFriends friends; //Field offset: 0x38
	internal SteamMatchmakingServers servers; //Field offset: 0x40
	internal SteamMatchmaking matchmaking; //Field offset: 0x48
	internal SteamInventory inventory; //Field offset: 0x50
	internal SteamNetworking networking; //Field offset: 0x58
	internal SteamUserStats userstats; //Field offset: 0x60
	internal SteamUtils utils; //Field offset: 0x68
	internal SteamScreenshots screenshots; //Field offset: 0x70
	internal SteamHTTP http; //Field offset: 0x78
	internal SteamUGC ugc; //Field offset: 0x80
	internal SteamGameServer gameServer; //Field offset: 0x88
	internal SteamGameServerStats gameServerStats; //Field offset: 0x90
	internal SteamRemoteStorage remoteStorage; //Field offset: 0x98
	internal SteamHTMLSurface htmlSurface; //Field offset: 0xA0
	private bool isServer; //Field offset: 0xA8

	public NativeInterface() { }

	public override void Dispose() { }

	public void FillInterfaces(BaseSteamworks steamworks, int hpipe, int huser) { }

	internal bool InitClient(BaseSteamworks steamworks) { }

}

