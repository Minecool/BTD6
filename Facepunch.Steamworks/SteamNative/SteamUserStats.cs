namespace SteamNative;

internal class SteamUserStats : IDisposable
{
	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamUserStats(BaseSteamworks steamworks, IntPtr pointer) { }

	public override void Dispose() { }

	public bool GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, out uint punUnlockTime) { }

	public string GetAchievementDisplayAttribute(string pchName, string pchKey) { }

	public int GetAchievementIcon(string pchName) { }

	public string GetAchievementName(uint iAchievement) { }

	public uint GetNumAchievements() { }

	public bool RequestCurrentStats() { }

	public bool SetAchievement(string pchName) { }

	public bool SetStat(string pchName, int nData) { }

	public bool StoreStats() { }

}

