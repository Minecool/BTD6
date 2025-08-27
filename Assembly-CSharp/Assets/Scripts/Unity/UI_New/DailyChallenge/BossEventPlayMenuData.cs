namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossEventPlayMenuData
{
	[CompilerGenerated]
	private readonly BossEvent <BossEvent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly BossDataModel <BossData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IsElite>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly bool <IsRanked>k__BackingField; //Field offset: 0x21

	public BossDataModel BossData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BossEvent BossEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BossType BossType
	{
		 get { } //Length: 26
	}

	public DailyChallengeModel Dcm
	{
		 get { } //Length: 37
	}

	public bool IsElite
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsRanked
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LeaderboardScoringType LeaderboardScoringType
	{
		 get { } //Length: 37
	}

	public BossEventPlayMenuData(BossEvent bossEvent, BossDataModel bossData, bool isElite, bool isRanked) { }

	[CompilerGenerated]
	public BossDataModel get_BossData() { }

	[CompilerGenerated]
	public BossEvent get_BossEvent() { }

	public BossType get_BossType() { }

	public DailyChallengeModel get_Dcm() { }

	[CompilerGenerated]
	public bool get_IsElite() { }

	[CompilerGenerated]
	public bool get_IsRanked() { }

	public LeaderboardScoringType get_LeaderboardScoringType() { }

}

