namespace Assets.Scripts.Unity.Player;

public class Btd6Player : Player<ProfileModel>
{
	[CompilerGenerated]
	private struct <_GetOnlineData>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<OnlineProfileModel> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x28
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_SyncTeamTrophyBalance>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<TowerModel> <>9__66_0; //Field offset: 0x8
		public static Predicate<TowerModel> <>9__66_1; //Field offset: 0x10
		public static Predicate<TowerModel> <>9__66_2; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, Int64>, Boolean> <>9__76_0; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, Int64>, String> <>9__76_1; //Field offset: 0x28
		public static Func<Int32, UnclaimedTrophies, Int32> <>9__79_0; //Field offset: 0x30
		public static Func<BossEventData, Boolean> <>9__239_1; //Field offset: 0x38
		public static Func<BossEventData, String> <>9__239_2; //Field offset: 0x40
		public static Func<CTEventData, Boolean> <>9__264_0; //Field offset: 0x48
		public static Func<CTEventData, String> <>9__264_1; //Field offset: 0x50
		public static Func<BossRushSaveData, Boolean> <>9__276_0; //Field offset: 0x58
		public static Func<BossRushSaveData, String> <>9__276_1; //Field offset: 0x60
		public static Func<ContentTypeSaveData, Boolean> <>9__313_0; //Field offset: 0x68

		private static <>c() { }

		public <>c() { }

		internal int <CalculateUnclaimedTrophiesBalance>b__79_0(int amount, UnclaimedTrophies unclaimed) { }

		internal bool <CanCheckForReceivedAccolades>b__313_0(ContentTypeSaveData x) { }

		internal bool <CheckRetrospectiveRewards>b__66_0(TowerModel x) { }

		internal bool <CheckRetrospectiveRewards>b__66_1(TowerModel x) { }

		internal bool <CheckRetrospectiveRewards>b__66_2(TowerModel x) { }

		internal bool <GetBossRushWithPendingRewards>b__276_0(BossRushSaveData x) { }

		internal string <GetBossRushWithPendingRewards>b__276_1(BossRushSaveData x) { }

		internal bool <GetBossWithPendingRewards>b__239_1(BossEventData x) { }

		internal string <GetBossWithPendingRewards>b__239_2(BossEventData x) { }

		internal bool <GetCTWithPendingRewards>b__264_0(CTEventData x) { }

		internal string <GetCTWithPendingRewards>b__264_1(CTEventData x) { }

		internal bool <SyncTrophyBalanceNotSynchronised>b__76_0(KeyValuePair<String, Int64> x) { }

