namespace SteamNative;

internal class SteamHTTP : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamHTTP(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

}

