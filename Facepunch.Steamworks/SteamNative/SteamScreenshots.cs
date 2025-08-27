namespace SteamNative;

internal class SteamScreenshots : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamScreenshots(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

}

