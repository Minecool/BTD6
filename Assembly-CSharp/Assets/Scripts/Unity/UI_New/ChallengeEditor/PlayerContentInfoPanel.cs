namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class PlayerContentInfoPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public PlayerContent playerContent; //Field offset: 0x10
		public PlayerContentInfoPanel <>4__this; //Field offset: 0x18
		public OnSharedToClipboard <>9__1; //Field offset: 0x20

		public <>c__DisplayClass20_0() { }

		internal void <Initialize>b__0() { }

		internal void <Initialize>b__1() { }

	}

	[CompilerGenerated]
	private struct <Initialize>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContent playerContent; //Field offset: 0x28
		public PlayerContentInfoPanel <>4__this; //Field offset: 0x30
		private <>c__DisplayClass20_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCopyToClipboard>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject tick; //Field offset: 0x28
		public PlayerContentInfoPanel <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ToggleStatsPopup>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContentInfoPanel <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject oldChallengeBg; //Field offset: 0x20
	public GameObject likeTglEnabledBg; //Field offset: 0x28
	public GameObject playCopyCodeTick; //Field offset: 0x30
	public ChallengeStatPlayerInfo challengeAuthorInfo; //Field offset: 0x38
	public PlayerContentStatsPanel playerContentStatsPanel; //Field offset: 0x40
	public CustomScaleAnimator likeBtnAnimator; //Field offset: 0x48
	public HoverableInfoPopup winPercHoverableZone; //Field offset: 0x50
	public TMP_Text versionTxt; //Field offset: 0x58
	public TMP_Text ratingCountTxt; //Field offset: 0x60
	public TMP_Text winPercTxt; //Field offset: 0x68
	public Toggle likeTgl; //Field offset: 0x70
	public Toggle winPercTgl; //Field offset: 0x78
	public Toggle favouriteTgl; //Field offset: 0x80
	public TMP_Text playCodeTxt; //Field offset: 0x88
	public Button playSocialShareBtn; //Field offset: 0x90
	public Button challengeStatsBtn; //Field offset: 0x98
	private PlayerContent playerContent; //Field offset: 0xA0

	private ContentType ContentType
	{
		private get { } //Length: 39
	}

	public PlayerContentInfoPanel() { }

	private void Awake() { }

	private void FavouriteToggled(bool value) { }

	private ContentType get_ContentType() { }

	[AsyncStateMachine(typeof(<Initialize>d__20))]
	public void Initialize(PlayerContent playerContent) { }

	private void LikeToggled(bool value) { }

	[AsyncStateMachine(typeof(<OnCopyToClipboard>d__23))]
	private void OnCopyToClipboard(GameObject tick) { }

	public void SetInteractable(bool value) { }

	private void SetWinPercTxt(bool isAttempts) { }

	[AsyncStateMachine(typeof(<ToggleStatsPopup>d__21))]
	private void ToggleStatsPopup() { }

}

