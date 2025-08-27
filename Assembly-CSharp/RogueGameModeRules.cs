//Type is in global namespace

[CreateAssetMenu(fileName = "RogueGameRules", menuName = "BTD6/RogueGameRules")]
public class RogueGameModeRules : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RogueModeGenericRules, Boolean> <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetRaceGoal>b__29_0(RogueModeGenericRules x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public BossType bossType; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <GetFinalBossInfo>b__0(RogueFinalBossInfo x) { }

	}

	internal class RogueModeGenericRules
	{
		public RogueTileType rogueTileType; //Field offset: 0x10
		public int roundsPerTile; //Field offset: 0x14
		public int roundsPerTilePerProgress; //Field offset: 0x18
		public int roundsPerProgress; //Field offset: 0x1C
		public int roundsPerStage; //Field offset: 0x20
		public int startingCash; //Field offset: 0x24
		public int startingCashReductionPerStage; //Field offset: 0x28
		public int baseStartingCashPerRound; //Field offset: 0x2C
		public int minBaseStartingCash; //Field offset: 0x30
		public int baseProgressDifficulty; //Field offset: 0x34
		public string difficulty; //Field offset: 0x38
		public string Roundset; //Field offset: 0x40
		public float bloonHealthPerDifficulty; //Field offset: 0x48
		public float bloonSpeedPerDifficulty; //Field offset: 0x4C
		public int lootRoundInterval; //Field offset: 0x50
		public int instaTowerCooldown; //Field offset: 0x54

		public RogueModeGenericRules() { }

	}

	public RogueModeGenericRules[] modeRules; //Field offset: 0x18
	public RogueModeGenericRules leastCashRules; //Field offset: 0x20
	public int progressBonusPerStage; //Field offset: 0x28
	public int beginnerDifficultyRating; //Field offset: 0x2C
	public int intermediateDifficultyRating; //Field offset: 0x30
	public int advancedDifficultyRating; //Field offset: 0x34
	public int expertDifficultyRating; //Field offset: 0x38
	public Int32[] bossRushGoals; //Field offset: 0x40
	public Int32[] racePopsGoals; //Field offset: 0x48
	public Int32[] raceTimeSecondsPerRound; //Field offset: 0x50
	public Single[] leastCashGoals; //Field offset: 0x58
	public int enduranceRaceTimeSeconds; //Field offset: 0x60
	public int enduranceRaceTimeReductionPerStage; //Field offset: 0x64
	public int enduranceRaceMinTime; //Field offset: 0x68
	public float enduranceRaceScorePerStage; //Field offset: 0x6C
	public float moabHPModifier; //Field offset: 0x70
	public float purpleHpModifier; //Field offset: 0x74
	public float purpleSpeedModifier; //Field offset: 0x78
	public int bfbStartEndRound; //Field offset: 0x7C
	public int zomgStartEndRound; //Field offset: 0x80
	public int bossStartRound; //Field offset: 0x84
	public int bossStartRoundPerStage; //Field offset: 0x88
	public int bossEndRound; //Field offset: 0x8C
	public int bossEndRoundPerStage; //Field offset: 0x90
	public RogueFinalBossInfo[] finalBosses; //Field offset: 0x98
	public int bossRushCashReward; //Field offset: 0xA0
	public float cashRewardMultiplier; //Field offset: 0xA4
	public int bossRushBaseHealth; //Field offset: 0xA8
	public float bossRushHealthMultiplier; //Field offset: 0xAC
	public float bossRushSpeedMultiplier; //Field offset: 0xB0
	public int bossRushBaseShield; //Field offset: 0xB4
	public int bossRushScorePerStage; //Field offset: 0xB8

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueGameModeRules() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public Int32[] GetEnduranceRaceScore(int stage) { }

	public int GetEnduranceRaceTime(int stage) { }

	public RogueFinalBossInfo GetFinalBossInfo(BossType bossType) { }

	public Int32[] GetLeashCashGoal(int totalCash) { }

	public int GetMapDifficultyScore(MapDifficulty mapDifficulty) { }

	private float GetPopsScoreForStage(int stage, int scoreIndex) { }

	public Int32[] GetRaceGoal() { }

}

