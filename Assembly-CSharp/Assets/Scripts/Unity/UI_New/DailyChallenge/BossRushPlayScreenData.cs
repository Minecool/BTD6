namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushPlayScreenData
{
	[CompilerGenerated]
	private readonly BossRushEvent <BossRushEvent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <CurrentTile>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly BossRushTileRules <TileRules>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly List<Int32> <PlayerScores>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly int <CurrentScore>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly bool <IsReplay>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private readonly Nullable<UInt64> <LatestTeamScoreId>k__BackingField; //Field offset: 0x38

	public BossRushEvent BossRushEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int CurrentScore
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public int CurrentTile
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool IsReplay
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Nullable<UInt64> LatestTeamScoreId
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public List<Int32> PlayerScores
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BossRushTileRules TileRules
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BossRushPlayScreenData(BossRushEvent bossRushEvent, int currentTile, BossRushTileRules tileRules, List<Int32> playerScores, int currentScore, bool isReplay, Nullable<UInt64> latestTeamScoreId) { }

	[CompilerGenerated]
	public BossRushEvent get_BossRushEvent() { }

	[CompilerGenerated]
	public int get_CurrentScore() { }

	[CompilerGenerated]
	public int get_CurrentTile() { }

	[CompilerGenerated]
	public bool get_IsReplay() { }

	[CompilerGenerated]
	public Nullable<UInt64> get_LatestTeamScoreId() { }

	[CompilerGenerated]
	public List<Int32> get_PlayerScores() { }

	[CompilerGenerated]
	public BossRushTileRules get_TileRules() { }

}

