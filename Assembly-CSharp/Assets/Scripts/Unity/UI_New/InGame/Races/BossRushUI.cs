namespace Assets.Scripts.Unity.UI_New.InGame.Races;

public class BossRushUI : DynamicUiObject
{
	[CompilerGenerated]
	private struct <>c__DisplayClass11_0
	{
		public BossRushUI <>4__this; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <CheckAndNotifyNewScores>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushUI <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private bool <isCurrentBossKilled>5__2; //Field offset: 0x50
		private int <newScores>5__3; //Field offset: 0x54
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"isCurrentBossKilled", "newScores"}])]
		private TaskAwaiter<ValueTuple`2<Boolean, Int32>> <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBossRushInfoFromPubSub>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"isCurrentBossKilled", "newScores"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<Boolean, Int32>> <>t__builder; //Field offset: 0x8
		public BossRushUI <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter<PubSubChannelModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI messageTxt; //Field offset: 0x20
	[SerializeField]
	private Animator animator; //Field offset: 0x28
	private CancellationTokenSource cancellationTokenSource; //Field offset: 0x30
	private BossRushGameData bossRushGameData; //Field offset: 0x38
	private long latestPubSubMessageSeenTimestamp; //Field offset: 0x40

	private static TimeSpan CheckInterval
	{
		private get { } //Length: 287
	}

	public BossRushUI() { }

	[CompilerGenerated]
	private bool <CheckAndNotifyNewScores>g__isCancelled|11_0(ref <>c__DisplayClass11_0 unnamed_param_0) { }

	[AsyncStateMachine(typeof(<CheckAndNotifyNewScores>d__11))]
	private Task CheckAndNotifyNewScores(CancellationToken cancellationToken) { }

	private static TimeSpan get_CheckInterval() { }

	[AsyncStateMachine(typeof(<GetBossRushInfoFromPubSub>d__12))]
	private Task<ValueTuple`2<Boolean, Int32>> GetBossRushInfoFromPubSub(CancellationToken cancellationToken) { }

	public void Initialize(BossRushGameData bossRushGameData) { }

	private void OnDestroy() { }

	public virtual void OnGameEnd() { }

	public virtual void OnGameStart() { }

}

