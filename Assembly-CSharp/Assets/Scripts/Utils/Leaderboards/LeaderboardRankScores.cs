namespace Assets.Scripts.Utils.Leaderboards;

[IsReadOnly]
public struct LeaderboardRankScores
{
	[CompilerGenerated]
	private readonly RankModel <Rank>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly ScoreModel[] <Scores>k__BackingField; //Field offset: 0x8

	public RankModel Rank
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public ScoreModel[] Scores
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public LeaderboardRankScores(RankModel rank, ScoreModel[] scores) { }

	[CompilerGenerated]
	public RankModel get_Rank() { }

	[CompilerGenerated]
	public ScoreModel[] get_Scores() { }

}

