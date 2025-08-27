namespace Assets.Scripts.Unity.UI_New.GameOver;

public abstract class SummaryScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public SummaryScreen <>4__this; //Field offset: 0x10
		public KonFuze mmCost; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <RetryLastRound>b__0() { }

		internal void <RetryLastRound>b__1() { }

		internal void <RetryLastRound>b__2() { }

	}

	internal enum ScoreBoardType
	{
		Score = 0,
		Time = 1,
	}

	public Button homeBtn; //Field offset: 0x48
	public Button reviewMapBtn; //Field offset: 0x50
	public AudioClip clickSound; //Field offset: 0x58
	public Animator animator; //Field offset: 0x60
	public GameObject personalBest; //Field offset: 0x68
	public ScorePanelUI timeUI; //Field offset: 0x70
	public ScorePanelUI scoreUI; //Field offset: 0xA8
	public ScoreBoardType scoreBoardType; //Field offset: 0xE0
	protected SummaryScreenData summaryScreenData; //Field offset: 0xE8
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"mapSave", "contentType", "contentId"}])]
	private ValueTuple<BaseSaveDataModel, ContentType, String> playerContentMapSave; //Field offset: 0xF0
	private bool canEnableButtonsOnEnable; //Field offset: 0x108

	public ScorePanelUI ChallengePanelUI
	{
		 get { } //Length: 101
	}

	private string ContinueMapSaveId
	{
		private get { } //Length: 301
	}

	private bool IsMapReviewAllowed
	{
		private get { } //Length: 76
	}

	protected abstract bool IsVictoryScreen
	{
		 get { } //Length: 0
	}

	protected LootSet LootSet
	{
		 get { } //Length: 30
	}

	protected SummaryScreen() { }

	protected virtual void Awake() { }

	protected override void ButtonsInteractive(bool canInteract) { }

	public ScorePanelUI get_ChallengePanelUI() { }

	private string get_ContinueMapSaveId() { }

	private bool get_IsMapReviewAllowed() { }

	protected abstract bool get_IsVictoryScreen() { }

	protected LootSet get_LootSet() { }

	protected override void HomeClicked() { }

	protected void OnConfirmRetryFromCheckpoint(KonFuze mmCost) { }

	protected void OnConfirmRetryLastRound(KonFuze mmCost) { }

	public override void OnDisable() { }

	public override void OnEnable() { }

	public override void OnNextClicked() { }

	public virtual void Open(object menuData) { }

	public virtual void ReOpen(object _) { }

	protected void RetryLastRound(KonFuze mmCost) { }

	private void ReviewClicked() { }

	private void RunExitAnimation() { }

}

