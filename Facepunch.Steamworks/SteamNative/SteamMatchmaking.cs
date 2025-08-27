namespace SteamNative;

internal class SteamMatchmaking : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamMatchmaking(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

	public bool GetFavoriteGame(int iGame, ref AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer) { }

	public int GetFavoriteGameCount() { }

}

