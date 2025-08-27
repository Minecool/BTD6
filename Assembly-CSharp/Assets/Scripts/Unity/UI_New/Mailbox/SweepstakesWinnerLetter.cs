namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class SweepstakesWinnerLetter : MonoBehaviour
{
	[CompilerGenerated]
	private struct <LoadRemotePrizeImage>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesWinnerLetter <>4__this; //Field offset: 0x20
		public string imageString; //Field offset: 0x28
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI subHeaderTxt; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI descriptionTxt; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI codeTxt; //Field offset: 0x38
	[SerializeField]
	private Image rewardIcon; //Field offset: 0x40
	[SerializeField]
	private Button confirmButton; //Field offset: 0x48
	[SerializeField]
	private Animator animator; //Field offset: 0x50
	[SerializeField]
	private Button copyButton; //Field offset: 0x58

	public SweepstakesWinnerLetter() { }

	private void AnimStateEnd() { }

	private void CopyCodeToClipboard() { }

	public void Initialize(SweepstakesWinnerMessage sweepstakesWinnerMessage) { }

	[AsyncStateMachine(typeof(<LoadRemotePrizeImage>d__14))]
	private Task LoadRemotePrizeImage(string imageString) { }

	private void OnConfirmClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

