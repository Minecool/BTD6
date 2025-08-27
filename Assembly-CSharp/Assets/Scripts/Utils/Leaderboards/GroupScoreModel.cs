namespace Assets.Scripts.Utils.Leaderboards;

public class GroupScoreModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ScoreModel, Int64> <>9__16_0; //Field offset: 0x8
		public static Func<ScoreModel, Int64> <>9__16_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal long <GetScore>b__16_0(ScoreModel x) { }

		internal long <GetScore>b__16_1(ScoreModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetPlayer>b__0(ScoreModel s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <HasPlayer>b__0(ScoreModel s) { }

	}

	private readonly List<ScoreModel> playerScores; //Field offset: 0x10
	private readonly List<LeaderboardScoreData> playerScoreData; //Field offset: 0x18
	private readonly LeaderboardType leaderboardType; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private long <Score>k__BackingField; //Field offset: 0x30

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public IReadOnlyCollection<ScoreModel> PlayerScores
	{
		 get { } //Length: 5
	}

	public private long Score
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public GroupScoreModel(string id, LeaderboardType leaderboardType) { }

	public void AddPlayerScore(ScoreModel playerScore) { }

	[CompilerGenerated]
	public string get_Id() { }

	public IReadOnlyCollection<ScoreModel> get_PlayerScores() { }

	[CompilerGenerated]
	public long get_Score() { }

	public ScoreModel GetPlayer(string playerId) { }

	private long GetScore() { }

	public bool HasPlayer(string playerId) { }

	[CompilerGenerated]
	private void set_Score(long value) { }

}

