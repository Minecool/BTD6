namespace SteamNative;

internal class SteamApps : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamApps(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

	public int GetAppBuildId() { }

	public string GetAppInstallDir(AppId_t appID) { }

	public ulong GetAppOwner() { }

	public string GetAvailableGameLanguages() { }

	public string GetCurrentBetaName() { }

	public string GetCurrentGameLanguage() { }

}

