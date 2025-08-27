namespace Assets.Scripts.Unity.UI_New.SweepStakes;

public class SweepStakesEventScreen : GameMenu
{
	[CompilerGenerated]
	private struct <BindPrizeIconImage>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string imageString; //Field offset: 0x20
		public SweepStakesEventScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoubleCheckSocialBarrierAndLoadUi>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepStakesEventScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private bool <>7__wrap1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetSweepstakesStatus>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepStakesEventScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x28
		private TaskAwaiter<SweepstakesStatusResponse> <>u__2; //Field offset: 0x30
		private TaskAwaiter <>u__3; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadStatsAndClaimPendingTickets>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepStakesEventScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShareButtonClickedAsync>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepStakesEventScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<SocialShareResult> <>u__1; //Field offset: 0x30
		private TaskAwaiter<SweepstakesShareCodeResponse> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowShareTickAsync>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepStakesEventScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryClaimTickets>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepStakesEventScreen <>4__this; //Field offset: 0x20
		public Dictionary<Int32, List`1<Int32>> pendingClaims; //Field offset: 0x28
		private TaskAwaiter<SweepstakesTicketClaimResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Header("General UI")]
	[SerializeField]
	private NK_TextMeshProUGUI eventTitleText; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI eventTimerText; //Field offset: 0x50
	[SerializeField]
	private NK_TextMeshProUGUI ticketAmountText; //Field offset: 0x58
	[SerializeField]
	private GameObject loadingThrobber; //Field offset: 0x60
	[SerializeField]
	private SweepstakesFirstTimePopup firstTimePopup; //Field offset: 0x68
	[SerializeField]
	private Button infoButton; //Field offset: 0x70
	[SerializeField]
	private Image prizeIcon; //Field offset: 0x78
	[SerializeField]
	private GameObject prizeIconLoading; //Field offset: 0x80
	[SerializeField]
	private GameObject prizeIconContainer; //Field offset: 0x88
	[SerializeField]
	private Button termsButton; //Field offset: 0x90
	[Header("Share UI")]
	[SerializeField]
	private GameObject confirmedShareTick; //Field offset: 0x98
	[SerializeField]
	private NK_TextMeshProUGUI shareCodeText; //Field offset: 0xA0
	[SerializeField]
	private GameObject shareButton; //Field offset: 0xA8
	[SerializeField]
	private Image copyToClipboardIcon; //Field offset: 0xB0
	[SerializeField]
	private Image androidShareIcon; //Field offset: 0xB8
	[SerializeField]
	private Image iosShareIcon; //Field offset: 0xC0
	[SerializeField]
	private GameObject shareObjectiveTickObj; //Field offset: 0xC8
	[SerializeField]
	private GameObject referalAcceptedTickObj; //Field offset: 0xD0
	[SerializeField]
	private GameObject referalOpenedTickObj; //Field offset: 0xD8
	[SerializeField]
	private NK_TextMeshProUGUI shareCodeTicketAmountTxt; //Field offset: 0xE0
	[SerializeField]
	private NK_TextMeshProUGUI seenReferalTicketAmountTxt; //Field offset: 0xE8
	[SerializeField]
	private NK_TextMeshProUGUI openReferalTicketAmountTxt; //Field offset: 0xF0
	[Header("Daily Tasks")]
	[SerializeField]
	private GameObject dailyTemplate; //Field offset: 0xF8
	[SerializeField]
	private GameObject dailyContainer; //Field offset: 0x100
	[SerializeField]
	private HorizontalLayoutGroup dailyTaskGroup; //Field offset: 0x108
	[SerializeField]
	private float dailyTaskSpacing; //Field offset: 0x110
	[Header("Active Icons")]
	[SerializeField]
	private GameObject activeIconContainer; //Field offset: 0x118
	[SerializeField]
	private List<SweepstakesDailyTaskActiveIcon> activeIcons; //Field offset: 0x120
	[Header("Referal Code Popup")]
	[SerializeField]
	private Button openReferallCodePopupBtn; //Field offset: 0x128
	[SerializeField]
	private SweepstakesReferralCodePopup referallCodePopupObj; //Field offset: 0x130
	private readonly List<SweepstakesDailyTask> sweepstakesTaskUis; //Field offset: 0x138
	private SweepstakesEvent sweepstakesEvent; //Field offset: 0x140
	private SweepstakesEventSettings sweepstakesSettings; //Field offset: 0x148
	private SweepstakesStats stats; //Field offset: 0x150
	[CompilerGenerated]
	private readonly TaskCompletionSource<Sprite> <RewardSpriteTcs>k__BackingField; //Field offset: 0x158
	private bool firstTimeSeen; //Field offset: 0x160
	private Dictionary<Int32, List`1<Int32>> newPendingClaims; //Field offset: 0x168
	private string referralCodeToOpen; //Field offset: 0x170
	private SweepstakesStatusResponse _sweepstakesStatus; //Field offset: 0x178
	private float updateSecondTimer; //Field offset: 0x180

	private static DateTime Now
	{
		private get { } //Length: 7
	}

	public TaskCompletionSource<Sprite> RewardSpriteTcs
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private SweepstakesStatusResponse SweepstakesStatus
	{
		private get { } //Length: 8
		private set { } //Length: 398
	}

	public SweepStakesEventScreen() { }

	[CompilerGenerated]
	private void <Open>b__48_0(SweepstakesStatusResponse s) { }

	[CompilerGenerated]
	private SweepstakesStatusResponse <Open>b__48_1() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<BindPrizeIconImage>d__58))]
	private Task BindPrizeIconImage(string imageString) { }

	[AsyncStateMachine(typeof(<DoubleCheckSocialBarrierAndLoadUi>d__49))]
	public Task DoubleCheckSocialBarrierAndLoadUi() { }

	private void GenerateOrUpdateUi() { }

	private static DateTime get_Now() { }

	[CompilerGenerated]
	public TaskCompletionSource<Sprite> get_RewardSpriteTcs() { }

	private SweepstakesStatusResponse get_SweepstakesStatus() { }

	private string GetDisplayShareCode() { }

	private Dictionary<Int32, List`1<Int32>> GetPendingClaims(int taskIndex) { }

	[AsyncStateMachine(typeof(<GetSweepstakesStatus>d__59))]
	public Task GetSweepstakesStatus() { }

	private bool HasClaimedAll(int taskIndex) { }

	private void OnDestroy() { }

	private void OnInfoButtonClicked() { }

	private void OnStatusRefreshed() { }

	public void OnTermsAndConditionsAcceptedAsync() { }

	private void OnTermsButtonClicked() { }

	public virtual void Open(object data) { }

	private void OpenReferallCodePopup() { }

	public void OpenReferallCodePopupWithCode(string code) { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<ReadStatsAndClaimPendingTickets>d__60))]
	private Task ReadStatsAndClaimPendingTickets() { }

	private void RefreshShareButtonStatus() { }

	public void ScrollDailyTaskContentToPosition(float position) { }

	private void set_SweepstakesStatus(SweepstakesStatusResponse value) { }

	[AsyncStateMachine(typeof(<ShareButtonClickedAsync>d__66))]
	private void ShareButtonClickedAsync() { }

	private void ShowNewTicketRewards() { }

	[AsyncStateMachine(typeof(<ShowShareTickAsync>d__65))]
	private void ShowShareTickAsync() { }

	[AsyncStateMachine(typeof(<TryClaimTickets>d__61))]
	private Task TryClaimTickets(Dictionary<Int32, List`1<Int32>> pendingClaims) { }

	private void Update() { }

	private void UpdateTimer() { }

}

