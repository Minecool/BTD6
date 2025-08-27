namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LiNKGuildMessageEventPanel : LiNKGuildMessagePanel
{
	[CompilerGenerated]
	private struct <Bind>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageEventPanel <>4__this; //Field offset: 0x20
		public GuildMessage messageModel; //Field offset: 0x28
		public TeamsScreen screen; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BindData>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKGuildMessageEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<String> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject joinPanel; //Field offset: 0x58
	public GameObject leavePanel; //Field offset: 0x60
	public GameObject createPanel; //Field offset: 0x68
	public GameObject promotePanel; //Field offset: 0x70
	public GameObject demotedPanel; //Field offset: 0x78
	public GameObject ctEventStartedPanel; //Field offset: 0x80
	public GameObject ctEventEndedPanel; //Field offset: 0x88
	public GameObject itemFundedPanel; //Field offset: 0x90
	public GameObject competitiveRequestPanel; //Field offset: 0x98
	public Image flairFundedImage; //Field offset: 0xA0
	protected GuildMessageEvent eventData; //Field offset: 0xA8

	public LiNKGuildMessageEventPanel() { }

	[CompilerGenerated]
	private bool <BindData>b__13_0(TeamsStoreItem x) { }

	[AsyncStateMachine(typeof(<Bind>d__12))]
	public virtual Task Bind(TeamsScreen screen, GuildMessage messageModel) { }

	[AsyncStateMachine(typeof(<BindData>d__13))]
	private Task BindData() { }

	public static bool ShouldShowTeamMessage(GuildsCall messageType) { }

}

