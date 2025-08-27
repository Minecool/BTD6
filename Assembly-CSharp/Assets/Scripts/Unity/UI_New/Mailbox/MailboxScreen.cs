namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class MailboxScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MailboxLetter, Boolean> <>9__45_0; //Field offset: 0x8
		public static Func<MailboxLetter, DateTime> <>9__45_1; //Field offset: 0x10
		public static Func<String> <>9__48_0; //Field offset: 0x18
		public static Func<String> <>9__48_1; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, SweepstakesWinnerMessage>, DateTime> <>9__49_0; //Field offset: 0x28
		public static Func<BaseLoot, Boolean> <>9__52_0; //Field offset: 0x30
		public static Func<KeyValuePair`2<String, String>, Boolean> <>9__57_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <GetLocalizedOrDefault>b__57_0(KeyValuePair<String, String> x) { }

		internal string <ShowMessageEvents>b__48_0() { }

		internal string <ShowMessageEvents>b__48_1() { }

		internal bool <ShowOpenedGifts>b__52_0(BaseLoot x) { }

		internal DateTime <ShowSweepstakesMessages>b__49_0(KeyValuePair<String, SweepstakesWinnerMessage> x) { }

		internal bool <SortMessages>b__45_0(MailboxLetter x) { }

		internal DateTime <SortMessages>b__45_1(MailboxLetter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public int majorVersion; //Field offset: 0x10
		public string messageId; //Field offset: 0x18
		public MailboxLetter mailboxLetter; //Field offset: 0x20
		public MailboxScreen <>4__this; //Field offset: 0x28
		public Action <>9__2; //Field offset: 0x30

		public <>c__DisplayClass47_0() { }

		internal void <ShowPatchNotesMessages>b__0() { }

		internal void <ShowPatchNotesMessages>b__1() { }

		internal void <ShowPatchNotesMessages>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public MessageEvent messageEvent; //Field offset: 0x10
		public bool isNewsLetter; //Field offset: 0x18
		public string localisedTitle; //Field offset: 0x20
		public string localisedMessage; //Field offset: 0x28
		public MailboxLetter mailboxLetter; //Field offset: 0x30
		public string messageId; //Field offset: 0x38
		public MailboxScreen <>4__this; //Field offset: 0x40
		public Action <>9__4; //Field offset: 0x48

		public <>c__DisplayClass48_0() { }

		internal void <ShowMessageEvents>b__2() { }

		internal void <ShowMessageEvents>b__3() { }

		internal void <ShowMessageEvents>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public HashSet<String> seenMessageIds; //Field offset: 0x10
		public MailboxScreen <>4__this; //Field offset: 0x18
		public OnlineProfileModel onlineData; //Field offset: 0x20

		public <>c__DisplayClass49_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_1
	{
		public SweepstakesWinnerMessage sweepstakesWinnerMessage; //Field offset: 0x10
		public string messageId; //Field offset: 0x18
		public <>c__DisplayClass49_0 CS$<>8__locals1; //Field offset: 0x20
		public Action <>9__3; //Field offset: 0x28

		public <>c__DisplayClass49_1() { }

		internal void <ShowSweepstakesMessages>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_2
	{
		public MailboxLetter mailboxLetter; //Field offset: 0x10
		public <>c__DisplayClass49_1 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass49_2() { }

		internal void <ShowSweepstakesMessages>b__1() { }

		internal void <ShowSweepstakesMessages>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public MailboxScreen <>4__this; //Field offset: 0x10
		public MailboxLetter mailboxLetter; //Field offset: 0x18
		public Action onDeleteConfirmed; //Field offset: 0x20
		public MessageType messageType; //Field offset: 0x28

		public <>c__DisplayClass50_0() { }

		internal bool <DeleteMessage>b__1(string x) { }

		internal void <DeleteMessage>g__deleteMessage|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public string giftId; //Field offset: 0x10
		public MailboxScreen <>4__this; //Field offset: 0x18
		public Action <>9__3; //Field offset: 0x20

		public <>c__DisplayClass52_0() { }

		internal void <ShowOpenedGifts>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_1
	{
		public string localisedMessage; //Field offset: 0x10
		public LootSet claimedLootSet; //Field offset: 0x18
		public GiftLetter mailboxLetter; //Field offset: 0x20
		public <>c__DisplayClass52_0 CS$<>8__locals1; //Field offset: 0x28

		public <>c__DisplayClass52_1() { }

		internal void <ShowOpenedGifts>b__1() { }

		internal void <ShowOpenedGifts>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public ServerGift pendingGift; //Field offset: 0x10
		public GiftMessageModel gift; //Field offset: 0x18
		public MailboxScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass53_0() { }

		internal void <ShowGifts>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public GiftMessageModel gift; //Field offset: 0x10
		public MailboxScreen <>4__this; //Field offset: 0x18
		public DateTime receivedTime; //Field offset: 0x20

		public <>c__DisplayClass54_0() { }

		internal void <OpenGift>b__1() { }

		internal void <OpenGift>b__2() { }

		internal void <OpenGift>b__3() { }

		internal void <OpenGift>g__RecieveGift|0(GiftMessageModel gift) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public HashSet<String> receivedGiftEventIds; //Field offset: 0x10

		public <>c__DisplayClass56_0() { }

		internal bool <ShowGiftEvents>b__0(GiftEvent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_1
	{
		public GiftEvent pendingGiftEvent; //Field offset: 0x10

		public <>c__DisplayClass56_1() { }

		internal void <ShowGiftEvents>b__2() { }

		internal string <ShowGiftEvents>g__getDefaultMessage|1() { }

	}

	[CompilerGenerated]
	private struct <ClaimGiftClickedAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetLoadMessageTasks>d__46 : IEnumerable<Task>, IEnumerable, IEnumerator<Task>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Task <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public MailboxScreen <>4__this; //Field offset: 0x28
		private CancellationToken cancellationToken; //Field offset: 0x30
		public CancellationToken <>3__cancellationToken; //Field offset: 0x38

		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.Current
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
		public <GetLoadMessageTasks>d__46(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Task> System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>.GetEnumerator() { }

		[DebuggerHidden]
		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.get_Current() { }

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
	private struct <LoadMessages>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMessages>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnMessageLoadedDelay>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowGiftEvents>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private IEnumerator<GiftEvent> <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowGifts>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass53_0 <>8__1; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private Dictionary<String, ServerGift> <pendingGifts>5__2; //Field offset: 0x38
		private HashSet<String> <idsToRemove>5__3; //Field offset: 0x40
		private Enumerator<String, ServerGift> <>7__wrap3; //Field offset: 0x48
		private string <giftId>5__5; //Field offset: 0x70
		private TaskAwaiter<GiftMessageModel> <>u__1; //Field offset: 0x78
		private TaskAwaiter <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMessageEvents>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private <>c__DisplayClass48_0 <>8__1; //Field offset: 0x30
		private IEnumerator<MessageEvent> <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowOpenedGifts>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private Enumerator<String, ClaimedGiftModel> <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowPatchNotesMessages>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private <>c__DisplayClass47_0 <>8__1; //Field offset: 0x30
		private Enumerator<Int32, DateTime> <>7__wrap1; //Field offset: 0x38
		private DateTime <releaseDate>5__3; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowSweepstakesMessages>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MailboxScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass49_0 <>8__1; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38
		private IEnumerator<KeyValuePair`2<String, SweepstakesWinnerMessage>> <>7__wrap1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class DeletionEnabledToggled : MulticastDelegate
	{

		public DeletionEnabledToggled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isEnabled, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isEnabled) { }

	}

	private enum MessageType
	{
		Unknown = 0,
		Sweepstakes = 1,
		PathNotes = 2,
		GlobalMessage = 3,
		Newsletter = 4,
		Gift = 5,
	}

	private const int kMaxMessagesLoadedPer2Frames = 8; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsPendingSaveAndSync>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsDeletionEnabled>k__BackingField; //Field offset: 0x1
	[SerializeField]
	private GameObject noMailItemObj; //Field offset: 0x48
	[SerializeField]
	private GameObject inboxLoadingObj; //Field offset: 0x50
	[SerializeField]
	private GameObject failedLoadingObj; //Field offset: 0x58
	[SerializeField]
	private Transform letterContainer; //Field offset: 0x60
	[SerializeField]
	private GameObject letterTemplate_generic; //Field offset: 0x68
	[SerializeField]
	private GameObject letterTemplate_sweepstakes; //Field offset: 0x70
	[SerializeField]
	private GameObject letterTemplate_gift; //Field offset: 0x78
	[SerializeField]
	private GameObject letterTemplate_nk; //Field offset: 0x80
	[SerializeField]
	private GameObject letterTemplate_patchNotes; //Field offset: 0x88
	[SerializeField]
	private GameObject letterTemplate_event; //Field offset: 0x90
	[SerializeField]
	private GameObject giftCodeRedemptionContainer; //Field offset: 0x98
	[SerializeField]
	private Button giftCodeRedemptionBtn; //Field offset: 0xA0
	[SerializeField]
	private AudioClip clickSound; //Field offset: 0xA8
	[SerializeField]
	private Toggle deleteToggle; //Field offset: 0xB0
	private bool isPendingSorting; //Field offset: 0xB8
	private int loadedMessagesSinceLastFrame; //Field offset: 0xBC
	[CompilerGenerated]
	private readonly List<MailboxLetter> <MailboxLetters>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private CancellationTokenSource <MessageLoadCanceller>k__BackingField; //Field offset: 0xC8

	public private static bool IsDeletionEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 55
		[CompilerGenerated]
		private set { } //Length: 60
	}

	private static bool IsPendingSaveAndSync
	{
		[CompilerGenerated]
		private get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 59
	}

	private List<MailboxLetter> MailboxLetters
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	private CancellationTokenSource MessageLoadCanceller
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public MailboxScreen() { }

	[CompilerGenerated]
	private void <Awake>b__33_0(bool isOn) { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<ClaimGiftClickedAsync>d__38))]
	private void ClaimGiftClickedAsync() { }

	private void ClearLetters() { }

	private void DeleteMessage(MailboxLetter mailboxLetter, Action onDeleteConfirmed, MessageType messageType) { }

	[CompilerGenerated]
	public static bool get_IsDeletionEnabled() { }

	[CompilerGenerated]
	private static bool get_IsPendingSaveAndSync() { }

	[CompilerGenerated]
	private List<MailboxLetter> get_MailboxLetters() { }

	[CompilerGenerated]
	private CancellationTokenSource get_MessageLoadCanceller() { }

	[IteratorStateMachine(typeof(<GetLoadMessageTasks>d__46))]
	private IEnumerable<Task> GetLoadMessageTasks(CancellationToken cancellationToken) { }

	public static string GetLocalizedOrDefault(Dictionary<String, String> localisedValues, Func<String> getDefaultValue = null) { }

	[AsyncStateMachine(typeof(<LoadMessages>d__42))]
	private Task LoadMessages(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<LoadMessages>d__40))]
	private Task LoadMessages() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<OnMessageLoadedDelay>d__55))]
	private Task OnMessageLoadedDelay(CancellationToken cancellationToken) { }

	private void OnPubSubMessageReceived() { }

	public virtual void Open(object data) { }

	private void OpenGift(GiftMessageModel gift, DateTime receivedTime) { }

	private void PlayClickSound() { }

	public virtual void ReClose() { }

	private void RemoveLetter(MailboxLetter mailboxLetter) { }

	[CompilerGenerated]
	private static void set_IsDeletionEnabled(bool value) { }

	[CompilerGenerated]
	private static void set_IsPendingSaveAndSync(bool value) { }

	[CompilerGenerated]
	private void set_MessageLoadCanceller(CancellationTokenSource value) { }

	[AsyncStateMachine(typeof(<ShowGiftEvents>d__56))]
	private Task ShowGiftEvents(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ShowGifts>d__53))]
	private Task ShowGifts(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ShowMessageEvents>d__48))]
	private Task ShowMessageEvents(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ShowOpenedGifts>d__52))]
	private Task ShowOpenedGifts(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ShowPatchNotesMessages>d__47))]
	private Task ShowPatchNotesMessages(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<ShowSweepstakesMessages>d__49))]
	private Task ShowSweepstakesMessages(CancellationToken cancellationToken) { }

	private void SortMessages() { }

	private void SortMessagesOnUpdate() { }

	private void Update() { }

}

