namespace Assets.Scripts.Unity.UI_New.SweepStakes;

public class SweepstakesReferralCodePopup : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CloseAsync>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesReferralCodePopup <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SubmitCodeAsync>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesReferralCodePopup <>4__this; //Field offset: 0x28
		private string <referralCode>5__2; //Field offset: 0x30
		private TaskAwaiter<SeeShareCodeResult> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateReferralCode>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SeeShareCodeResult> <>t__builder; //Field offset: 0x8
		public SweepstakesReferralCodePopup <>4__this; //Field offset: 0x20
		public string referralCode; //Field offset: 0x28
		private TaskAwaiter<SweepstakesTicketClaimResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	private struct SeeShareCodeResult
	{
		[CompilerGenerated]
		private readonly string <ErrorLocKey>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <EarnedTickets>k__BackingField; //Field offset: 0x8

		public int EarnedTickets
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public string ErrorLocKey
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public bool IsSuccess
		{
			 get { } //Length: 10
		}

		private SeeShareCodeResult(string errorLocKey, int earnedTickets) { }

		public static SeeShareCodeResult FromError(string errorLocKey) { }

		[CompilerGenerated]
		public int get_EarnedTickets() { }

		[CompilerGenerated]
		public string get_ErrorLocKey() { }

		public bool get_IsSuccess() { }

		public static SeeShareCodeResult Successful(int earnedTickets) { }

	}

	private static readonly Regex inputValidation; //Field offset: 0x0
	[SerializeField]
	private Button submitButton; //Field offset: 0x20
	[SerializeField]
	private Button clearButton; //Field offset: 0x28
	[SerializeField]
	private Button closeButton; //Field offset: 0x30
	[SerializeField]
	private Lightbox background; //Field offset: 0x38
	[SerializeField]
	private TMP_InputField inputField; //Field offset: 0x40
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x48
	[SerializeField]
	private Image tickImage; //Field offset: 0x50
	[SerializeField]
	private Image errorImage; //Field offset: 0x58
	[SerializeField]
	private Animator popupAnimator; //Field offset: 0x60
	[SerializeField]
	private int closeAnimDelayMs; //Field offset: 0x68
	private bool isOpen; //Field offset: 0x6C
	private SweepstakesEvent sweepstakesEvent; //Field offset: 0x70
	private Action<SweepstakesStatusResponse> OnStatusUpdated; //Field offset: 0x78
	private Func<SweepstakesStatusResponse> GetStatus; //Field offset: 0x80
	private readonly string sweepstakesUrl; //Field offset: 0x88

	private static SweepstakesReferralCodePopup() { }

	public SweepstakesReferralCodePopup() { }

	private void Awake() { }

	private void ClearClicked() { }

	[AsyncStateMachine(typeof(<CloseAsync>d__25))]
	public void CloseAsync() { }

	private void CodeChanged(string value) { }

	private string GetClipboardCode() { }

	public void Initialize(SweepstakesEvent sweepstakesEvent, Action<SweepstakesStatusResponse> onStatusUpdated, Func<SweepstakesStatusResponse> getStatus) { }

	private bool IsValidCode(string code) { }

	public void Open(bool canAutoSelect) { }

	public void OpenWithReferralCode(string referralCode) { }

	private void SetInteractables(bool isInteractable) { }

	[AsyncStateMachine(typeof(<SubmitCodeAsync>d__22))]
	private void SubmitCodeAsync() { }

	private void Update() { }

	private static string ValidateInput(string input) { }

	[AsyncStateMachine(typeof(<ValidateReferralCode>d__26))]
	private Task<SeeShareCodeResult> ValidateReferralCode(string referralCode) { }

}

