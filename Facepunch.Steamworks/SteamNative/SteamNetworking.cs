namespace SteamNative;

internal class SteamNetworking : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamNetworking(BaseSteamworks steamworks, IntPtr pointer) { }

	public bool AcceptP2PSessionWithUser(CSteamID steamIDRemote) { }

	public bool CloseP2PSessionWithUser(CSteamID steamIDRemote) { }

	public override void Dispose() { }

	public bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel) { }

	public bool ReadP2PPacket(IntPtr pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel) { }

}

