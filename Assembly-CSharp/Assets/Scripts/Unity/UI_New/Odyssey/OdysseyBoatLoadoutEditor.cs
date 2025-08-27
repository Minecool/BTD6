namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyBoatLoadoutEditor : OdysseyBoatLoadoutPanel
{
	[CompilerGenerated]
	private struct <OnCopyToClipboard>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject tick; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int ANIMATOR_SKIP_ODYSSEY_COMPLETE_POPUP = 2; //Field offset: 0x0
	private OdysseyEditor editor; //Field offset: 0x180
	private int totalTowers; //Field offset: 0x188
	private int totalPowers; //Field offset: 0x18C
	private int totalTowersNonHero; //Field offset: 0x190
	public GameObject modifiedCrewObj; //Field offset: 0x198
	public GameObject infoPanal; //Field offset: 0x1A0
	public GameObject contentPanal; //Field offset: 0x1A8
	public Button infoBtn; //Field offset: 0x1B0
	public Animator odysseyCompleteAnimator; //Field offset: 0x1B8
	public Button shareBtn; //Field offset: 0x1C0
	public GameObject shareLockedMessagePanel; //Field offset: 0x1C8
	public Toggle DEBUGIgnoreCompletionCheck; //Field offset: 0x1D0
	private bool shareLocked; //Field offset: 0x1D8
	public GameObject shareTimerPanelObj; //Field offset: 0x1E0
	public TMP_Text shareTimerTxt; //Field offset: 0x1E8
	public TMP_Text shareLockedPopupDescTxt; //Field offset: 0x1F0
	public GameObject sharedObj; //Field offset: 0x1F8
	public TMP_Text sharedChalCode; //Field offset: 0x200
	public Button createSocialShareBtn; //Field offset: 0x208
	public GameObject shareLockObj; //Field offset: 0x210
	public GameObject createCopyCodeTick; //Field offset: 0x218
	public GameObject sharingLoadingSpinner; //Field offset: 0x220
	public GameObject minCrewNeededPanel; //Field offset: 0x228
	public NK_TextMeshProUGUI txtStatTimeTaken; //Field offset: 0x230
	public NK_TextMeshProUGUI txtStatLivesRemaining; //Field offset: 0x238
	public NK_TextMeshProUGUI txtStatPopCount; //Field offset: 0x240
	public NK_TextMeshProUGUI txtStatCashGenerated; //Field offset: 0x248
	public NK_TextMeshProUGUI txtStatMoabsPopped; //Field offset: 0x250
	public NK_TextMeshProUGUI txtStatAbilitiesUsed; //Field offset: 0x258
	public NK_TextMeshProUGUI odysseyName; //Field offset: 0x260
	private bool wasHeroUsed; //Field offset: 0x268
	private bool initialisedStats; //Field offset: 0x269
	private TowerData previousHeroAdded; //Field offset: 0x270

	private EmbarkedActiveOdyssey EmbarkedSaveData
	{
		private get { } //Length: 136
	}

	private bool IsCrewLoadoutModified
	{
		private get { } //Length: 1115
	}

	private ILocProvider Locs
	{
		private get { } //Length: 48
	}

	public OdysseyBoatLoadoutEditor() { }

	[CompilerGenerated]
	private void <Initialise>b__34_0() { }

	[CompilerGenerated]
	private void <Initialise>b__34_1() { }

	protected virtual void ClearUi() { }

	private bool FindItemInBoatLoadout(string name, List<DefaultData> data) { }

	private int FindQtyInBoatLoadout(string name, List<DefaultData> data) { }

	private EmbarkedActiveOdyssey get_EmbarkedSaveData() { }

	private bool get_IsCrewLoadoutModified() { }

	private ILocProvider get_Locs() { }

	public int GetrMinTowerCount(string name) { }

	public virtual void HeroMinusClicked(TowerData towerData) { }

	public virtual void HeroPlusClicked(TowerData towerData) { }

	public void Initialise(OdysseyEditor script, bool showFullVictoryScreenAnimation) { }

	private void InitialisedStats() { }

	private bool IsDataMaxReached(string dataName, List<DefaultData> data, int maxRestriction) { }

	public bool MinTowerCountReached(TowerData towerData) { }

	public virtual void OnClickResetDefaultLoadout() { }

	public virtual void OnCloseClick() { }

	public virtual void OnConfirmResetDefaultLoadout() { }

	[AsyncStateMachine(typeof(<OnCopyToClipboard>d__61))]
	private void OnCopyToClipboard(GameObject tick) { }

	public void OnInfoClick() { }

	private void OnShareBtnDown(BaseEventData eventData) { }

	private void OnShareBtnUp(BaseEventData eventData) { }

	public virtual void PowerMinusClicked(PowerData powerData) { }

	public virtual void PowerPlusClicked(PowerData powerData) { }

	public virtual void SetupUi() { }

	public void ShareClicked() { }

	public virtual void TowerMinusClicked(TowerData towerData) { }

	public virtual void TowerPlusClicked(TowerData towerData) { }

	public void UpdateFrame() { }

	public void UpdateSharedStatus() { }

	public virtual void UpdateUI() { }

}

