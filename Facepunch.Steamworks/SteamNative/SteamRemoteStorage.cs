namespace SteamNative;

internal class SteamRemoteStorage : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamRemoteStorage(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

}

