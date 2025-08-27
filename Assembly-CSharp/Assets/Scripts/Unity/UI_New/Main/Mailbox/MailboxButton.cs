namespace Assets.Scripts.Unity.UI_New.Main.Mailbox;

public class MailboxButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public HashSet<String> seenMessageIds; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <HasPendingSweepstakesMessage>b__0(KeyValuePair<String, SweepstakesWinnerMessage> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public HashSet<String> receivedGiftEventIds; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <HasPendingGiftEvent>b__0(GiftEvent x) { }

	}

	[CompilerGenerated]
	private struct <CheckForNewMailAndPip>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxButton <>4__this; //Field offset: 0x20
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckForNewMailAndPip>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxButton <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TimeSpan <frameTime>5__2; //Field offset: 0x30
		private IEnumerator<Func`2<CancellationToken, Task`1<Boolean>>> <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetMessageCheckFunctions>d__18 : IEnumerable<Func`2<CancellationToken, Task`1<Boolean>>>, IEnumerable, IEnumerator<Func`2<CancellationToken, Task`1<Boolean>>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Func<CancellationToken, Task`1<Boolean>> <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20

		private override Func<CancellationToken, Task`1<Boolean>> System.Collections.Generic.IEnumerator<System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Boolean>>>.Current
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
		public <GetMessageCheckFunctions>d__18(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Func`2<CancellationToken, Task`1<Boolean>>> System.Collections.Generic.IEnumerable<System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Boolean>>>.GetEnumerator() { }

		[DebuggerHidden]
		private override Func<CancellationToken, Task`1<Boolean>> System.Collections.Generic.IEnumerator<System.Func<System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Boolean>>>.get_Current() { }

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
	private struct <HasPendingSweepstakesMessage>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		private <>c__DisplayClass19_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenMailboxAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxButton <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static bool <HasPendingMessage>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private Button mailboxButton; //Field offset: 0x20
	[SerializeField]
	private GameObject newMailPip; //Field offset: 0x28
	[SerializeField]
	private GameObject newMailGlow; //Field offset: 0x30
	[CompilerGenerated]
	private CancellationTokenSource <NewMessageCheckCanceller>k__BackingField; //Field offset: 0x38

	private static bool HasPendingMessage
	{
		[CompilerGenerated]
		private get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 59
	}

	private static MailboxSettings MailboxSettings
	{
		private get { } //Length: 150
	}

	private CancellationTokenSource NewMessageCheckCanceller
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public MailboxButton() { }

	public void Awake() { }

	[AsyncStateMachine(typeof(<CheckForNewMailAndPip>d__16))]
	private Task CheckForNewMailAndPip() { }

	[AsyncStateMachine(typeof(<CheckForNewMailAndPip>d__17))]
	private Task CheckForNewMailAndPip(CancellationToken cancellationToken) { }

	[CompilerGenerated]
	private static bool get_HasPendingMessage() { }

	private static MailboxSettings get_MailboxSettings() { }

	[CompilerGenerated]
	private CancellationTokenSource get_NewMessageCheckCanceller() { }

	[IteratorStateMachine(typeof(<GetMessageCheckFunctions>d__18))]
	private static IEnumerable<Func`2<CancellationToken, Task`1<Boolean>>> GetMessageCheckFunctions() { }

	private static Task<Boolean> HasPendingGift(CancellationToken cancellationToken) { }

	private static Task<Boolean> HasPendingGiftEvent(CancellationToken cancellationToken) { }

	private static Task<Boolean> HasPendingMessageEvent(CancellationToken cancellationToken) { }

	private static Task<Boolean> HasPendingPatchNotesMessage(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<HasPendingSweepstakesMessage>d__19))]
	private static Task<Boolean> HasPendingSweepstakesMessage(CancellationToken cancellationToken) { }

	private static bool HasSeenOrDeletedEventId(string eventId) { }

	private void OnDestroy() { }

	public void OnPubSubMessageReceived() { }

	[AsyncStateMachine(typeof(<OpenMailboxAsync>d__25))]
	private void OpenMailboxAsync() { }

	[CompilerGenerated]
	private static void set_HasPendingMessage(bool value) { }

	[CompilerGenerated]
	private void set_NewMessageCheckCanceller(CancellationTokenSource value) { }

}

