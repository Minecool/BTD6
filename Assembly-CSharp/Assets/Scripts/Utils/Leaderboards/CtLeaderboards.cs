namespace Assets.Scripts.Utils.Leaderboards;

[IsReadOnly]
public struct CtLeaderboards
{
	[CompilerGenerated]
	private readonly LeaderboardRankScores <LocalTeams>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly LeaderboardRankScores <LocalPlayers>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly LeaderboardRankScores <GlobalTeams>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly LeaderboardRankScores <GlobalPlayers>k__BackingField; //Field offset: 0x30

	public LeaderboardRankScores GlobalPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public LeaderboardRankScores GlobalTeams
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public LeaderboardRankScores LocalPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public LeaderboardRankScores LocalTeams
	{
		[CompilerGenerated]
		 get { } //Length: 10
	}

	public CtLeaderboards(LeaderboardRankScores localGuilds, LeaderboardRankScores localPlayers, LeaderboardRankScores globalGuilds, LeaderboardRankScores globalPlayers) { }

	[CompilerGenerated]
	public LeaderboardRankScores get_GlobalPlayers() { }

	[CompilerGenerated]
	public LeaderboardRankScores get_GlobalTeams() { }

	[CompilerGenerated]
	public LeaderboardRankScores get_LocalPlayers() { }

	[CompilerGenerated]
	public LeaderboardRankScores get_LocalTeams() { }

}