		internal string <SyncTrophyBalanceNotSynchronised>b__76_1(KeyValuePair<String, Int64> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass130_0
	{
		public string heroBaseId; //Field offset: 0x10
		public Btd6Player <>4__this; //Field offset: 0x18

		public <>c__DisplayClass130_0() { }

		internal bool <HasAnyUnseenSkins>b__0(SkinData skin) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass239_0
	{
		public Btd6Player <>4__this; //Field offset: 0x10
		public IEnumerable<String> bossIdsWithPendingRewards; //Field offset: 0x18
		public BossEvent bossEventPendingRewards; //Field offset: 0x20

		public <>c__DisplayClass239_0() { }

		internal bool <GetBossWithPendingRewards>b__0(string x) { }

		internal bool <GetBossWithPendingRewards>b__3(BossEvent x) { }

		internal bool <GetBossWithPendingRewards>b__5(BossEventData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass239_1
	{
		public string x; //Field offset: 0x10

		public <>c__DisplayClass239_1() { }

		internal bool <GetBossWithPendingRewards>b__4(BossEventData y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass262_0
	{
		public string eventId; //Field offset: 0x10

		public <>c__DisplayClass262_0() { }

		internal bool <TryGetCTEventData>b__0(CTEventData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass264_0
	{
		public IEnumerable<String> ctIdsWithPendingRewards; //Field offset: 0x10

		public <>c__DisplayClass264_0() { }

		internal bool <GetCTWithPendingRewards>b__2(CtEvent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass270_0
	{
		public BossRushEvent activeBossRushEvent; //Field offset: 0x10

		public <>c__DisplayClass270_0() { }

		internal bool <HasNewBossRushEvent>b__0(BossRushSaveData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass274_0
	{
		public string eventId; //Field offset: 0x10

		public <>c__DisplayClass274_0() { }

		internal bool <TryGetBossRushEventData>b__0(BossRushSaveData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass276_0
	{
		public IEnumerable<String> idsWithPendingRewards; //Field offset: 0x10

		public <>c__DisplayClass276_0() { }

		internal bool <GetBossRushWithPendingRewards>b__2(BossRushEvent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass296_0
	{
		public string questId; //Field offset: 0x10

		public <>c__DisplayClass296_0() { }

		internal bool <GetQuestSaveData>b__0(QuestSaveData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass297_0
	{
		public QuestSaveData questSaveData; //Field offset: 0x10

		public <>c__DisplayClass297_0() { }

		internal bool <SetQuestSaveData>b__0(QuestSaveData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass310_0
	{
		public Btd6Player <>4__this; //Field offset: 0x10
		public String[] questIdsWithPendingRewards; //Field offset: 0x18
		public QuestEvent questEventPendingRewards; //Field offset: 0x20

		public <>c__DisplayClass310_0() { }

		internal bool <GetQuestWithPendingRewards>b__0(string x) { }

		internal bool <GetQuestWithPendingRewards>b__1(QuestEvent x) { }

		internal bool <GetQuestWithPendingRewards>b__3(BossEventData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass310_1
	{
		public string x; //Field offset: 0x10

		public <>c__DisplayClass310_1() { }

		internal bool <GetQuestWithPendingRewards>b__2(QuestEventData y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass314_0
	{
		public IReadOnlyCollection<String> featuredMapIds; //Field offset: 0x10
		public ContentTypeSaveData playerMapSaveData; //Field offset: 0x18

		public <>c__DisplayClass314_0() { }

		internal bool <HasSeenFeaturedMaps>b__0(string x) { }

		internal bool <HasSeenFeaturedMaps>b__1(string activeFeaturedMapEventId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public Btd6Player <>4__this; //Field offset: 0x10
		public List<String> remotePurchasedItemIds; //Field offset: 0x18

		public <>c__DisplayClass76_0() { }

		internal bool <SyncTrophyBalanceNotSynchronised>g__hasPurchasedItem|2(TrophyStoreItem trophyStoreItem) { }

	}

	[CompilerGenerated]
	private struct <CanCheckForReceivedAccolades>d__313 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CanPlaySweepstakes>d__320 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private TaskAwaiter<SweepstakesParticipationResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CanShowEndedEvent>d__321 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public SweepstakesEvent sweepstakesEvent; //Field offset: 0x20
		public Btd6Player <>4__this; //Field offset: 0x28
		public bool requiresParticipation; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CanUseCtTicket>d__268 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CtEvent ctEvent; //Field offset: 0x20
		public Btd6Player <>4__this; //Field offset: 0x28
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckHakrStatus>d__213 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string otherPlayerLinkId; //Field offset: 0x20
		private long <flagValue>5__2; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckMultiHakrStatus>d__214 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public IEnumerable<String> playerLinkIds; //Field offset: 0x28
		private TaskAwaiter<SingleWallet> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CPU>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private bool <needToSave>5__2; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <EnabledTrophyStoreItems>d__219 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Btd6Player <>4__this; //Field offset: 0x28
		private Enumerator<String, TrophyStoreSD> <>7__wrap1; //Field offset: 0x30

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <EnabledTrophyStoreItems>d__219(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <GainTrophies>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public int amount; //Field offset: 0x28
		public string gainedFrom; //Field offset: 0x30
		public string transactionId; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBossWithPendingRewards>d__239 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossEvent> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private <>c__DisplayClass239_0 <>8__1; //Field offset: 0x28
		private IEnumerable<BossEvent> <endedEvents>5__2; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter<BossDataModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLinkFlagStatus>d__210 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private bool <isFlagged>5__2; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetOnlineData>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<OnlineProfileModel> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x28
		public bool throwInternetException; //Field offset: 0x38
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetQuestWithPendingRewards>d__310 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<QuestEvent> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private <>c__DisplayClass310_0 <>8__1; //Field offset: 0x28
		private IEnumerable<QuestEvent> <endedEvents>5__2; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter<QuestDataModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeOnlineProfile>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadOnlineData>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MigrateNoLinkId>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public string newId; //Field offset: 0x28
		public string oldId; //Field offset: 0x30
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MigrateWalletFromNoLinkToLiNKID>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OneTimeStartUpChecks>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private bool <needSave>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38
		private bool <>7__wrap2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RemoveTrophyStoreItemAsync>d__221 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string trophyStoreItemId; //Field offset: 0x28
		public Btd6Player <>4__this; //Field offset: 0x30
		private TrophyStoreItem <trophyStoreItem>5__2; //Field offset: 0x38
		private int <attempt>5__3; //Field offset: 0x40
		private object <>7__wrap3; //Field offset: 0x48
		private int <>7__wrap4; //Field offset: 0x50
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetCurrentQuestRewards>d__286 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public QuestEvent questEvent; //Field offset: 0x28
		private QuestSettings <questsSku>5__2; //Field offset: 0x30
		private int <i>5__3; //Field offset: 0x38
		private Dictionary<Int32, LootSet> <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private TaskAwaiter<LootSet> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpendTrophies>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public string itemId; //Field offset: 0x28
		public int amount; //Field offset: 0x30
		public string itemName; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<BankPurchaseModel> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SPU>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x28
		public PUS puStatus; //Field offset: 0x30
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncNow>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncTeamTrophyBalance>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public bool forceRefresh; //Field offset: 0x28
		private TimeSpan <now>5__2; //Field offset: 0x30
		private Task <syncTask>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncTrophyBalance>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private Task <syncTask>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncTrophyBalanceNotSynchronised>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public bool forceRefresh; //Field offset: 0x28
		private <>c__DisplayClass76_0 <>8__1; //Field offset: 0x30
		private Nullable<Int64> <remoteBalance>5__2; //Field offset: 0x38
		private UnclaimedTrophies <unclaimed>5__3; //Field offset: 0x48
		private TaskAwaiter<BankPurchaseModel> <>u__1; //Field offset: 0x50
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryGetLinkFlagStatus>d__211 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ViewAndSetCurrentBossRushEvent>d__273 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"hasInternetIssues", "isNewEvent"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Boolean>> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public BossRushEvent bossRushEvent; //Field offset: 0x28
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ViewAndSetCurrentCTEvent>d__261 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"hasInternetIssues", "isNewEvent"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Boolean>> <>t__builder; //Field offset: 0x8
		public Btd6Player <>4__this; //Field offset: 0x20
		public CtEvent ctEvent; //Field offset: 0x28
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ViewAndSetCurrentQuestEvent>d__283 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public QuestEvent questEvent; //Field offset: 0x20
		public Btd6Player <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string GNLHKR_CURRENCY = "0x0A"; //Field offset: 0x0
	private const string TROPHY_ITEM = "Trophies"; //Field offset: 0x0
	private const string TROPHY_CURRENCY = "trophies"; //Field offset: 0x0
	private const string TROPHY_WALLET = "trophyStore"; //Field offset: 0x0
	private const string PU_CURRENCY = "0xPU"; //Field offset: 0x0
	public const string ACCDATA_WALLET = "NK_ACCDATA"; //Field offset: 0x0
	public bool debugUnlockAllUpgrades; //Field offset: 0x98
	public bool debugUnlockAllTowers; //Field offset: 0x99
	public bool debugUnlockAllPowersPro; //Field offset: 0x9A
	public bool debugSeenAllRounds; //Field offset: 0x9B
	public bool debugSimulateSaveFail; //Field offset: 0x9C
	[CompilerGenerated]
	private DateTime <LastSyncTime>k__BackingField; //Field offset: 0xA0
	private Task trophySyncTask; //Field offset: 0xA8
	private Task teamTrophySyncTask; //Field offset: 0xB0
	private bool lastSaveFailed; //Field offset: 0xB8
	public Action OnXpRankChanged; //Field offset: 0xC0
	[CompilerGenerated]
	private EventHandler OnSaveCompleted; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <IsPendingSave>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <IsPendingSync>k__BackingField; //Field offset: 0xD1
	[CompilerGenerated]
	private readonly PubSub <PubSub>k__BackingField; //Field offset: 0xD8
	private OnlineProfileModel onlineProfileModel; //Field offset: 0xE0
	public Action OnOnlineProfileRefreshed; //Field offset: 0xE8
	private Task<OnlineProfileModel> onlineDataTask; //Field offset: 0xF0
	private bool hasForceRefreshedOnce; //Field offset: 0xF8
	[CompilerGenerated]
	private int <TeamTrophyBalance>k__BackingField; //Field offset: 0xFC
	private Nullable<TimeSpan> lastTeamTrophyRefresh; //Field offset: 0x100
	public Action OnRacePassBalanceChanged; //Field offset: 0x110
	[CompilerGenerated]
	private Task <RacePassSyncTask>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private int <RacePassCount>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Action instaTowersQuanityChanged; //Field offset: 0x128
	[CompilerGenerated]
	private bool <IsFlagged>k__BackingField; //Field offset: 0x130
	private OdysseySaveData odysseySaveData; //Field offset: 0x138
	private Dictionary<Int32, LootSet> currentBossTierRewards; //Field offset: 0x140
	private Dictionary<Int32, LootSet> currentSubQuestRewards; //Field offset: 0x148
	private Nullable<Boolean> _canPlaySweepstakes; //Field offset: 0x150
	private MobileWebviewLiNKAccountController webviewLiNKAccountController; //Field offset: 0x158

	public event Action instaTowersQuanityChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event EventHandler OnSaveCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool CanEarnMoneyFromAccolades
	{
		 get { } //Length: 144
	}

	public bool HasLinkAccount
	{
		 get { } //Length: 51
	}

	public bool IsChildAccount
	{
		 get { } //Length: 118
	}

	public private bool IsFlagged
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsPendingSave
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsPendingSync
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsSelectedLanguageRTL
	{
		 get { } //Length: 68
	}

	public private DateTime LastSyncTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public OnlineProfileModel OnlineData
	{
		 get { } //Length: 78
	}

	public PubSub PubSub
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int RacePassCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Task RacePassSyncTask
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string SafeDisplayName
	{
		 get { } //Length: 89
	}

	public int TeamTrophyBalance
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[AsyncStateMachine(typeof(<_GetOnlineData>d__57))]
	private Task<OnlineProfileModel> _GetOnlineData(Nullable<TimeSpan> timeoutOverride) { }

	[AsyncStateMachine(typeof(<_SyncTeamTrophyBalance>d__87))]
	private Task _SyncTeamTrophyBalance() { }

	public Btd6Player() { }

	[CompilerGenerated]
	private void <.ctor>b__22_0() { }

	public void AcquireKnowledge(string knowledgeId) { }

	public void AcquireUpgrade(string towerId, string upgradeId, float xpCost) { }

	[CompilerGenerated]
	public void add_instaTowersQuanityChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSaveCompleted(EventHandler value) { }

	public void AddBossBadges(BossType bossType, bool isElite, int amount) { }

	public void AddBossLeaderboardBadges(LeaderboardBadgeType badgeType, int amount, bool isElite) { }

	public void AddCtLeaderboardBadges(LeaderboardBadgeType badgeType, int amount, bool isGlobal) { }

	public void AddInstaTower(string baseTowerID, Int32[] tiers, int qty = 1) { }

	public void AddLegendBadges(string legendKey, bool isCompleted, int amount) { }

	public void AddNewBossData(BossEventData eventData) { }

	public void AddNewBossRushData(BossRushSaveData eventData) { }

	public void AddNewCTData(CTEventData eventData) { }

	public void AddNewQuestData(QuestEventData eventData) { }

	public void AddPower(string powerId, int qty = 1) { }

	public void AddRaceBadges(LeaderboardBadgeType badgeType, int amount) { }

	public void AddTowerXP(string towerID, float xpToAdd) { }

	public void AddTrophyStoreItem(string trophyStoreItemId) { }

	public bool AnyNewInstaTowers() { }

	public bool AnyNewPowers() { }

	public void BossEventBestRound(bool isElite, int highestCompletedRound) { }

	private int CalculateUnclaimedTrophiesBalance() { }

	public bool CanAcquireUpgrade(string towerID, float xpCost) { }

	[AsyncStateMachine(typeof(<CanCheckForReceivedAccolades>d__313))]
	public Task<Boolean> CanCheckForReceivedAccolades() { }

	[AsyncStateMachine(typeof(<CanPlaySweepstakes>d__320))]
	public Task<Boolean> CanPlaySweepstakes() { }

	[AsyncStateMachine(typeof(<CanShowEndedEvent>d__321))]
	public Task<Boolean> CanShowEndedEvent(SweepstakesEvent sweepstakesEvent, bool requiresParticipation) { }

	public bool CanUnlockMap(string map) { }

	[AsyncStateMachine(typeof(<CanUseCtTicket>d__268))]
	public Task<Boolean> CanUseCtTicket(CtEvent ctEvent) { }

	public bool CheckAndCorrectLevelBasedOnPlayerXp() { }

	public void CheckCompatibility(Dictionary<String, String> lobbyParameters) { }

	public bool CheckExtraSettingsNotify() { }

	public bool CheckForNewParagonPipEvent(string checkSpecificTowerId = "", string checkSpecificTowerSet = "") { }

	[AsyncStateMachine(typeof(<CheckHakrStatus>d__213))]
	public Task<Boolean> CheckHakrStatus(string otherPlayerLinkId) { }

	[AsyncStateMachine(typeof(<CheckMultiHakrStatus>d__214))]
	public Task<Boolean> CheckMultiHakrStatus(IEnumerable<String> playerLinkIds) { }

	public bool CheckRetrospectiveRewards() { }

	public bool CheckSettingsNotify() { }

	private void CheckTrophiesBalance() { }

	public void ClaimedBossRewards(string eventId) { }

	public void ClaimedCTRewards(string ctEventID) { }

	public void ClearCurrentBossRushEvent() { }

	public void ClearCurrentCtEvent() { }

	public void ClearQuestSaveData(string questId, bool wipeEverything = false) { }

	public void ClearTeamTrophyWalletCache() { }

	public ValueTuple<Boolean, Boolean, Boolean, Boolean> CompareBossChallengeScores(BossScoreComponents newRecord, BossScoreComponents savedRecord) { }

	public void CompleteBossEvent(bool isElite) { }

	public void CompletedRound(string map, string difficulty, string mode, int round, bool isCoopMode) { }

	public void CompleteGoldenBloon(string mapId, bool onQuit = false, int goldenBloonsPopped = 0) { }

	public void CompleteMap(string map) { }

	public void CompleteMode(string map, string difficulty, string mode, bool completedWithoutLoadingSave, bool isCoopMode) { }

	public void CompleteMonkeyTeams() { }

	public void ConsumeInstaTower(string baseTowerID, Int32[] tiers) { }

	public void ConsumePower(string powerId, int qty = 1) { }

	[AsyncStateMachine(typeof(<CPU>d__69))]
	public Task<Boolean> CPU() { }

	public void DefeatedBossTier(bool eliteMode, int tier, LootSet lootSet) { }

	public void DrainXP(Xp xpToDrain) { }

	[IteratorStateMachine(typeof(<EnabledTrophyStoreItems>d__219))]
	public IEnumerable<String> EnabledTrophyStoreItems() { }

	public void GainMonkeyMoney(int amount, string gainedFrom) { }

	public void GainPlayerXP(float amount) { }

	[AsyncStateMachine(typeof(<GainTrophies>d__77))]
	public Task GainTrophies(int amount, string gainedFrom, string transactionId = null) { }

	private void GenerateNewGoldenBloonMap(MapDifficulty mapDifficulty) { }

	private void GenerateNewMonkeyTeamsMap(MapDifficulty mapDifficulty) { }

	public Btd6PlayerStats GeneratePlayerStats() { }

	public PublicProfileModel GeneratePublicProfile() { }

	public bool get_CanEarnMoneyFromAccolades() { }

	public bool get_HasLinkAccount() { }

	public bool get_IsChildAccount() { }

	[CompilerGenerated]
	public bool get_IsFlagged() { }

	[CompilerGenerated]
	public bool get_IsPendingSave() { }

	[CompilerGenerated]
	public bool get_IsPendingSync() { }

	public bool get_IsSelectedLanguageRTL() { }

	[CompilerGenerated]
	public DateTime get_LastSyncTime() { }

	public OnlineProfileModel get_OnlineData() { }

	[CompilerGenerated]
	public PubSub get_PubSub() { }

	[CompilerGenerated]
	public int get_RacePassCount() { }

	[CompilerGenerated]
	public Task get_RacePassSyncTask() { }

	public string get_SafeDisplayName() { }

	[CompilerGenerated]
	public int get_TeamTrophyBalance() { }

	public bool GetAchievementClaimed(int achievementId) { }

	public bool GetAchievementPostedToGooglePlay(int achievementId) { }

	public HashSet<Int32> GetAchievementsClaimed() { }

	public Dictionary<Int32, Single> GetAchievementsProgress() { }

	public AnalyticsKonFuze GetAnalyticsInfo() { }

	public Dictionary<String, Dictionary`2<String, BossScoreComponents>> GetBossChallengeRecordByPlayerCount(int playerCount) { }

	private static string GetBossChallengeTypeKey(BossType bossType, bool isElite) { }

	public Dictionary<Int32, KonFuze> GetBossLeaderboardBadges(bool isElite) { }

	public BossRushEvent GetBossRushWithPendingRewards() { }

	[AsyncStateMachine(typeof(<GetBossWithPendingRewards>d__239))]
	public Task<BossEvent> GetBossWithPendingRewards() { }

	public Dictionary<Int32, KonFuze> GetCtLeaderboardBadges(bool isGlobal) { }

	public CtEvent GetCTWithPendingRewards() { }

	public LootSet GetCurrentBossTierRewards(int bossTier, bool isElite) { }

	public LootSet GetCurrentBossTierRewardsConverted(int bossTier, bool isElite) { }

	public String[] GetCurrentMonkeyTeam() { }

	public GoldenBloonMapData GetGoldenBloonMapDataForDifficulty(MapDifficulty mapDifficulty) { }

	public int GetHighestSeenRound() { }

	public bool GetIfWonCTTile(int tileID) { }

	public InstaTowerModel GetInstaTower(TowerModel towerModel) { }

	private InstaTowerModel GetInstaTower(string baseTowerID, Int32[] tiers) { }

	public int GetInstaTowerGroupQuanity(string baseTowerID) { }

	public List<InstaTowerModel> GetInstaTowers(string baseTowerID) { }

	public int GetLastSelectedTaskIndex(string questId, int questPartIndex) { }

	[AsyncStateMachine(typeof(<GetLinkFlagStatus>d__210))]
	public Task<Boolean> GetLinkFlagStatus() { }

	public float GetMonkeyMoney() { }

	public MonkeyTeamMapData GetMonkeyTeamsMapDataForDifficulty(MapDifficulty mapDifficulty) { }

	public int GetNumberOfInstaTowers() { }

	public int GetNumOfLegendsBadges() { }

	[AsyncStateMachine(typeof(<GetOnlineData>d__55))]
	public Task<OnlineProfileModel> GetOnlineData(Nullable<TimeSpan> timeoutOverride = null, bool throwInternetException = false) { }

	public int GetOwnedHeroesAndSkins(List<HeroDetailsModel> selectedHeroes, bool includeHidden) { }

	public PlayerCosmeticInfo GetPlayerCosmetics(List<String> overriddenPlayerCosmetics = null, Nullable<Boolean> disablePlayerCosmetics = null, Dictionary<String, String> skinOverride = null) { }

	public OdysseySaveData GetPlayingOdysseySaveData() { }

	public PowerData GetPowerData(string powerId) { }

	public int GetPowerUseCount(string powerId) { }

	public QuestSaveData GetQuestSaveData(string questId) { }

	[AsyncStateMachine(typeof(<GetQuestWithPendingRewards>d__310))]
	public Task<QuestEvent> GetQuestWithPendingRewards() { }

	public string GetSelectedHeroSkin() { }

	public SkinData GetSelectedSkin(string heroBaseId = null) { }

	public string GetSelectedTowerSkin(string baseTowerId) { }

	private string GetSkinId(string heroId) { }

	public QuestTaskSaveData GetTaskSaveDataForQuestPartFromIndex(string questId, int questPartIndex, int taskIndex) { }

	public int GetTotalKnowledgeEarned() { }

	public float GetTowerXP(string towerId) { }

	public bool GoldenBloonActiveAndUnlocked() { }

	public bool HasAchievementBeenPostedToXBoxLive(int achievementId) { }

	public bool HasAnyUnseenSkins(string heroBaseId) { }

	public bool HasClaimedQuestPartReward(string questId, int questPartIndex) { }

	public bool HasClaimedQuestTaskReward(string questId, int questPartIndex, int taskIndex) { }

	public bool HasCompletedMap(string map) { }

	public bool HasCompletedMode(string map, string difficulty, string mode, bool coop, bool checkCompletedWithoutLoadingSave = false) { }

	public bool HasCompletedQuestPart(string questId, int questPartIndex) { }

	public bool HasCompletedQuestTask(string questId, int questPartIndex, int taskIndex) { }

	public bool HasDefeatedBossTier(bool eliteMode, int tier) { }

	public bool HasFirstCompletedMapMmBonusBeenRewarded(string map, string difficulty, string mode, bool isCoopMode) { }

	public bool HasInstaTower() { }

	public bool HasKnowledge(string knowledgeId) { }

	public bool HasMapGotGoldenBloon(string mapId) { }

	public bool HasMapGotMonkeyTeams(string mapId) { }

	public bool HasNewBossRushEvent() { }

	public bool HasNewCtEventToSignup() { }

	public bool HasPowerExistedInData(string powerId) { }

	public bool HasPurchasedLegends(LegendsType legendsType) { }

	public bool HasPurchasedMusicTrack(string trackName) { }

	public bool HasPurchasedParagonUpgrade(string upgradeId) { }

	public bool HasSeenAchievement(int achievementId) { }

	public bool HasSeenAllEvents(String[] eventIds) { }

	public bool HasSeenCompletedMode(string map, string difficulty, string mode, bool isCoopMode) { }

	public bool HasSeenEvent(string eventId) { }

	public bool HasSeenFeaturedMaps() { }

	public bool HasSeenHeroUnlocked(string heroId = null) { }

	public bool HasSeenHeroUnlockedNotification() { }

	public bool HasSeenModeComplete(string map, string difficulty, string mode, bool isCoopMode, bool completedWithoutLoadingSave) { }

	public bool HasSeenModeUnlock(string map, string difficulty, string mode, bool isCoopMode) { }

	public bool HasSeenNewHeroNotification(string heroId) { }

	public bool HasSeenNewMap(string map) { }

	public bool HasSeenNewMapDifficulty(string map) { }

	public bool HasSeenQuest(string questId) { }

	public bool HasSeenQuestDialogue(string questId, DialogueData dialogueData, int questPartIndex, int taskIndex = -1) { }

	public bool HasSeenQuestPart(string questId, int questPartIndex) { }

	public bool HasSeenRound(int roundArrayIndex) { }

	public bool HasSeenTowerSkin(string skinId) { }

	public bool HasSeenUpgrade(string upgradeId) { }

	public bool HasSubmittedBossScore(string eventId, int bossTier, int gameId) { }

	public bool HasUnlockedHero(string towerId) { }

	public bool HasUnlockedTower(string towerId, bool ignoreDebug = false) { }

	public bool HasUnlockedTowerSkin(string towerSkinId) { }

	public bool HasUnseenLegend() { }

	public bool HasUnseenNewTowerNotification(TowerSet towerSet) { }

	public bool HasUpgrade(string upgradeId) { }

	[AsyncStateMachine(typeof(<InitializeOnlineProfile>d__60))]
	private void InitializeOnlineProfile(LiNKAccount _) { }

	public bool IsInstaTowerGroupAvailable(string baseTowerID) { }

	public bool IsMapUnlocked(string map) { }

	public bool IsModeUnlocked(string map, string difficulty, string mode, bool isCoopMode) { }

	public ValueTuple<Boolean, Boolean> IsParagonUpgradeAvailable(string towerId, string checkSpecificTowerSet) { }

	public bool IsPowerAvailable(PowerModel powerModel) { }

	public bool IsPU() { }

	public static bool IsUsedTransactionId(InvalidRequestException ex) { }

	public bool LastSaveFailedCheckAndReset() { }

	[AsyncStateMachine(typeof(<LoadOnlineData>d__59))]
	public Task LoadOnlineData() { }

	public void MigrateIDsAfterLogin(LiNKAccount newLiNKAccount) { }

	[AsyncStateMachine(typeof(<MigrateNoLinkId>d__64))]
	public Task<Boolean> MigrateNoLinkId(string oldId, string newId) { }

	[AsyncStateMachine(typeof(<MigrateWalletFromNoLinkToLiNKID>d__72))]
	private void MigrateWalletFromNoLinkToLiNKID() { }

	public bool MonkeyTeamsActiveAndUnlocked() { }

	public bool NeedsToShowLevelCapIncreasedInfo() { }

	public bool NeedsToShowVeteranRankInfo() { }

	[AsyncStateMachine(typeof(<OneTimeStartUpChecks>d__63))]
	public Task OneTimeStartUpChecks() { }

	public void OpenedOdyssey(OdysseySaveData odysseySaveData) { }

	public Task OpenWebview() { }

	public int PUMMM(int mmCost) { }

	public bool RankUp() { }

	public bool RankUpAvailable() { }

	public void RecordEventClaimedQuestRewards(string questId, int questPartIndex, bool hasClaimedSpecialEventRewards) { }

	public void RecordQuestTaskIndexNewHighScore(string questId, int questPartIndex, int taskIndex, long score) { }

	public void RecordQuestTaskIndexRewardsClaimed(string questId, int questPartIndex, int taskIndex) { }

	[CompilerGenerated]
	public void remove_instaTowersQuanityChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSaveCompleted(EventHandler value) { }

	public void RemoveSeenEvent(string eventId) { }

	[AsyncStateMachine(typeof(<RemoveTrophyStoreItemAsync>d__221))]
	public void RemoveTrophyStoreItemAsync(string trophyStoreItemId) { }

	public void RemoveUnlockedTower(string towerId) { }

	public void ResetOnlineProfile() { }

	public void ResetQuestSaveData(string questId) { }

	public void RotateMonkeyTeamsMap(string prevMapId) { }

	public virtual void Save() { }

	public void SaveAndSync() { }

	public void SaveHasSeenQuest(string questId) { }

	public void SaveNow() { }

	public void SaveQuestTaskIndex(string questId, int questPartIndex, int selectedTaskIndex) { }

	public void SaveSeenQuestDialogue(string questId, int partIndex, int taskIndex, DialogueData dialogueData) { }

	public bool SeeEvent(string eventId) { }

	public void SeenAchievement(int achievementId) { }

	public void SeenCompletedMode(string map, string difficulty, string mode, bool isCoopMode) { }

	public void SeenExtraSettingsMenu() { }

	public void SeenHeroUnlocked(string heroId) { }

	public void SeenHeroUnlockedNotification() { }

	public void SeenModeComplete(string map, string difficulty, string mode, bool isCoopMode) { }

	public void SeenModeUnlock(string map, string difficulty, string mode, bool isCoopMode) { }

	public void SeenNewHeroNotification(string heroId) { }

	public void SeenNewMap(string map) { }

	public void SeenNewMapDifficulty(string map) { }

	public void SeenProfileStats() { }

	public void SeenRound(int round) { }

	public void SeenTowerSkin(string skinId) { }

	[CompilerGenerated]
	private void set_IsFlagged(bool value) { }

	[CompilerGenerated]
	private void set_IsPendingSave(bool value) { }

	[CompilerGenerated]
	private void set_IsPendingSync(bool value) { }

	[CompilerGenerated]
	private void set_LastSyncTime(DateTime value) { }

	[CompilerGenerated]
	public void set_RacePassCount(int value) { }

	[CompilerGenerated]
	public void set_RacePassSyncTask(Task value) { }

	[CompilerGenerated]
	public void set_TeamTrophyBalance(int value) { }

	public void SetAchievementClaimed(int achievementId) { }

	public void SetAchievementPostedToGooglePlay(int achievementId) { }

	public void SetAchievementPostedToXBoxLive(int achievementId) { }

	public void SetAchievementProgress(int achievementId, float achievementProgress) { }

	public void SetBossChallengeRecord(BossType bossType, string mapID, bool isElite, BossScoreComponents score, bool isBattleMode, int playerCount) { }

	public void SetCompleteQuestEvent(string questId, int questPartIndex, int questTaskIndex) { }

	public void SetCompleteQuestPartEvent(string questId, int questPartIndex) { }

	private void SetCurrentBossTierRewards(BossEvent bossEvent, BossDataModel bossData) { }

	[AsyncStateMachine(typeof(<SetCurrentQuestRewards>d__286))]
	private Task SetCurrentQuestRewards(QuestEvent questEvent) { }

	public void SetLegendBadges(string legendKey, bool isCompleted, int amount) { }

	public void SetOnlineProfile(OnlineProfileModel onlineProfileModel) { }

	public void SetQuestSaveData(QuestSaveData questSaveData) { }

	public void SetRank(int value) { }

	public void SetSelectedTowerSkin(string towerBaseId, string selectedTowerSkin) { }

	public void SetTeamTrophyBalance(int balance) { }

	public void SpendMonkeyMoney(int amount, string spentOn) { }

	[AsyncStateMachine(typeof(<SpendTrophies>d__78))]
	public Task SpendTrophies(int amount, string itemId, string itemName) { }

	[AsyncStateMachine(typeof(<SPU>d__70))]
	public void SPU(PUS puStatus) { }

	public void SubmittedBossScore(string eventId, int bossTier, int gameId) { }

	public void Sync() { }

	[AsyncStateMachine(typeof(<SyncNow>d__49))]
	public Task SyncNow() { }

	private Task SyncOnlineProfile() { }

	[AsyncStateMachine(typeof(<SyncTeamTrophyBalance>d__86))]
	public Task SyncTeamTrophyBalance(bool forceRefresh) { }

	[AsyncStateMachine(typeof(<SyncTrophyBalance>d__75))]
	public Task SyncTrophyBalance() { }

	[AsyncStateMachine(typeof(<SyncTrophyBalanceNotSynchronised>d__76))]
	private Task SyncTrophyBalanceNotSynchronised(bool forceRefresh) { }

	public bool TryGetBossChallengeRecord(BossType bossType, string mapID, bool isElite, int playerCount, out BossScoreComponents recordSave) { }

	public bool TryGetBossEventData(string eventId, out BossEventData eventData) { }

	public bool TryGetBossRushEventData(string eventId, out BossRushSaveData eventData) { }

	public bool TryGetCTEventData(string eventId, out CTEventData eventData) { }

	[AsyncStateMachine(typeof(<TryGetLinkFlagStatus>d__211))]
	public Task<Boolean> TryGetLinkFlagStatus() { }

	public bool TryGetQuestEventData(string eventId, out QuestEventData eventData) { }

	private bool TryGetQuestPartSaveData(QuestSaveData questSaveData, int partIndex, out QuestPartSaveData questPartSaveData) { }

	private bool TryGetQuestTaskSaveData(QuestSaveData questSaveData, int partIndex, int taskIndex, out QuestTaskSaveData questTaskSaveData) { }

	public bool TrySpendMonkeyMoney(int amount, string spentOn) { }

	public bool UnlockAllMapsForMapDifficulty(MapDifficulty mapDifficulty, MapSet mapSet) { }

	public void UnlockHero(string towerId) { }

	public void UnlockHeroSkin(string towerId, string heroSkin) { }

	public void UnlockMap(string map) { }

	public void UnlockTower(string towerId) { }

	public void UpdateGoldenBloonMaps() { }

	public void UpdateMonkeyTeamsMaps() { }

	public bool ViewAndSetCurrentBossEvent(BossEvent bossEvent, BossDataModel bossData) { }

	[AsyncStateMachine(typeof(<ViewAndSetCurrentBossRushEvent>d__273))]
	public Task<ValueTuple`2<Boolean, Boolean>> ViewAndSetCurrentBossRushEvent(BossRushEvent bossRushEvent) { }

	[AsyncStateMachine(typeof(<ViewAndSetCurrentCTEvent>d__261))]
	public Task<ValueTuple`2<Boolean, Boolean>> ViewAndSetCurrentCTEvent(CtEvent ctEvent) { }

	[AsyncStateMachine(typeof(<ViewAndSetCurrentQuestEvent>d__283))]
	public Task<Boolean> ViewAndSetCurrentQuestEvent(QuestEvent questEvent) { }

	public void WinCTTile(int tileID, int teamTrophiesEarnt) { }

}

