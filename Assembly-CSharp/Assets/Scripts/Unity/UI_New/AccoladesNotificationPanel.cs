namespace Assets.Scripts.Unity.UI_New;

public class AccoladesNotificationPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<AccoladeTransaction, Int64> <>9__20_0; //Field offset: 0x8
		public static Func<AccoladeTransaction, String> <>9__20_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal long <LoadAccoladeTransactionPanels>b__20_0(AccoladeTransaction x) { }

		internal string <LoadAccoladeTransactionPanels>b__20_1(AccoladeTransaction x) { }

	}

	[CompilerGenerated]
	private struct <Close>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesNotificationPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesNotificationPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAccoladeTransactionPanels>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesNotificationPanel <>4__this; //Field offset: 0x20
		private OnlineProfileModel <onlineData>5__2; //Field offset: 0x28
		private AccoladeTransaction[] <accoladeTransactions>5__3; //Field offset: 0x30
		private long <latestSeenAccoladeTransactionId>5__4; //Field offset: 0x38
		private Task<Dictionary`2<String, String>> <userNamesTask>5__5; //Field offset: 0x40
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x48
		private TaskAwaiter<AccoladeTransactionRequestResponse`1<AccoladeTransaction>> <>u__2; //Field offset: 0x50
		private TaskAwaiter<AccoladeTransaction[]> <>u__3; //Field offset: 0x58
		private IEnumerator<AccoladeTransaction> <>7__wrap5; //Field offset: 0x60
		private AccoladeNotification <newPanel>5__7; //Field offset: 0x68
		private TaskAwaiter <>u__4; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadNexusStatusAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesNotificationPanel <>4__this; //Field offset: 0x28
		public bool forceRefresh; //Field offset: 0x30
		private TaskAwaiter<NexusStatusModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ToggleNexusPopupAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladesNotificationPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForCloseAnimation>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private int <frameCount>5__2; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x24

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class AccoladesSeen : MulticastDelegate
	{

		public AccoladesSeen(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"playerId", "nexusStatus"}])]
	private static ValueTuple<String, NexusStatusModel> myNexusStatus; //Field offset: 0x0
	[SerializeField]
	private AccoladeNotification notifPrefab; //Field offset: 0x20
	[SerializeField]
	private Transform notifsContainer; //Field offset: 0x28
	[SerializeField]
	private Toggle hideNotifToggle; //Field offset: 0x30
	[SerializeField]
	private Button closeButton; //Field offset: 0x38
	[SerializeField]
	private Lightbox closeBackground; //Field offset: 0x40
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x48
	[SerializeField]
	private GameObject nexusSignedIn; //Field offset: 0x50
	[SerializeField]
	private GameObject nexusStatusLoading; //Field offset: 0x58
	[SerializeField]
	private GameObject nexusSignInContainer; //Field offset: 0x60
	[SerializeField]
	private Button nexusSignInButton; //Field offset: 0x68
	[SerializeField]
	private GameObject accoladeTransactionPanel; //Field offset: 0x70
	[SerializeField]
	private NexusPlayerCreatorPopup nexusPlayerCreatorPopup; //Field offset: 0x78
	[SerializeField]
	private Animator popupAnimator; //Field offset: 0x80
	private readonly List<AccoladeNotification> activeNotifPanels; //Field offset: 0x88
	private bool hasShownNetworkPopup; //Field offset: 0x90

	public AccoladesNotificationPanel() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<Close>d__22))]
	public void Close() { }

	[AsyncStateMachine(typeof(<InitializeAsync>d__17))]
	public void InitializeAsync() { }

	[AsyncStateMachine(typeof(<LoadAccoladeTransactionPanels>d__20))]
	private Task LoadAccoladeTransactionPanels() { }

	[AsyncStateMachine(typeof(<LoadNexusStatusAsync>d__19))]
	public void LoadNexusStatusAsync(bool forceRefresh = false) { }

	private void OnNotifsToggled(bool value) { }

	[AsyncStateMachine(typeof(<ToggleNexusPopupAsync>d__23))]
	public void ToggleNexusPopupAsync() { }

	[AsyncStateMachine(typeof(<WaitForCloseAnimation>d__24))]
	private static Task WaitForCloseAnimation() { }

}

