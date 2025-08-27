namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class SweepstakesWinnerPopup : Popup
{
	[CompilerGenerated]
	private struct <LoadRemotePrizeImage>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesWinnerPopup <>4__this; //Field offset: 0x20
		public string imageString; //Field offset: 0x28
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowShareTickAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesWinnerPopup <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x128
	[SerializeField]
	private NK_TextMeshProUGUI subHeaderTxt; //Field offset: 0x130
	[SerializeField]
	private NK_TextMeshProUGUI descriptionTxt; //Field offset: 0x138
	[SerializeField]
	private NK_TextMeshProUGUI codeTxt; //Field offset: 0x140
	[SerializeField]
	private Image rewardIcon; //Field offset: 0x148
	[SerializeField]
	private Button confirmButton; //Field offset: 0x150
	[SerializeField]
	private Button copyButton; //Field offset: 0x158
	[SerializeField]
	private GameObject copyConfirmTick; //Field offset: 0x160

	public SweepstakesWinnerPopup() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	private void Awake() { }

	private void CopyCodeToClipboard() { }

	public void Initialize(SweepstakesWinnerMessage sweepstakesWinnerMessage) { }

	[AsyncStateMachine(typeof(<LoadRemotePrizeImage>d__11))]
	private Task LoadRemotePrizeImage(string imageString) { }

	[AsyncStateMachine(typeof(<ShowShareTickAsync>d__12))]
	private void ShowShareTickAsync() { }

}

