namespace Assets.Scripts.Unity.UI_New.SweepStakes;

public class SweepstakesFirstTimePopup : MonoBehaviour
{
	[CompilerGenerated]
	private struct <BindPrizeIconImage>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task<Sprite> rewardsIconTask; //Field offset: 0x20
		public SweepstakesFirstTimePopup <>4__this; //Field offset: 0x28
		private TaskAwaiter<Sprite> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLocalizedSweepstakesTerms>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Language currentLanguage; //Field offset: 0x20
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTermsAndConditionsPopup>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesFirstTimePopup <>4__this; //Field offset: 0x20
		private Language <currentLanguage>5__2; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class TermsAndConditionsAccepted : MulticastDelegate
	{

		public TermsAndConditionsAccepted(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[Header("Sweepstakes First Time Popup UI")]
	[SerializeField]
	private GameObject firstTimePopupObj; //Field offset: 0x20
	[SerializeField]
	private GameObject rewardIconLoading; //Field offset: 0x28
	[SerializeField]
	private GameObject rewardIconContainer; //Field offset: 0x30
	[SerializeField]
	private Button infoOkButton; //Field offset: 0x38
	[SerializeField]
	private Image rewardIcon; //Field offset: 0x40
	[SerializeField]
	private NK_TextMeshProUGUI rewardText; //Field offset: 0x48
	[SerializeField]
	private Animator animator; //Field offset: 0x50
	[Header("T&C Popup UI")]
	[SerializeField]
	private GameObject termsPopupObj; //Field offset: 0x58
	[SerializeField]
	private Button termsConfirmButton; //Field offset: 0x60
	[SerializeField]
	private Scrollbar termsScrollbar; //Field offset: 0x68
	[SerializeField]
	private Button termsSkipButton; //Field offset: 0x70
	[SerializeField]
	private NK_TextMeshProUGUI termsBody; //Field offset: 0x78
	[SerializeField]
	private Button termsOkButton; //Field offset: 0x80
	[SerializeField]
	private GameObject loadingTermsText; //Field offset: 0x88
	private SweepstakesStats stats; //Field offset: 0x90
	private Language termsLoadedLanguage; //Field offset: 0x98

	public SweepstakesFirstTimePopup() { }

	private void AnimStateEnd() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<BindPrizeIconImage>d__26))]
	private Task BindPrizeIconImage(Task<Sprite> rewardsIconTask) { }

	public void ClosePopup() { }

	[AsyncStateMachine(typeof(<GetLocalizedSweepstakesTerms>d__33))]
	public static Task<String> GetLocalizedSweepstakesTerms(Language currentLanguage) { }

	public void Initialize(SweepstakesStats stats, Task<Sprite> rewardsIconTask) { }

	private void LoadFirstTimePopup() { }

	[AsyncStateMachine(typeof(<LoadTermsAndConditionsPopup>d__24))]
	private Task LoadTermsAndConditionsPopup() { }

	private void OnConfirmClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnTermsCloseButtonClicked() { }

	private void OnTermsConfirmedClicked() { }

	private void OnTermsSkipButtonClicked() { }

	public void ShowInfo() { }

	public void ShowTermsAndConditions() { }

	private void Update() { }

}

