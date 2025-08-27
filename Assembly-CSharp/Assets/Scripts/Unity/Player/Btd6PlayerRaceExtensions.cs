namespace Assets.Scripts.Unity.Player;

[Extension]
public static class Btd6PlayerRaceExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RacePassClaim, Int32> <>9__7_0; //Field offset: 0x8
		public static Func<RaceEventData, Boolean> <>9__18_0; //Field offset: 0x10
		public static Func<RaceEventData, String> <>9__18_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GetRaceWithPendingRewards>b__18_0(RaceEventData x) { }

		internal string <GetRaceWithPendingRewards>b__18_1(RaceEventData x) { }

		internal int <GetUnverifiedRacePassBalance>b__7_0(RacePassClaim x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public string raceEventId; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <TryGetRaceEventData>b__0(RaceEventData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public IEnumerable<String> raceIdsWithPendingRewards; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <GetRaceWithPendingRewards>b__2(RaceEvent x) { }

	}

	[CompilerGenerated]
	private struct <ClaimRacePass>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public RacePassClaim racePassClaim; //Field offset: 0x28
		private ProfileModel <playerData>5__2; //Field offset: 0x30
		private int <previousBalance>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<Int32> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ClaimRacePassWithLink>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public RacePassClaim racePassClaim; //Field offset: 0x20
		public Btd6Player player; //Field offset: 0x28
		private LootFrom <claimSource>5__2; //Field offset: 0x30
		private int <ammount>5__3; //Field offset: 0x34
		private string <transactionId>5__4; //Field offset: 0x38
		private TimeSpan <minClaimInterval>5__5; //Field offset: 0x40
		private bool <canClaim>5__6; //Field offset: 0x48
		private Nullable<Int32> <remoteBalance>5__7; //Field offset: 0x4C
		private TaskAwaiter<PubSubChannelModel> <>u__1; //Field offset: 0x58
		private TaskAwaiter<BankPurchaseModel> <>u__2; //Field offset: 0x60
		private byte <attempt>5__8; //Field offset: 0x68
		private TaskAwaiter<PubSubMessageModel> <>u__3; //Field offset: 0x70
		private TaskAwaiter <>u__4; //Field offset: 0x78
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__5; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnterRace>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string raceEventID; //Field offset: 0x28
		public RaceStartMethod startMethod; //Field offset: 0x30
		public KonFuze raceEntryCost; //Field offset: 0x38
		public string mmSpendSource; //Field offset: 0x40
		private OnlineProfileModel <onlineData>5__2; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetRaceWithPendingRewards>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RaceEvent> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		private RaceEvent <raceWithPendingRewards>5__2; //Field offset: 0x28
		private TaskAwaiter<Race> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpendRacePass>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string raceId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<BankPurchaseModel> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncPendingRacePassTransactions>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		private int <previousBalance>5__2; //Field offset: 0x28
		private List<RacePassClaim> <unverifiedClaims>5__3; //Field offset: 0x30
		private Nullable<Int64> <remoteBalance>5__4; //Field offset: 0x38
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x48
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncRacePassCount>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		private Task <syncTask>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string WALLET_RACES = "races"; //Field offset: 0x0
	private const string CURRENCY_RACEPASS = "RacePass"; //Field offset: 0x0

	[Extension]
	private static void AddNewRaceData(Btd6Player player, string id, bool hasCompletedOneRun) { }

	[Extension]
	private static void AddNewRaceData(Btd6Player player, RaceEventData raceEventData) { }

	[Extension]
	public static void ClaimedRaceRewards(Btd6Player player, string raceEventID) { }

	[Extension]
	public static Task ClaimRacePass(Btd6Player player, LootFrom claimSource, int qty, string transactionId) { }

	[AsyncStateMachine(typeof(<ClaimRacePass>d__5))]
	[Extension]
	public static Task ClaimRacePass(Btd6Player player, RacePassClaim racePassClaim) { }

	[AsyncStateMachine(typeof(<ClaimRacePassWithLink>d__8))]
	[Extension]
	private static Task<Int32> ClaimRacePassWithLink(Btd6Player player, RacePassClaim racePassClaim) { }

	[Extension]
	public static void CompletedRace(Btd6Player player, string raceEventID) { }

	[AsyncStateMachine(typeof(<EnterRace>d__11))]
	[Extension]
	public static Task EnterRace(Btd6Player player, string raceEventID, RaceStartMethod startMethod, KonFuze raceEntryCost, string mmSpendSource) { }

	[Extension]
	public static int GetRaceEntryCost(Btd6Player player, string raceEventId, Race race, out RaceStartMethod raceStartMethod) { }

	[Extension]
	private static string GetRacePassPubSubChannel(Btd6Player player) { }

	[AsyncStateMachine(typeof(<GetRaceWithPendingRewards>d__18))]
	[Extension]
	public static Task<RaceEvent> GetRaceWithPendingRewards(Btd6Player player) { }

	[Extension]
	private static int GetUnverifiedRacePassBalance(Btd6Player player) { }

	[Extension]
	public static bool HasCompletedRace(Btd6Player player, string raceEventID) { }

	[AsyncStateMachine(typeof(<SpendRacePass>d__9))]
	[Extension]
	public static Task SpendRacePass(Btd6Player player, string raceId) { }

	[AsyncStateMachine(typeof(<SyncPendingRacePassTransactions>d__3))]
	[Extension]
	private static Task SyncPendingRacePassTransactions(Btd6Player player) { }

	[AsyncStateMachine(typeof(<SyncRacePassCount>d__6))]
	[Extension]
	public static Task SyncRacePassCount(Btd6Player player) { }

	[Extension]
	private static bool TryGetRaceEventData(Btd6Player player, string raceEventId, out RaceEventData raceEventData) { }

}

