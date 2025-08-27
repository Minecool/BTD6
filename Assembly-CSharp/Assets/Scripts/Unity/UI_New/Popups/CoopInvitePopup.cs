namespace Assets.Scripts.Unity.UI_New.Popups;

public class CoopInvitePopup : MonoBehaviour
{
	[CompilerGenerated]
	private struct <AutoDismissAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x28
		public CoopInvitePopup <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetButtonsInteractableAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopInvitePopup <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly TaskCompletionSource<Boolean> isInvitationAccepted; //Field offset: 0x20
	private readonly CancellationTokenSource cts; //Field offset: 0x28
	[SerializeField]
	private Animator animator; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI inviteMessage; //Field offset: 0x38
	[SerializeField]
	private Button acceptBtn; //Field offset: 0x40
	[SerializeField]
	private Button dismissBtn; //Field offset: 0x48
	[SerializeField]
	private float buttonDelay; //Field offset: 0x50
	private bool isOpening; //Field offset: 0x54
	private bool isClosing; //Field offset: 0x55
	private float closingTimer; //Field offset: 0x58

	public CoopInvitePopup() { }

	private void AcceptInvite() { }

	[AsyncStateMachine(typeof(<AutoDismissAsync>d__14))]
	private void AutoDismissAsync(CancellationToken cancellationToken) { }

	public void Awake() { }

	public void ClosePopup() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<SetButtonsInteractableAsync>d__15))]
	private void SetButtonsInteractableAsync(CancellationToken cancellationToken) { }

	public Task<Boolean> ShowAndWaitForResponse(string playerName) { }

	public void Update() { }

}

