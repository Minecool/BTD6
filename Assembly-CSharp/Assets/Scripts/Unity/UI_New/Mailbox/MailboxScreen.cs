namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class MailboxScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, SweepstakesWinnerMessage>, DateTime> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTime <ShowMessages>b__13_0(KeyValuePair<String, SweepstakesWinnerMessage> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public HashSet<String> seenMessageIds; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_1
	{
		public string messageId; //Field offset: 0x10
		public <>c__DisplayClass13_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass13_1() { }

		internal void <ShowMessages>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public string messageId; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <DeleteMail>b__0(MailboxLetter x) { }

	}

	[CompilerGenerated]
	private struct <DeleteMail>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string messageId; //Field offset: 0x28
		public MailboxScreen <>4__this; //Field offset: 0x30
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMessages>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private <>c__DisplayClass13_0 <>8__1; //Field offset: 0x20
		public MailboxScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryShowMessages>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI mailboxTitleTxt; //Field offset: 0x48
	[SerializeField]
	private GameObject noMailItemObj; //Field offset: 0x50
	[SerializeField]
	private GameObject inboxLoadingObj; //Field offset: 0x58
	[SerializeField]
	private GameObject failedLoadingObj; //Field offset: 0x60
	[SerializeField]
	private GameObject mailLetterPopupObj; //Field offset: 0x68
	[SerializeField]
	private GameObject sweepStakesWinnerPopupObj; //Field offset: 0x70
	[SerializeField]
	private GameObject letterContainerObj; //Field offset: 0x78
	[SerializeField]
	private MailboxLetter letterTemplate; //Field offset: 0x80
	[SerializeField]
	private SweepstakesWinnerLetter sweepStakesWinnerPopup; //Field offset: 0x88
	private List<MailboxLetter> messages; //Field offset: 0x90

	public MailboxScreen() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<DeleteMail>d__15))]
	public void DeleteMail(string messageId) { }

	public virtual void Open(object data) { }

	public void OpenSweepStakesWinnerPopup(SweepstakesWinnerMessage sweepstakesWinnerMessage) { }

	[AsyncStateMachine(typeof(<ShowMessages>d__13))]
	private Task ShowMessages() { }

	[AsyncStateMachine(typeof(<TryShowMessages>d__12))]
	private Task TryShowMessages() { }

}

