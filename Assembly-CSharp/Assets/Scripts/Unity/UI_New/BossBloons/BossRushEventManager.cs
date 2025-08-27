namespace Assets.Scripts.Unity.UI_New.BossBloons;

public static class BossRushEventManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public BossRushEvent bossRushPendingRewards; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <ShowEndedBossRushEventRewards>b__0(BossRushSaveData x) { }

	}

	[CompilerGenerated]
	private struct <ShowEndedBossRushEventRewards>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public BossRushEvent bossRushPendingRewards; //Field offset: 0x20
		public GameObject parentGameObject; //Field offset: 0x28
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x30
		private BossRushSaveData <bossRushSaveData>5__2; //Field offset: 0x38
		private int <highestDefeatedBoss>5__3; //Field offset: 0x40
		private TaskAwaiter<BossRushSettings> <>u__1; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x50
		private TaskAwaiter<BossRushCompletedTierResponse> <>u__3; //Field offset: 0x58
		private YieldAwaiter <>u__4; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryShowEndedBossRushEventsRewards>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public GameObject parentGameObject; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<ShowEndedBossRushEventRewards>d__1))]
	private static Task<Boolean> ShowEndedBossRushEventRewards(GameObject parentGameObject, BossRushEvent bossRushPendingRewards) { }

	[AsyncStateMachine(typeof(<TryShowEndedBossRushEventsRewards>d__0))]
	public static Task<Boolean> TryShowEndedBossRushEventsRewards(GameObject parentGameObject) { }

}

