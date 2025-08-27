namespace Assets.Scripts.Unity.UI_New;

public class CodeRedemptionPanel : Popup
{
	[CompilerGenerated]
	private struct <AutoSelectAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CodeRedemptionPanel <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ClaimCodeAndGift>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ClaimResult> <>t__builder; //Field offset: 0x8
		public string giftCode; //Field offset: 0x20
		private TaskAwaiter<PubSubMessageModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ClaimCodeAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CodeRedemptionPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<ClaimResult> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	private struct ClaimResult
	{
		[CompilerGenerated]
		private readonly string <ErrorLocKey>k__BackingField; //Field offset: 0x0

		public string ErrorLocKey
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public bool IsSuccess
		{
			 get { } //Length: 10
		}

		private ClaimResult(string errorLocKey) { }

		public static ClaimResult FromError(string errorLocKey) { }

		[CompilerGenerated]
		public string get_ErrorLocKey() { }

		public bool get_IsSuccess() { }

		public static ClaimResult Successful() { }

	}

	private static readonly Regex inputValidation; //Field offset: 0x0
	[SerializeField]
	private Button claimButton; //Field offset: 0x128
	[SerializeField]
	private Button closeButton; //Field offset: 0x130
	[SerializeField]
	private TMP_InputField codeInputField; //Field offset: 0x138
	[SerializeField]
	private NK_TextMeshProUGUI errorMessage; //Field offset: 0x140
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x148
	[SerializeField]
	private Image errorImage; //Field offset: 0x150
	private bool _isClaimInProgress; //Field offset: 0x158

	private bool IsClaimInProgress
	{
		private get { } //Length: 8
		private set { } //Length: 149
	}

	private static CodeRedemptionPanel() { }

	public CodeRedemptionPanel() { }

	[CompilerGenerated]
	private void <Awake>b__10_0() { }

	[AsyncStateMachine(typeof(<AutoSelectAsync>d__11))]
	private void AutoSelectAsync() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<ClaimCodeAndGift>d__15))]
	private static Task<ClaimResult> ClaimCodeAndGift(string giftCode) { }

	[AsyncStateMachine(typeof(<ClaimCodeAsync>d__14))]
	private void ClaimCodeAsync() { }

	private bool get_IsClaimInProgress() { }

	private static string GetErrorLocKey(string linkError) { }

	private void set_IsClaimInProgress(bool value) { }

	private void Update() { }

	private void ValidateInput(string input) { }

}

