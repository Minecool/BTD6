namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

[Extension]
public static class LiNKFriendsScores
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ScoreDifficulty, ScoreDifficulty> <>9__15_0; //Field offset: 0x8
		public static Func<Task, Boolean> <>9__16_0; //Field offset: 0x10
		public static Func<PlayerScoreData, Int32> <>9__16_1; //Field offset: 0x18
		public static Func<MapDetails, String> <>9__23_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal string <CacheTopScores>b__23_0(MapDetails x) { }

		internal ScoreDifficulty <get_SortedDifficulties>b__15_0(ScoreDifficulty x) { }

		internal bool <GetFriendsTopScores>b__16_0(Task x) { }

		internal int <GetFriendsTopScores>b__16_1(PlayerScoreData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Btd6Player player; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <MergeOwnScore>b__0(TopScore x) { }

	}

	[CompilerGenerated]
	private struct <AddFriendScoreData>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FriendModel playerModel; //Field offset: 0x20
		public string mapNameWithDifficulty; //Field offset: 0x28
		public List<PlayerScoreData> friendRankList; //Field offset: 0x30
		private PublicProfileModel <publicProfile>5__2; //Field offset: 0x38
		private string <avatar>5__3; //Field offset: 0x40
		private TaskAwaiter<PublicProfileModel> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CacheTopScores>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TimeSpan <scoreCacheLife>5__2; //Field offset: 0x20
		private DateTime <now>5__3; //Field offset: 0x28
		private IEnumerator<String> <>7__wrap3; //Field offset: 0x30
		private string <mapName>5__5; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<ScoreCache> <>u__2; //Field offset: 0x48
		private TaskAwaiter<List`1<TopScore>> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCachedFriendsTopScores>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<TopScore>> <>t__builder; //Field offset: 0x8
		public string mapName; //Field offset: 0x20
		private TaskAwaiter<ScoreCache> <>u__1; //Field offset: 0x28
		private TaskAwaiter<List`1<TopScore>> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFriendsTopScores>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<TopScore>> <>t__builder; //Field offset: 0x8
		public string mapName; //Field offset: 0x20
		public ScoreDifficulty difficulty; //Field offset: 0x28
		private string <mapNameWithDifficulty>5__2; //Field offset: 0x30
		private List<Task> <friendUpdateTasks>5__3; //Field offset: 0x38
		private List<PlayerScoreData> <friendRankList>5__4; //Field offset: 0x40
		private Enumerator<FriendModel> <>7__wrap4; //Field offset: 0x48
		private FriendModel <friend>5__6; //Field offset: 0x60
		private YieldAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFriendTopScores>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<TopScore>> <>t__builder; //Field offset: 0x8
		public string mapName; //Field offset: 0x20
		private List<TopScore> <topScores>5__2; //Field offset: 0x28
		private IEnumerator<ScoreDifficulty> <>7__wrap2; //Field offset: 0x30
		private ScoreDifficulty <difficulty>5__4; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x3C
		private TaskAwaiter<List`1<TopScore>> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTopScores>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<TopScore>> <>t__builder; //Field offset: 0x8
		public string mapName; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private TaskAwaiter<List`1<TopScore>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueueUpdateFriendsTopScoreCache>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string mapName; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<List`1<TopScore>> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateFriendsTopScoreCache>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<TopScore>> <>t__builder; //Field offset: 0x8
		public string mapName; //Field offset: 0x20
		private TaskAwaiter<List`1<TopScore>> <>u__1; //Field offset: 0x28
		private List<TopScore> <mapScores>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class PlayerScoreData
	{
		public string LiNKID; //Field offset: 0x10
		public string avatar; //Field offset: 0x18
		public int score; //Field offset: 0x20

		public PlayerScoreData() { }

	}

	private class ScoreCache
	{
		public List<TopScore> scores; //Field offset: 0x10
		public DateTime createdAt; //Field offset: 0x18
		public String[] friendIds; //Field offset: 0x20

		public ScoreCache() { }

		public bool IsValid(String[] friendIds) { }

	}

	public const int kMaxTopScores = 5; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly StorageManager <ScoresCacheStorage>k__BackingField; //Field offset: 0x0
	private static readonly Dictionary<String, Task`1<List`1<TopScore>>> topScoreUpdateTasks; //Field offset: 0x8
	private static readonly List<String> scoreUpdateQueue; //Field offset: 0x10
	private static readonly Comparison<TopScore> scoreComparer; //Field offset: 0x18

	private static TimeSpan ScoreCacheLife
	{
		private get { } //Length: 159
	}

	private static StorageManager ScoresCacheStorage
	{
		[CompilerGenerated]
		private get { } //Length: 78
	}

	private static IEnumerable<ScoreDifficulty> SortedDifficulties
	{
		private get { } //Length: 472
	}

	private static LiNKFriendsScores() { }

	[AsyncStateMachine(typeof(<AddFriendScoreData>d__17))]
	[Extension]
	private static Task AddFriendScoreData(List<PlayerScoreData> friendRankList, FriendModel playerModel, string mapNameWithDifficulty) { }

	[AsyncStateMachine(typeof(<CacheTopScores>d__23))]
	public static Task CacheTopScores() { }

	private static int CompareScores(TopScore a, TopScore b) { }

	private static TimeSpan get_ScoreCacheLife() { }

	[CompilerGenerated]
	private static StorageManager get_ScoresCacheStorage() { }

	private static IEnumerable<ScoreDifficulty> get_SortedDifficulties() { }

	[AsyncStateMachine(typeof(<GetCachedFriendsTopScores>d__9))]
	private static Task<List`1<TopScore>> GetCachedFriendsTopScores(string mapName) { }

	[AsyncStateMachine(typeof(<GetFriendsTopScores>d__16))]
	private static Task<List`1<TopScore>> GetFriendsTopScores(string mapName, ScoreDifficulty difficulty) { }

	[AsyncStateMachine(typeof(<GetFriendTopScores>d__13))]
	private static Task<List`1<TopScore>> GetFriendTopScores(string mapName) { }

	[AsyncStateMachine(typeof(<GetTopScores>d__8))]
	public static Task<List`1<TopScore>> GetTopScores(string mapName, CancellationToken canceller) { }

	[Extension]
	private static List<TopScore> MergeOwnScore(List<TopScore> topScores, string mapName) { }

	private static ScoreDifficulty ParseDifficulty(string difficulty) { }

	[AsyncStateMachine(typeof(<QueueUpdateFriendsTopScoreCache>d__11))]
	private static Task QueueUpdateFriendsTopScoreCache(string mapName) { }

	[AsyncStateMachine(typeof(<UpdateFriendsTopScoreCache>d__12))]
	private static Task<List`1<TopScore>> UpdateFriendsTopScoreCache(string mapName) { }

}

