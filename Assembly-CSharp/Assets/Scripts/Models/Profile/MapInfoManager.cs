namespace Assets.Scripts.Models.Profile;

public class MapInfoManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapInfo, Boolean> <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetCompletedMapCount>b__28_0(MapInfo m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public MapInfoManager playerMapInfo; //Field offset: 0x10
		public string difficulty; //Field offset: 0x18
		public string mode; //Field offset: 0x20
		public bool isCoopMode; //Field offset: 0x28

		public <>c__DisplayClass18_0() { }

		internal bool <MedalGainedAnalytics>b__0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public MapDifficulty mapDifficulty; //Field offset: 0x10
		public MapInfoManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass43_0() { }

		internal bool <GetCompletedMapDifficultyCount>b__0(MapDetails map) { }

		internal bool <GetCompletedMapDifficultyCount>b__1(MapDetails map) { }

	}

	private enum PlayerMode
	{
		SinglePlayer = 0,
		Coop = 1,
		Both = 2,
	}

	[JsonProperty]
	private ushort mapDifficultyLockedFlags; //Field offset: 0x10
	[JsonProperty]
	private ushort mapDifficultyUnlockedFlags; //Field offset: 0x12
	public Dictionary<String, MapInfo> maps; //Field offset: 0x18

	public MapInfoManager() { }

	private string CheckBestMedalForImpoppableSubModes(out int medalsWon, int hardMedalCount, bool getCoopMedals) { }

	public int CompletedMapsRequiredToUnlock(MapDifficulty mapDifficulty) { }

	public void CompletedRound(string map, string difficulty, string mode, int round, bool isCoopMode) { }

	public void CompleteMode(string map, string difficulty, string mode, bool completedWithoutLoadingSave, bool isCoopMode) { }

	public string GetBestDifficultyReached(out int medalsWon, bool getCoopMedals) { }

	private int GetBestRoundForMode(string mapName, string mode, PlayerMode playerMode) { }

	public int GetBestRoundForMode(string mode, bool includeCoop) { }

	public bool GetBestSocialRound(string mapName, out string bestDifficulty, out int bestRound) { }

	public int GetCompletedGamesForMode(string mode, bool uniqueMapCount = false) { }

	public int GetCompletedMapCount() { }

	public int GetCompletedMapDifficultyCount(MapDifficulty mapDifficulty) { }

	public int GetCoopIndexForDifficulty(string difficulty) { }

	public MapInfo GetMap(string mapName) { }

	private int GetMedalsForDifficulty(string difficulty, bool coopMedals) { }

	public int GetMostMedalsForAnyMap() { }

	public int GetNumOfMedalsForMapDifficulty(MapDifficulty mapDifficulty, bool coop = false) { }

	public int GetNumOfWinsForModeDifficulty(string modeDifficulty, bool coop = false) { }

	[Obsolete("Not used anymore. Must remain to support old save data structures.")]
	public int GetTotalDailyChallengeCompletedCount() { }

	public int GetUniqueCompletedMapsForMode(string mode) { }

	public bool HasCompletedMap(string map) { }

	public bool HasCompletedMode(string map, string difficulty, string mode, bool isCoopMode, bool checkCompletedWithoutLoadingSave = false) { }

	public bool HasSeenCompletedMode(string map, string difficulty, string mode, bool isCoopMode) { }

	public bool HasSeenMapDifficultyLock(MapDifficulty d) { }

	public bool HasSeenMapDifficultyUnlock(MapDifficulty d) { }

	public bool HasSeenModeComplete(string map, string difficulty, string mode, bool checkCompletedWithoutLoadingSave, bool isCoopMode) { }

	public bool HasSeenModeUnlock(string map, string difficulty, string mode, bool isCoopMode) { }

	public bool HasSeenNewMap(string map) { }

	public bool HasSeenNewMapDifficulty(string map) { }

	public bool IsMapDifficultyUnlocked(MapDifficulty mapDifficulty) { }

	public bool IsMapUnlocked(string map) { }

	public bool IsModeUnlocked(string map, string difficulty, string mode, bool isCoopMode) { }

	private void MedalGainedAnalytics(string map, string difficulty, string mode, bool completedWithoutLoadingSave, bool isCoopMode) { }

	public void RemoveMapMedals(string map) { }

	public void SeenCompletedMode(string map, string difficulty, string mode, bool isCoopMode) { }

	public void SeenModeComplete(string map, string difficulty, string mode, bool isCoopMode) { }

	public void SeenModeUnlock(string map, string difficulty, string mode, bool isCoopMode) { }

	public void SeenNewMap(string map) { }

	public void SeenNewMapDifficulty(string map) { }

	public void SetSeenMapDifficultyLock(MapDifficulty d) { }

	public void SetSeenMapDifficultyUnlock(MapDifficulty d) { }

	public void UnlockMap(string map) { }

}

