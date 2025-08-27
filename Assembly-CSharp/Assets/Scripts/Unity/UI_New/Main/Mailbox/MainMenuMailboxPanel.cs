namespace Assets.Scripts.Unity.UI_New.Main.Mailbox;

public class MainMenuMailboxPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public HashSet<String> seenMessageIds; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <CheckForNewMailAndPip>b__0(KeyValuePair<String, SweepstakesWinnerMessage> x) { }

	}

	[CompilerGenerated]
	private struct <CheckForNewMailAndPip>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuMailboxPanel <>4__this; //Field offset: 0x20
		private <>c__DisplayClass6_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MailboxClickedAsync>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuMailboxPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button mailboxButton; //Field offset: 0x20
	[SerializeField]
	private GameObject newMailPip; //Field offset: 0x28
	[SerializeField]
	private GameObject newMailGlow; //Field offset: 0x30

	public MainMenuMailboxPanel() { }

	public void Awake() { }

	[AsyncStateMachine(typeof(<CheckForNewMailAndPip>d__6))]
	private Task CheckForNewMailAndPip() { }

	[AsyncStateMachine(typeof(<MailboxClickedAsync>d__7))]
	private void MailboxClickedAsync() { }

	private void OnDestroy() { }

	public void Refresh() { }

}

