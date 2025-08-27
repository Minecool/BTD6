namespace Assets.Scripts.Unity.UI_New.Nexus;

public class NexusCodeInput : Popup
{
	[CompilerGenerated]
	private struct <SubmitClicked>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public NexusCodeInput <>4__this; //Field offset: 0x28
		private string <creatorCode>5__2; //Field offset: 0x30
		private string <playerId>5__3; //Field offset: 0x38
		private TaskAwaiter<TaskResult> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateNexusCode>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TaskResult> <>t__builder; //Field offset: 0x8
		public string nexusCode; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	private struct TaskResult
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

		private TaskResult(string errorLocKey) { }

		public static TaskResult FromError(string errorLocKey) { }

		[CompilerGenerated]
		public string get_ErrorLocKey() { }

		public bool get_IsSuccess() { }

		public static TaskResult Successful() { }

	}

	private static readonly Regex inputValidation; //Field offset: 0x0
	[SerializeField]
	private Button submitButton; //Field offset: 0x128
	[SerializeField]
	private Button clearButton; //Field offset: 0x130
	[SerializeField]
	private Button closeButton; //Field offset: 0x138
	[SerializeField]
	private TMP_InputField inputField; //Field offset: 0x140
	[SerializeField]
	private NK_TextMeshProUGUI errorMessage; //Field offset: 0x148
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x150
	[SerializeField]
	private Image tickImage; //Field offset: 0x158
	[SerializeField]
	private Image errorImage; //Field offset: 0x160

	private static NexusCodeInput() { }

	public NexusCodeInput() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	private void Awake() { }

	private void ClearClicked() { }

	private void CodeChanged(string value) { }

	private static string GetErrorLocKey(string linkError) { }

	private void SetInteractables(bool isInteractable) { }

	private void Start() { }

	[AsyncStateMachine(typeof(<SubmitClicked>d__14))]
	private void SubmitClicked() { }

	private void Update() { }

	private static string ValidateInput(string input) { }

	[AsyncStateMachine(typeof(<ValidateNexusCode>d__16))]
	private static Task<TaskResult> ValidateNexusCode(string nexusCode) { }

}

