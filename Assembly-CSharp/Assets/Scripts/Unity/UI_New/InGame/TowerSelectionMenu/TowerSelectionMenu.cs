namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class TowerSelectionMenu : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public TowerSelectionMenu <>4__this; //Field offset: 0x10
		public PrefabReference secondaryMenuPrefab; //Field offset: 0x18

		public <>c__DisplayClass126_0() { }

		internal void <LoadSecondarySelectionMenu>b__0(AsyncOperationHandle<GameObject> handle) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public TowerSelectionMenu <>4__this; //Field offset: 0x10
		public UpgradeModel upgrade; //Field offset: 0x18
		public int index; //Field offset: 0x20
		public float upgradeCost; //Field offset: 0x24

		public <>c__DisplayClass68_0() { }

		internal void <UpgradeTower>b__0() { }

		internal void <UpgradeTower>b__1() { }

		internal void <UpgradeTower>b__2(double cashInvestment) { }

		internal void <UpgradeTower>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public float upgradeCost; //Field offset: 0x10
		public double nonUpgradeCashInvestment; //Field offset: 0x18
		public TowerSelectionMenu <>4__this; //Field offset: 0x20
		public int path; //Field offset: 0x28
		public UpgradeModel upgrade; //Field offset: 0x30

		public <>c__DisplayClass69_0() { }

		internal void <UpgradeTower>b__0(bool isUpgraded) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public TowerSelectionMenu <>4__this; //Field offset: 0x10
		public TowerToSimulation selectedTowerLocal; //Field offset: 0x18
		public int levelUpCost; //Field offset: 0x20

		public <>c__DisplayClass82_0() { }

		internal void <UnlockNextHeroLevel>b__0(bool success) { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__58 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TowerSelectionMenu <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Initialise>d__58(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public static TowerSelectionMenu instance; //Field offset: 0x0
	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationStateOpenLeft = 1; //Field offset: 0x0
	private const int animationStateOpenRight = 2; //Field offset: 0x0
	private const int animationStateOpenHardRight = 3; //Field offset: 0x0
	private const int animationStateOpenHardLeft = 4; //Field offset: 0x0
	private readonly string visibleStateLabel; //Field offset: 0x20
	public NK_TextMeshProUGUI sellText; //Field offset: 0x28
	public GameObject heroDetails; //Field offset: 0x30
	public GameObject towerDetails; //Field offset: 0x38
	public GameObject paragonDetails; //Field offset: 0x40
	public Animator animator; //Field offset: 0x48
	public UpgradeInfoPopup[] upgradeInfoPopups; //Field offset: 0x50
	public GameObject sellButton; //Field offset: 0x58
	private Button sellButtonButton; //Field offset: 0x60
	public RightMenu rightMenu; //Field offset: 0x68
	public NK_TextMeshProUGUI CurrentHeroLevelTitle; //Field offset: 0x70
	public NK_TextMeshProUGUI CurrentHeroLevelDescription; //Field offset: 0x78
	public NK_TextMeshProUGUI CurrentHeroLevel; //Field offset: 0x80
	public NK_TextMeshProUGUI NextHeroLevelTitle; //Field offset: 0x88
	public NK_TextMeshProUGUI NextHeroLevelDescription; //Field offset: 0x90
	public NK_TextMeshProUGUI UnlockNextHeroCost; //Field offset: 0x98
	public Button unlockNextHeroLevelBtn; //Field offset: 0xA0
	public Image HeroXpBar; //Field offset: 0xA8
	public UpgradeObject[] upgradeButtons; //Field offset: 0xB0
	public AbilityButton[] abilityButtons; //Field offset: 0xB8
	public GameObject emptyAbilityIconObject; //Field offset: 0xC0
	public NK_TextMeshProUGUI paragonTitle; //Field offset: 0xC8
	public NK_TextMeshProUGUI paragonDescription; //Field offset: 0xD0
	public NK_TextMeshProUGUI paragonDegree; //Field offset: 0xD8
	public Image paragonIcon; //Field offset: 0xE0
	public RectTransform scalar; //Field offset: 0xE8
	public float bottomScaleAmount; //Field offset: 0xF0
	public GameObject[] removeOnSubTower; //Field offset: 0xF8
	private TowerToSimulation selectedTower; //Field offset: 0x100
	public List<ObjectId> unsellableTowers; //Field offset: 0x108
	public AudioClip returnSound; //Field offset: 0x110
	public TowerSelectionMenuThemeManager themeManager; //Field offset: 0x118
	public Button heroBoosterButton; //Field offset: 0x120
	public NK_TextMeshProUGUI heroBoosterButtonText; //Field offset: 0x128
	public Button duplicateButton; //Field offset: 0x130
	public Button duplicateCircleButton; //Field offset: 0x138
	public Button placeCrosspathsButton; //Field offset: 0x140
	public Button paragonButton; //Field offset: 0x148
	public Button forceParagonButton; //Field offset: 0x150
	public GameObject secondarySelectionMenuContainer; //Field offset: 0x158
	public Button secondarySelectionMenuButton; //Field offset: 0x160
	public Animator secondarySelectionMenuCloseButtonAnimator; //Field offset: 0x168
	[CompilerGenerated]
	private SecondarySelectionMenuUi <CurrentSecondaryMenu>k__BackingField; //Field offset: 0x170
	private AsyncOperationHandle<GameObject> loadSecondarySelectionMenuHandle; //Field offset: 0x178
	private Dictionary<PrefabReference, SecondarySelectionMenuUi> secondaryMenues; //Field offset: 0x190
	private bool triggerUiUpdate; //Field offset: 0x198
	public bool wasSecondarySelectionMenuShowing; //Field offset: 0x199
	public bool isUpgradePopupShowing; //Field offset: 0x19A
	private bool showing; //Field offset: 0x19B
	private int fromLevel; //Field offset: 0x19C

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	public private SecondarySelectionMenuUi CurrentSecondaryMenu
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public TowerSelectionMenu() { }

	public void BeastHandlerMergeButton(TowerToSimulation tts, string beastTowerId) { }

	private void CashChanged() { }

	private void CheckUpgradeCosts() { }

	public string ConvertTouchTextToMouse(string text) { }

	public void DebugDuplicateCircle() { }

	public void DebugDuplicateTower() { }

	public void DebugParagon() { }

	public void DebugPlaceCrosspaths() { }

	public void DeselectTower() { }

	public void EndMatch(InputManager im) { }

	public void ExitTowerSelectionMenu() { }

	private UnityToSimulation get_Bridge() { }

	[CompilerGenerated]
	public SecondarySelectionMenuUi get_CurrentSecondaryMenu() { }

	public TowerToSimulation GetSelectedTower() { }

	public GameObject[] GetTutorialUpgradeArrows() { }

	public void HideSecondarySelectionMenu() { }

	public void HideUpgradeInfoPopup(int row) { }

	[IteratorStateMachine(typeof(<Initialise>d__58))]
	public virtual IEnumerator Initialise() { }

	private void InitUpgradeButtons() { }

	private bool IsAbilityValidToAdd(AbilityToSimulation ability) { }

	public bool IsOpenedRight() { }

	public bool IsSecondarySelectionMenuVisible() { }

	public bool IsUpgradePathClosed(int path) { }

	private void LoadSecondarySelectionMenu(PrefabReference secondaryMenuPrefab) { }

	public void MonkeyNameUpdated() { }

	public void NextTargetType() { }

	private void OnCancelHeroBooster() { }

	public void OnClose() { }

	private void OnCustomUIChanged(TowerToSimulation tower) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	public void OnHeroBoosterButtonClicked() { }

	private void OnHideUpgrades() { }

	private void OnLost() { }

	private void OnPrimeCustomAbilityInput(AbilityToSimulation abilityToSim, string classname) { }

	private void OnSelectedTowerActivatedAbilityPressed(int index) { }

	private void OnSimUpdate() { }

	private void OnSpecialUiEvent(string eventId) { }

	private void OnSuccessCallback(bool success) { }

	private void OnTowerSelectionPanelForceUpdate() { }

	private void OnTowerXpChanged(TowerToSimulation tower) { }

	public void OnTsmThemeAction(ObjectId towerId, string themeId, string buttonId, TSMInfoModel info) { }

	public virtual void OnUpdate() { }

	public void OnUpgradePricesChanged(TowerToSimulation tower) { }

	public void PrevTargetType() { }

	private void RefreshUpgrades() { }

	public void SelectionChanged(Selectable s) { }

	public void SelectTower(TowerToSimulation tower) { }

	public void Sell() { }

	[CompilerGenerated]
	private void set_CurrentSecondaryMenu(SecondarySelectionMenuUi value) { }

	public void Show() { }

	public void ShowSecondarySelectionMenu() { }

	public void ShowUpgradeInfoPopup(int row, bool forCurrent) { }

	public void StartListeners() { }

	public void StartMatch(InputManager im) { }

	private void TargetTypeChanged(TowerToSimulation tts, TargetType type) { }

	public void ToggleNextInfo() { }

	private void TowerCreated(TowerToSimulation tts) { }

	private void TowerDestroyed(TowerToSimulation tts) { }

	private void TowerTransformed(TowerToSimulation tts) { }

	private void TowerUpgraded(TowerToSimulation tts) { }

	public void TowerXpChanged() { }

	public void UnlockNextHeroLevel() { }

	public void UpdateAbilities() { }

	private void UpdateCurrentLevel(TowerToSimulation tower) { }

	private void UpdateHeroBooster(TowerToSimulation tower) { }

	private void UpdateNextLevel(TowerToSimulation tower) { }

	private void UpdateParagon(TowerToSimulation tower) { }

	private void UpdateTower() { }

	private void UpdateUnlockCost(TowerToSimulation tower) { }

	public void UpdateUpgradeVisuals(bool upgradeClicked = false) { }

	private void UpdateXpBar(TowerToSimulation tower) { }

	public void UpgradeTower(int index, bool isParagon = false) { }

	private void UpgradeTower(UpgradeModel upgrade, int path, float upgradeCost, double nonUpgradeCashInvestment = 0) { }

	private void UseHeroBooster() { }

}

