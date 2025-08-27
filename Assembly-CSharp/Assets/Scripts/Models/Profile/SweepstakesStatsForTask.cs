namespace Assets.Scripts.Models.Profile;

public class SweepstakesStatsForTask
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public SweepstakesMapVictoryStats map; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <Combine>b__0(SweepstakesMapVictoryStats x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public string mapId; //Field offset: 0x10
		public string gameDifficulty; //Field offset: 0x18
		public int mapDifficulty; //Field offset: 0x20
		public string gameModeId; //Field offset: 0x28

		public <>c__DisplayClass27_0() { }

		internal bool <GetStatFromMapstepConditionId>b__0(SweepstakesMapVictoryStats m) { }

		internal bool <GetStatFromMapstepConditionId>b__1(SweepstakesMapVictoryStats m) { }

		internal bool <GetStatFromMapstepConditionId>b__2(SweepstakesMapVictoryStats m) { }

		internal bool <GetStatFromMapstepConditionId>b__3(SweepstakesMapVictoryStats m) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public string mapId; //Field offset: 0x10
		public string gameDifficulty; //Field offset: 0x18
		public string gameModeId; //Field offset: 0x20
		public int mapDifficulty; //Field offset: 0x28

		public <>c__DisplayClass29_0() { }

		internal bool <AddMapWin>b__0(SweepstakesMapVictoryStats x) { }

	}

	internal class SweepstakesMapVictoryStats
	{
		public string mapId; //Field offset: 0x10
		public string gameDifficulty; //Field offset: 0x18
		public int mapDifficulty; //Field offset: 0x20
		public string gameModeId; //Field offset: 0x28
		public KonFuze timesMapBeaten; //Field offset: 0x30
		public KonFuze roundsBeaten; //Field offset: 0x38

		public SweepstakesMapVictoryStats() { }

		public SweepstakesMapVictoryStats(string mapId, string gameDifficulty, int mapDifficulty, string gameModeId) { }

	}

	public KonFuze taskIndex; //Field offset: 0x10
	public HashSet<String> taskIds; //Field offset: 0x18
	public HashSet<String> stepConditionIds; //Field offset: 0x20
	public KonFuze bloonsPopped; //Field offset: 0x28
	public KonFuze moabsPopped; //Field offset: 0x30
	public KonFuze raceScoresSubmitted; //Field offset: 0x38
	public KonFuze bossEventScoresSubmitted; //Field offset: 0x40
	public KonFuze ctTilesCaptured; //Field offset: 0x48
	public KonFuze bossRushScoresSubmitted; //Field offset: 0x50
	public KonFuze hardOdysseysBeaten; //Field offset: 0x58
	public KonFuze normalOdysseysBeaten; //Field offset: 0x60
	public KonFuze dailyChallengesBeaten; //Field offset: 0x68
	public KonFuze highestTierBossInSinglePlayer; //Field offset: 0x70
	public HashSet<String> uniqueHeroesWon; //Field offset: 0x78
	public Dictionary<String, KonFuze> timesMapBeaten; //Field offset: 0x80
	public Dictionary<String, KonFuze> heroTypeWins; //Field offset: 0x88
	public List<SweepstakesMapVictoryStats> mapWins; //Field offset: 0x90

	[JsonConstructor]
	public SweepstakesStatsForTask() { }

	public SweepstakesStatsForTask(KonFuze taskIndex, HashSet<String> taskIds, HashSet<String> stepConditionIds) { }

	public SweepstakesStatsForTask(KonFuze taskIndex, string taskId, HashSet<String> stepConditionIds) { }

	public void AddAnalyticsStats(AnalyticsKonFuze stats) { }

	public void AddMapWin(string mapId, string gameDifficulty, int mapDifficulty, string gameModeId, int roundsBeaten) { }

	public void Combine(SweepstakesStatsForTask stats) { }

	public void Default() { }

	private int GetStatFromHeroId(string heroId) { }

	private int GetStatFromMapstepConditionId(bool anyMap, bool isRounds = false, string mapId = "", string gameDifficulty = "", int mapDifficulty = -1, string gameModeId = "") { }

	public int GetStatFromstepConditionId(string stepConditionId, string mapId = "", string heroId = "") { }

	public int GetStatFromstepConditionIds(String[] stepConditionIds) { }

	public int GetStatFromTaskId(string taskId) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

