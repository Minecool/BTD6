namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu;

public class ShopMenu : RatioObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__38_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__38_0() { }

	}

	public static ShopMenu instance; //Field offset: 0x0
	public const int ConsiderInfinite = 1000; //Field offset: 0x0
	public GameObject towerButtons; //Field offset: 0x20
	public GameObject towerButtonPrefab; //Field offset: 0x28
	public ScrollRectWithDragCancel scrollRect; //Field offset: 0x30
	public ScrollRectWithDragCancel scrollRectRogue; //Field offset: 0x38
	public Scroller3D scroller3D; //Field offset: 0x40
	public GameObject powersDisabledStrikethrough; //Field offset: 0x48
	public GameObject powersButton; //Field offset: 0x50
	public GameObject bloonsButton; //Field offset: 0x58
	public GameObject goButtonPulse; //Field offset: 0x60
	public GameObject sendRound; //Field offset: 0x68
	public Button upgradesButton; //Field offset: 0x70
	public AudioClip clickSound; //Field offset: 0x78
	public RectTransform scrollMaskRogue; //Field offset: 0x80
	public bool isVertical; //Field offset: 0x88
	public GoFastForwardToggle goFFToggle; //Field offset: 0x90
	public GameObject summaryScreenPanel; //Field offset: 0x98
	public Button editorBackButton; //Field offset: 0xA0
	public Button editorTowerModeBackButton; //Field offset: 0xA8
	public Image editorBackLoadingIcon; //Field offset: 0xB0
	public GameObject rogueTowerButtonPrefab; //Field offset: 0xB8
	public GameObject rogueTowerButtons; //Field offset: 0xC0
	public GameObject roguePowerButtonPrefab; //Field offset: 0xC8
	public GameObject rogueBoostTowerButtons; //Field offset: 0xD0
	public GameObject rogueObj; //Field offset: 0xD8
	private SelectedDisplay selectedTowerDisplay; //Field offset: 0xE0
	private List<ITowerPurchaseButton> activeTowerButtons; //Field offset: 0xE8
	private List<GameObject> activePowerButtons; //Field offset: 0xF0
	private bool lockToTower; //Field offset: 0xF8
	private bool resetButtonPositions; //Field offset: 0xF9
	private bool initialised; //Field offset: 0xFA
	private IScroller scroller; //Field offset: 0x100
	private List<RogueInstaMonkey> rogueInstaMonkeys; //Field offset: 0x108
	private bool rebuildTowerSet; //Field offset: 0x110
	private List<RogueInstaMonkey> newInstas; //Field offset: 0x118
	private bool disallowSelectingDifferentTowers; //Field offset: 0x120
	private ITowerPurchaseButton selectedButton; //Field offset: 0x128
	private String[] monkeyTeams; //Field offset: 0x130
	private bool showingMonkeyTeams; //Field offset: 0x138

	public List<ITowerPurchaseButton> ActiveTowerButtons
	{
		 get { } //Length: 8
	}

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public bool ShowingMonkeyTeams
	{
		 get { } //Length: 8
	}

	public ShopMenu() { }

	private void AddListeners() { }

	private void Awake() { }

	public void CashChanged() { }

	private void CreateRoguePowerButton(PowerModel powerModel, int buttonIndex, RogueInstaMonkey rogueInstaMonkey) { }

	private ITowerPurchaseButton CreateRogueTowerButton(TowerModel model, int buttonIndex, bool showCounts, RogueInstaMonkey rogueInstaMonkey) { }

	private ITowerPurchaseButton CreateTowerButton(TowerModel model, int buttonIndex, bool showCounts) { }

	public void DeInit() { }

	public void DisableSelectingOtherTowers() { }

	public void EnableSelectingOtherTowers() { }

	public void ForceRefreshTowerSet() { }

	public void GameRestarted() { }

	public List<ITowerPurchaseButton> get_ActiveTowerButtons() { }

	private UnityToSimulation get_Bridge() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public bool get_ShowingMonkeyTeams() { }

	private SpriteReference GetPowerIcon(string baseId) { }

	public ITowerPurchaseButton GetSelected() { }

	public Transform GetTowerButtonFromBaseId(string baseId) { }

	public virtual void Initialise() { }

	public bool IsInitialised() { }

	public bool IsMonkeyInTeam(string towerBaseId) { }

	public void LockToTowerIndex(int towerIndex) { }

	private void MenuScrolled() { }

	public void OnDebugTowerButtonClicked() { }

	public void OnDebugTowerButtonClickedTriggered() { }

	private void OnDestroy() { }

	public void OnMapEditorSwitchingEditModesEvent(bool isLoading) { }

	public void OnRogueInstaAdded(RogueInstaMonkey rogueInstaMonkey) { }

	public void OnSelectionChanged(Selectable s) { }

	public void OnShowSummaryScreenClickedClicked() { }

	private void OnToggleEditorMenu() { }

	private void OnToggleUiVisibility(bool visible) { }

	public virtual void PostInitialised() { }

	public void QueueRebuildTowerSet() { }

	private void RebuildRogueTowers() { }

	private void RebuildTowerSet() { }

	public void RoundEnd() { }

	public void ScrollToTower(int towerIndex) { }

	public void Select(ITowerPurchaseButton b, string nameDisplayOverride = null, bool upgradesButtonInteractableOverride = false) { }

	public void SendRound() { }

	public void SetMonkeyTeams(String[] monkeyTeams) { }

	public void SetSelectedButton(string baseId) { }

	public void SetSendRoundBtnInteractable(bool value) { }

	public void ShowHideSummaryScreenPanel(bool show) { }

	public void ShowMonkeyTeams(bool showingMonkeyTeams, bool canPlayMonkeyTeamBrokenAnim) { }

	public void TowerCreated(TowerToSimulation tower) { }

	public void TowerDestroyed(TowerToSimulation tower) { }

	private void TowerSetChanged(bool fullRebuild) { }

	public void TutorialDisableSelection(string exlcludedTower = "") { }

	public void TutorialEnableSelection() { }

	public void UnlocksChanged() { }

	public void UnlockTowerIndex() { }

	private void Update() { }

	public void UpdateRogueCooldowns() { }

	public void UpgradesChanged() { }

	public void XpChanged() { }

}

