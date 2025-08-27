namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossEventScreenPlayPanel : GameMenu
{
	[CompilerGenerated]
	private struct <AsyncCoopClicked>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossEventScreenPlayPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossEventScreenPlayPanel <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image bossModeNormalImg; //Field offset: 0x48
	public Image bossModeEliteImg; //Field offset: 0x50
	public GameObject bossModeNormalObj; //Field offset: 0x58
	public GameObject bossModeEliteObj; //Field offset: 0x60
	public TMP_Text bossModeNormalTxt; //Field offset: 0x68
	public TMP_Text bossModeEliteTxt; //Field offset: 0x70
	[SerializeField]
	private SpriteReference leastCashSprite; //Field offset: 0x78
	[SerializeField]
	private SpriteReference leastTiersSprite; //Field offset: 0x80
	public GameObject bossModeVictoryConditionObj; //Field offset: 0x88
	public Image bossModeVictoryConditionImg; //Field offset: 0x90
	public TMP_Text bossModeVictoryConditionTxt; //Field offset: 0x98
	public Image mapImg; //Field offset: 0xA0
	public TMP_Text mapNameTxt; //Field offset: 0xA8
	public TMP_Text difficultyTxt; //Field offset: 0xB0
	public TMP_Text livesTxt; //Field offset: 0xB8
	public TMP_Text cashTxt; //Field offset: 0xC0
	public BossEventScreenTierRewardPanel[] tierRewardPanels; //Field offset: 0xC8
	public Button playBtn; //Field offset: 0xD0
	public Button continueBtn; //Field offset: 0xD8
	public Button coopBtn; //Field offset: 0xE0
	public Button backgroundCloseBtn; //Field offset: 0xE8
	public Button moreRulesBtn; //Field offset: 0xF0
	public AudioClip startGameSound; //Field offset: 0xF8
	private MapSaveDataModel continueMapSave; //Field offset: 0x100
	private BossEventPlayMenuData menuData; //Field offset: 0x108
	private DailyChallengeModel dcmRulesDisplay; //Field offset: 0x110
	private bool invokedclose; //Field offset: 0x118

	public BossEventScreenPlayPanel() { }

	[AsyncStateMachine(typeof(<AsyncCoopClicked>d__33))]
	private Task AsyncCoopClicked() { }

	private void BackgroundCloseClicked() { }

	private void ContinueClicked() { }

	public void CoopClicked() { }

	private void MoreRulesClicked() { }

	public void OnDisable() { }

	public void OnEnable() { }

	[AsyncStateMachine(typeof(<Open>d__28))]
	public virtual void Open(object data) { }

	private void PlayClicked() { }

	private void SetMap() { }

	private void StartNewSinglePlayerGame() { }

	private void Update() { }

}

