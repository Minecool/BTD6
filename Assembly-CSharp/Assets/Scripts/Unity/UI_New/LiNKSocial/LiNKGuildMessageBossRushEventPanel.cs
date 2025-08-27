namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LiNKGuildMessageBossRushEventPanel : LiNKGuildMessagePanel
{
	[CompilerGenerated]
	private struct <Bind>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageBossRushEventPanel <>4__this; //Field offset: 0x20
		public GuildMessage messageModel; //Field offset: 0x28
		public TeamsScreen screen; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BindData>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageBossRushEventPanel <>4__this; //Field offset: 0x20
		private BossData <bossData>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private BossRushEvent <bossEvent>5__3; //Field offset: 0x38
		private TaskAwaiter<BossRushSettings> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image bossImage; //Field offset: 0x58
	protected GuildMessageBossRushEvent eventData; //Field offset: 0x60

	public LiNKGuildMessageBossRushEventPanel() { }

	[AsyncStateMachine(typeof(<Bind>d__2))]
	public virtual Task Bind(TeamsScreen screen, GuildMessage messageModel) { }

	[AsyncStateMachine(typeof(<BindData>d__3))]
	private Task BindData() { }

	private static string GetMessageLocKey(bool isIncrement, bool isKillingBlow, bool isFinalStage) { }

}

