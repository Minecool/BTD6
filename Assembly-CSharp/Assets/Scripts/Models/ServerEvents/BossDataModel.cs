namespace Assets.Scripts.Models.ServerEvents;

public class BossDataModel
{
	private const string kObsoleteMessage = "Use GetLeaderboardScoringType, NormalScoringType or EliteScoringType instead"; //Field offset: 0x0
	public DailyChallengeModel normalDcm; //Field offset: 0x10
	public DailyChallengeModel eliteDcm; //Field offset: 0x18
	public BossType bossType; //Field offset: 0x20
	public TimeSpan penaltyGraceTime; //Field offset: 0x28
	public TimeSpan penaltyRoundMultiplier; //Field offset: 0x30
	[JsonProperty("leaderboardScoringType")]
	[Obsolete("Use GetLeaderboardScoringType, NormalScoringType or EliteScoringType instead")]
	public LeaderboardScoringType legacyScoringType; //Field offset: 0x38
	[Obsolete("Use GetLeaderboardScoringType, NormalScoringType or EliteScoringType instead")]
	public Nullable<LeaderboardScoringType> normalScoringType; //Field offset: 0x3C
	[Obsolete("Use GetLeaderboardScoringType, NormalScoringType or EliteScoringType instead")]
	public Nullable<LeaderboardScoringType> eliteScoringType; //Field offset: 0x44

	public LeaderboardScoringType EliteScoringType
	{
		 get { } //Length: 76
	}

	public LeaderboardScoringType NormalScoringType
	{
		 get { } //Length: 76
	}

	public BossDataModel() { }

	public LeaderboardScoringType get_EliteScoringType() { }

	public LeaderboardScoringType get_NormalScoringType() { }

	public DailyChallengeModel GetDcm(bool isElite) { }

	public LeaderboardScoringType GetLeaderboardScoringType(bool isElite) { }

}

