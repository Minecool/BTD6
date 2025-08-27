namespace NinjaKiwi.GUTS.CT;

[Extension]
public static class CtWebRequests
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string eventId; //Field offset: 0x0

		public <>c__DisplayClass20_0`1() { }

		internal bool <CT_GetInstanceId>b__0(InstanceIdCache x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string eventId; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <CacheInstanceId>b__0(InstanceIdCache x) { }

	}

	[CompilerGenerated]
	private struct <BaseTicketRequest>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TicketResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public string endpoint; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<TicketResponse> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_ClaimBonusRewards>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BonusRewardClaimResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<BonusRewardClaimResponse> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_GetActivity>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ActivityResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<ActivityResponse> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_GetCompetitiveStatus>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CompetitiveResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<CompetitiveResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_GetInstanceId>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SearchInstanceResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private <>c__DisplayClass20_0<T> <>8__1; //Field offset: 0x0
		private TaskAwaiter<SearchInstanceResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_GetNodeStatus>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<NodeStatusResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public int nodeId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<NodeStatusResponse> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_GetRelics>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RelicsResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SearchUserIdsResponse> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0
		private TaskAwaiter<RelicsResponse> <>u__3; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_GetStatus>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StatusResponse> <>t__builder; //Field offset: 0x0
		public bool canRegister; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<RegisterResponse> <>u__1; //Field offset: 0x0
		private TaskAwaiter<SearchUserIdsResponse> <>u__2; //Field offset: 0x0
		private TaskAwaiter <>u__3; //Field offset: 0x0
		private TaskAwaiter<StatusResponse> <>u__4; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_GetTicketStatus>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TicketResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<SearchUserIdsResponse> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0
		private TaskAwaiter<TicketResponse> <>u__3; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_Register>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RegisterResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<RegisterResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_SearchUser>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SearchUserIdsResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<SearchUserIdsResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_SetActivity>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<EmptyResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public int nodeId; //Field offset: 0x0
		public NodeActivityType nodeActivityType; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<EmptyResponse> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_SetCompetitiveStance>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CompetitiveResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public bool isCompetitive; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<CompetitiveResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_SetScore>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SetScoreResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public CtTile ctTile; //Field offset: 0x0
		public IEnumerable<String> misc; //Field offset: 0x0
		public int nodeId; //Field offset: 0x0
		public int score; //Field offset: 0x0
		public string playerMetadata; //Field offset: 0x0
		public string guildMetadata; //Field offset: 0x0
		public int gameId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<SetScoreResponse> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CT_StartScore>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<EmptyResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public CtTile ctTile; //Field offset: 0x0
		public IEnumerable<String> misc; //Field offset: 0x0
		public int nodeId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<EmptyResponse> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static readonly List<InstanceIdCache> <InstanceIdCaches>k__BackingField; //Field offset: 0x0
	private const string kNoEventId = "NOT_REQUIRED"; //Field offset: 0x0
	private static Tuple<String, String> failedSearchCache; //Field offset: 0x8
	private static CompetitiveResonseCache competitiveResonseCache; //Field offset: 0x10

	internal static List<InstanceIdCache> InstanceIdCaches
	{
		[CompilerGenerated]
		internal get { } //Length: 78
	}

	private static CtWebRequests() { }

	[CompilerGenerated]
	internal static TicketResponse <CT_GetTicketStatus>g__getNoTicketStatus|15_0() { }

	[AsyncStateMachine(typeof(<BaseTicketRequest>d__14`1))]
	private static Task<TicketResponse> BaseTicketRequest(Player<T> player, string eventId, string endpoint) { }

	private static void CacheInstanceId(IEndpointResponse response, int instanceId, string eventId) { }

	private static void CacheOrClearFailedResponse(EndpointResponseBase response, string playerId, string eventId) { }

	[AsyncStateMachine(typeof(<CT_ClaimBonusRewards>d__24`1))]
	[Extension]
	public static Task<BonusRewardClaimResponse> CT_ClaimBonusRewards(Player<T> player, string eventId) { }

	[Extension]
	public static Task<TicketResponse> CT_ClaimGuildTicket(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_GetActivity>d__21`1))]
	[Extension]
	public static Task<ActivityResponse> CT_GetActivity(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_GetCompetitiveStatus>d__26`1))]
	[Extension]
	public static Task<CompetitiveResponse> CT_GetCompetitiveStatus(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_GetInstanceId>d__20`1))]
	[Extension]
	public static Task<SearchInstanceResponse> CT_GetInstanceId(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_GetNodeStatus>d__16`1))]
	[Extension]
	public static Task<NodeStatusResponse> CT_GetNodeStatus(Player<T> player, string eventId, int nodeId) { }

	[AsyncStateMachine(typeof(<CT_GetRelics>d__23`1))]
	[Extension]
	public static Task<RelicsResponse> CT_GetRelics(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_GetStatus>d__11`1))]
	[Extension]
	public static Task<StatusResponse> CT_GetStatus(Player<T> player, string eventId, bool canRegister) { }

	[AsyncStateMachine(typeof(<CT_GetTicketStatus>d__15`1))]
	[Extension]
	public static Task<TicketResponse> CT_GetTicketStatus(Player<T> player, string eventId) { }

	[Extension]
	public static Task<KickResponse> CT_KickPlayer(Player<T> player, string guildMemberId) { }

	[Extension]
	public static Task<EmptyResponse> CT_KickPlayerUndo(Player<T> player, string guildMemberId) { }

	[Extension]
	public static Task<TicketResponse> CT_PurchaseTicket(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_Register>d__3`1))]
	[Extension]
	public static Task<RegisterResponse> CT_Register(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_SearchUser>d__4`1))]
	[Extension]
	public static Task<SearchUserIdsResponse> CT_SearchUser(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<CT_SetActivity>d__22`1))]
	[Extension]
	public static Task<EmptyResponse> CT_SetActivity(Player<T> player, string eventId, NodeActivityType nodeActivityType, int nodeId) { }

	[AsyncStateMachine(typeof(<CT_SetCompetitiveStance>d__27`1))]
	[Extension]
	public static Task<CompetitiveResponse> CT_SetCompetitiveStance(Player<T> player, string eventId, bool isCompetitive) { }

	[AsyncStateMachine(typeof(<CT_SetScore>d__10`1))]
	[Extension]
	public static Task<SetScoreResponse> CT_SetScore(Player<T> player, string eventId, int nodeId, int score, int gameId, string playerMetadata = null, string guildMetadata = null, CtTile ctTile = null, IEnumerable<String> misc = null) { }

	[AsyncStateMachine(typeof(<CT_StartScore>d__9`1))]
	[Extension]
	public static Task<EmptyResponse> CT_StartScore(Player<T> player, string eventId, int nodeId, CtTile ctTile = null, IEnumerable<String> misc = null) { }

	[CompilerGenerated]
	internal static List<InstanceIdCache> get_InstanceIdCaches() { }

	private static string GetFailedSearchCacheKey(string guildId, string userId, string eventId) { }

	private static void SetEventDataConfig(IUserServerIdsResponse response, string eventId) { }

	private static bool TryGetCachedFailedSearchResponse(string playerId, string eventId, out string error) { }

}

