namespace Assets.Scripts.Unity.Scenes;

public class InitialLoadingScreen : GenericAnimatedScene, IBundleLoaderProgressReporter
{
	[CompilerGenerated]
	private struct <WaitForDownloadConfirm>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InitialLoadingScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForUpdatePromptClick>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UpdatePromptClick> <>t__builder; //Field offset: 0x8
		public InitialLoadingScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<UpdatePromptClick> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI MainText; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI SubText; //Field offset: 0x30
	[SerializeField]
	private GameObject progressBar; //Field offset: 0x38
	[SerializeField]
	private Image progressImage; //Field offset: 0x40
	[SerializeField]
	private Animator UiAnimator; //Field offset: 0x48
	[SerializeField]
	private GameObject downloadConfirmObj; //Field offset: 0x50
	[SerializeField]
	private Button downloadConfirmBtn; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI downloadDescTxt; //Field offset: 0x60
	[SerializeField]
	private GameObject updatePromptObj; //Field offset: 0x68
	[SerializeField]
	private NK_TextMeshProUGUI updatePromptTxt; //Field offset: 0x70
	[SerializeField]
	private NK_TextMeshProUGUI updateCancelBtnTxt; //Field offset: 0x78
	[SerializeField]
	private Button updatePromptBtn; //Field offset: 0x80
	[SerializeField]
	private Button updateCancelBtn; //Field offset: 0x88
	[SerializeField]
	private NK_TextMeshProUGUI buildInfo; //Field offset: 0x90
	[SerializeField]
	private NK_TextMeshProUGUI playerId; //Field offset: 0x98
	private string subText; //Field offset: 0xA0
	private Animator animator3D; //Field offset: 0xA8
	private TaskCompletionSource<Boolean> downloadClicked; //Field offset: 0xB0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"isInitialized", "forceUpdate"}])]
	private ValueTuple<Boolean, Boolean> updatePromptStatus; //Field offset: 0xB8
	private TaskCompletionSource<UpdatePromptClick> updateClicked; //Field offset: 0xC0

	public InitialLoadingScreen() { }

	[CompilerGenerated]
	private void <InitializeUpdatePrompt>b__32_0() { }

	[CompilerGenerated]
	private void <InitializeUpdatePrompt>b__32_1() { }

	private void Awake() { }

	private void DownloadConfirmClicked() { }

	public void HideUpdatePrompt() { }

	private void InitializeUpdatePrompt(bool forceUpdate) { }

	private void OnVisionOSObjectCreated(GameObject obj) { }

	public void SetMainText(string text) { }

	public override void SetProgress(float p) { }

	public override void SetProgressBarVisible(bool visible) { }

	public override void SetStatusText(string text) { }

	public void SetSubText(string text) { }

	public override void ShowDownloadConfirmBox(bool show, long sizeMB = 0) { }

	public void ShowUpdatePrompt(bool forceUpdate) { }

	private void Start() { }

	public virtual IEnumerator StartCloseAnimation() { }

	private void Update() { }

	[AsyncStateMachine(typeof(<WaitForDownloadConfirm>d__29))]
	public override Task WaitForDownloadConfirm() { }

	[AsyncStateMachine(typeof(<WaitForUpdatePromptClick>d__35))]
	public Task<UpdatePromptClick> WaitForUpdatePromptClick() { }

}

