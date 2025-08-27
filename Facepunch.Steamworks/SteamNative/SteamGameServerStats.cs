namespace SteamNative;

internal class SteamGameServerStats : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamGameServerStats(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

}

