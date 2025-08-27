namespace Assets.Scripts.Unity.UI_New.Main.HeroSelect;

public class HeroUpgradeDetails : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SkinData, Int32> <>9__94_0; //Field offset: 0x8
		public static Comparison<TowerDetailsModelSort> <>9__106_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <SortHerosByUnlockLevel>b__106_0(TowerDetailsModelSort a, TowerDetailsModelSort b) { }

		internal int <UpdateAllButtons>b__94_0(SkinData skin) { }

	}

	[CompilerGenerated]
	private struct <SetHeroFontMaterial>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HeroUpgradeDetails <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartBackgroundColourSwap>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public HeroUpgradeDetails <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum GamepadFocusGroup
	{
		Heroes = 0,
		Info = 1,
		Skins = 2,
	}

	private class TowerDetailsModelSort
	{
		public HeroDetailsModel heroDetails; //Field offset: 0x10
		public int unlockLevel; //Field offset: 0x18

		public TowerDetailsModelSort() { }

	}

	public NK_TextMeshProUGUI heroShortDescription; //Field offset: 0x48
	public NK_TextMeshProUGUI saleOrigAmountTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI selectButtonText; //Field offset: 0x58
	public NK_TextMeshProUGUI heroDescription; //Field offset: 0x60
	public NK_TextMeshProUGUI heroBundleTitle; //Field offset: 0x68
	public NK_TextMeshProUGUI saleAmountTxt; //Field offset: 0x70
	public NK_TextMeshProUGUI selectedText; //Field offset: 0x78
	public NK_TextMeshProUGUI purchaseCost; //Field offset: 0x80
	public NK_TextMeshProUGUI lockedText; //Field offset: 0x88
	public NK_TextMeshProUGUI heroName; //Field offset: 0x90
	public NK_TextMeshProUGUI heroCountTxt; //Field offset: 0x98
	public NK_TextMeshProUGUI[] heroCost; //Field offset: 0xA0
	public GameObject heroBackgroundBanner; //Field offset: 0xA8
	public GameObject heroSelectCostsPanel; //Field offset: 0xB0
	public GameObject heroUpgradesPanel; //Field offset: 0xB8
	public GameObject heroRequirements; //Field offset: 0xC0
	public GameObject inGameCostPanel; //Field offset: 0xC8
	public GameObject topTitleDetails; //Field offset: 0xD0
	public GameObject buyHeroContainer; //Field offset: 0xD8
	public GameObject saleObj; //Field offset: 0xE0
	public GameObject purchaseAllHeroesGroup; //Field offset: 0xE8
	public Animator heroBundleAnimator; //Field offset: 0xF0
	public Animator heroSwitchedBgAnim; //Field offset: 0xF8
	public Animator upgradePanelAnim; //Field offset: 0x100
	public Animator heroPortraitAnim; //Field offset: 0x108
	public Image heroBundleIcon; //Field offset: 0x110
	public Image heroPortrait; //Field offset: 0x118
	public Button heroBundleBtn; //Field offset: 0x120
	public Button selectButton; //Field offset: 0x128
	public Button buyHeroButton; //Field offset: 0x130
	public RectTransform heroSelectRectTrans; //Field offset: 0x138
	public ScrollRect heroSelectScrollRect; //Field offset: 0x140
	public ScrollRect upgradeSelectScrollRect; //Field offset: 0x148
	public HeroButton heroButtonPrefab; //Field offset: 0x150
	public AudioClip click1Sound; //Field offset: 0x158
	public AudioClip tickSound; //Field offset: 0x160
	public AudioClip selectSound; //Field offset: 0x168
	public HeroSkinButton heroSkinButtonPrefab; //Field offset: 0x170
	public Transform groupTransform; //Field offset: 0x178
	public GameObject questScrollPanel; //Field offset: 0x180
	public GameObject questLockedPanel; //Field offset: 0x188
	public GameObject questAvailablePanel; //Field offset: 0x190
	public GameObject questPip; //Field offset: 0x198
	public NK_TextMeshProUGUI questUnlockLevelTxt; //Field offset: 0x1A0
	public Button questButton; //Field offset: 0x1A8
	private readonly List<TowerDetailsModelSort> sortedTowers; //Field offset: 0x1B0
	private readonly List<HeroSkinButton> heroSkinButtons; //Field offset: 0x1B8
	private readonly List<HeroButton> unusedHeroButtons; //Field offset: 0x1C0
	private readonly List<HeroButton> heroButtons; //Field offset: 0x1C8
	private List<HeroDetailsModel> selectedHeroes; //Field offset: 0x1D0
	private HeroUpgradeButton[] heroUpgrades; //Field offset: 0x1D8
	private SpriteReference selectedHeroPortraitSpriteId; //Field offset: 0x1E0
	private bool upgradesExpanded; //Field offset: 0x1E8
	private bool wasOpen; //Field offset: 0x1E9
	private int previouslySelectedUpgrade; //Field offset: 0x1EC
	private SkinData skinData; //Field offset: 0x1F0
	public GameObject[] gamepadHeroModeFocusObjects; //Field offset: 0x1F8
	private readonly Dictionary<String, ValueTuple`2<StoreItem, Boolean>> cachedHeroStoreBundles; //Field offset: 0x200
	[SerializeField]
	private GameObject rogueLoadoutObj; //Field offset: 0x208
	[SerializeField]
	private RogueArtifactDisplayIcon startingArtifactIcon; //Field offset: 0x210
	[SerializeField]
	private InstaTowerDisplay[] startingInstasIcons; //Field offset: 0x218
	[CompilerGenerated]
	private string <LastHeroShown>k__BackingField; //Field offset: 0x220
	private GamepadFocusGroup gamepadFocusGroup; //Field offset: 0x228
	private GameObject prevSelectedInfo; //Field offset: 0x230
	public Button gamepadInfoMode; //Field offset: 0x238
	public Button gamepadHeroMode; //Field offset: 0x240
	public Button gamepadSkinMode; //Field offset: 0x248
	private HeroScreenData heroScreenData; //Field offset: 0x250
	private bool wasCommonForegroundBuyMmButtonEnabled; //Field offset: 0x270

	public static bool CanUseRealMoneyStore
	{
		 get { } //Length: 168
	}

	public private string LastHeroShown
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private List<String> LimitedHeroSelection
	{
		private get { } //Length: 8
	}

	private string SelectedHeroId
	{
		private get { } //Length: 8
	}

	private int SelectedUpgradeIndex
	{
		private get { } //Length: 7
	}

	public HeroUpgradeDetails() { }

	[CompilerGenerated]
	private void <GamepadAwake>b__115_0(InputSystemMode _) { }

	[CompilerGenerated]
	private void <GamepadAwake>b__115_1() { }

	[CompilerGenerated]
	private void <GamepadAwake>b__115_2() { }

	[CompilerGenerated]
	private void <GamepadAwake>b__115_3() { }

	[CompilerGenerated]
	private void <ShowBundleStorePopup>b__103_0() { }

	protected virtual void Awake() { }

	public bool BindDetails(string heroIdToUse, bool showingSelected = true, bool forceUpdate = false) { }

	private void BindQuestData() { }

	private void CheckHeroStoreBundle() { }

	public virtual void Close() { }

	private void DisplayRogueStarterKit(string heroId) { }

	private void GamepadAwake() { }

	private void GamepadSelectFirst() { }

	public static bool get_CanUseRealMoneyStore() { }

	[CompilerGenerated]
	public string get_LastHeroShown() { }

	private List<String> get_LimitedHeroSelection() { }

	private string get_SelectedHeroId() { }

	private int get_SelectedUpgradeIndex() { }

	private string GetDisplayHero() { }

	private string GetHeroBundleIconTitleLoc(string heroId) { }

	public HeroButton GetNextButton() { }

	public HeroButton GetSelectedButton(string selectredHeroId) { }

	private HeroSkinButton GetSkinButton() { }

	public bool HasUnlockedAllSkinsForHero(string towerId) { }

	private void HeroBundleClicked() { }

	private void LateUpdate() { }

	public void OnUpgradePanelScroll(Vector2 value) { }

	public virtual void Open(object menuData) { }

	private void ParseScreenData(object menuData) { }

	public void PurchaseHero() { }

	private void PurchaserInitialised() { }

	private void QuestScrollClicked() { }

	public virtual void ReClose() { }

	public virtual void ReOpen(object menuData) { }

	public void SaveUiState() { }

	[CompilerGenerated]
	private void set_LastHeroShown(string value) { }

	public void SetAndSaveHero() { }

	[AsyncStateMachine(typeof(<SetHeroFontMaterial>d__91))]
	private Task SetHeroFontMaterial() { }

	public void SetupButtonsPanel() { }

	public void ShowBundleStorePopup() { }

	private void SnapInfo() { }

	private void SortHerosByUnlockLevel() { }

	[AsyncStateMachine(typeof(<StartBackgroundColourSwap>d__90))]
	private void StartBackgroundColourSwap() { }

	public void SwapInfoClicked() { }

	public void UpdateAllButtons(bool forceUpdate = false) { }

	public void UpdateButtonNotification(string withHeroId) { }

	public void UpdateHeroButtons(string heroId) { }

	private void UpdateHeroCount() { }

	private void UpdatePanels(bool forceUpdate = false) { }

	public void UpdateSelectedUpgrade(HeroUpgradeButton upgradeSelected) { }

}

