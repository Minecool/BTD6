namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsStoreScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<GameObject> <>9__62_6; //Field offset: 0x8
		public static ReturnCallback <>9__63_1; //Field offset: 0x10
		public static Func<TeamsStoreItem, Boolean> <>9__73_0; //Field offset: 0x18
		public static Func<TeamsStoreItem, Int32> <>9__73_1; //Field offset: 0x20
		public static Func<KeyValuePair`2<TeamStoreWorldSlot, List`1<String>>, TeamStoreWorldSlot> <>9__81_0; //Field offset: 0x28
		public static Func<KeyValuePair`2<TeamStoreWorldSlot, List`1<String>>, List`1<String>> <>9__81_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal TeamStoreWorldSlot <OnInfoPanelSelectPressedAsync>b__81_0(KeyValuePair<TeamStoreWorldSlot, List`1<String>> entry) { }

		internal List<String> <OnInfoPanelSelectPressedAsync>b__81_1(KeyValuePair<TeamStoreWorldSlot, List`1<String>> entry) { }

		internal void <Open>b__63_1() { }

		internal void <Start>b__62_6(GameObject obj) { }

		internal bool <UpdateInventory>b__73_0(TeamsStoreItem storeItem) { }

		internal int <UpdateInventory>b__73_1(TeamsStoreItem storeItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public TeamsStoreScreen <>4__this; //Field offset: 0x10
		public object data; //Field offset: 0x18
		public TeamStoreMetadata teamStoreMetadata; //Field offset: 0x20
		public TeamsStoreShopTab tabToOpen; //Field offset: 0x28

		public <>c__DisplayClass63_0() { }

		internal void <Open>b__0() { }

		internal void <Open>b__2() { }

		internal bool <Open>b__3(TeamsStoreUiPanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public TeamStoreRelic dailyRelic; //Field offset: 0x10
		public Func<TeamsStoreItem, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass67_0() { }

		internal bool <UpdateDailiesAsync>b__0(TeamsStoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_1
	{
		public TeamStoreRelic eventRelic; //Field offset: 0x10

		public <>c__DisplayClass67_1() { }

		internal bool <UpdateDailiesAsync>b__1(TeamsStoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public TeamsStoreShopTab selectedTab; //Field offset: 0x10
		public Func<TeamsStoreItem, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass70_0() { }

		internal bool <UpdateSubTabUIAsync>b__0(TeamsStoreItem storeItem) { }

	}

	[CompilerGenerated]
	private struct <OnInfoPanelSelectPressedAsync>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsStoreScreen <>4__this; //Field offset: 0x28
		public bool unselect; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSpendTrophies>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsStoreScreen <>4__this; //Field offset: 0x28
		public int trophies; //Field offset: 0x30
		public string itemId; //Field offset: 0x38
		private int <balanceBeforeTransaction>5__2; //Field offset: 0x40
		private int <itemBalance>5__3; //Field offset: 0x44
		private int <playerBalance>5__4; //Field offset: 0x48
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"itemBalance", "playerBalance"}])]
		private TaskAwaiter<ValueTuple`2<Int32, Int32>> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private TaskAwaiter<Boolean> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsStoreScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private <>c__DisplayClass63_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private TaskAwaiter<Dictionary`2<String, TeamStoreItemContributions>> <>u__3; //Field offset: 0x50
		private TaskAwaiter<IReadOnlyCollection`1<ContestedTerritoryRelicType>> <>u__4; //Field offset: 0x58
		private TaskAwaiter<ContestedTerritoryRelicType[]> <>u__5; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshTeamTrophyBalance>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsStoreScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpendTrophiesAsync>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"itemBalance", "playerBalance"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<Int32, Int32>> <>t__builder; //Field offset: 0x8
		public string itemId; //Field offset: 0x20
		public int trophies; //Field offset: 0x28
		public TeamsStoreScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter<ContributionResponse> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateDailiesAsync>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsStoreScreen <>4__this; //Field offset: 0x28
		private <>c__DisplayClass67_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter<TeamStoreRelic> <>u__1; //Field offset: 0x38
		private TaskAwaiter<TeamStoreRelic[]> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TeamsStoreUiPanel uiPanelPrefab; //Field offset: 0x48
	public GridLayoutGroup shopLayoutGroupRelics; //Field offset: 0x50
	public GridLayoutGroup shopLayoutSelectedGroupRelics; //Field offset: 0x58
	public GridLayoutGroup shopLayoutGroupTeamFlair; //Field offset: 0x60
	public GridLayoutGroup inventoryLayoutGroup; //Field offset: 0x68
	public GameObject relicsObject; //Field offset: 0x70
	public GameObject teamFlairObject; //Field offset: 0x78
	public GameObject inventoryObject; //Field offset: 0x80
	public Toggle teamStoreToggle; //Field offset: 0x88
	public Toggle inventoryToggle; //Field offset: 0x90
	public Toggle relicsTab; //Field offset: 0x98
	public Toggle teamFlairTab; //Field offset: 0xA0
	private TeamsStoreHeaderTab selectedHeaderTab; //Field offset: 0xA8
	private TeamsStoreShopTab selectedSubTab; //Field offset: 0xAC
	public GameObject bottomInfo; //Field offset: 0xB0
	public TMP_Text heading; //Field offset: 0xB8
	public TMP_Text description; //Field offset: 0xC0
	public Image icon; //Field offset: 0xC8
	public Button infoButton; //Field offset: 0xD0
	public Button bottomInfoFundButton; //Field offset: 0xD8
	public GameObject bottomInfoSelectButtonGroup; //Field offset: 0xE0
	public Button bottomInfoSelectButton; //Field offset: 0xE8
	public Button bottomInfoDeSelectButton; //Field offset: 0xF0
	public GameObject bottomInfoOwned; //Field offset: 0xF8
	public AudioClip clickSound; //Field offset: 0x100
	public AudioClip openSound; //Field offset: 0x108
	public AudioClip returnSound; //Field offset: 0x110
	public AudioClip selectSound; //Field offset: 0x118
	public AudioClip purchaseSound; //Field offset: 0x120
	public TMP_Text trophyCount; //Field offset: 0x128
	public TrophySpendPopup trophySpendPopup; //Field offset: 0x130
	public TeamsItemUnlockPopup unlockPopup; //Field offset: 0x138
	public GameObject nothingHereShop; //Field offset: 0x140
	public GameObject nothingHereInventory; //Field offset: 0x148
	public GameObject loadingGameObject; //Field offset: 0x150
	public GameObject firstTimeInfoPopup; //Field offset: 0x158
	public Lightbox firstTimeInfoBackgroundButton; //Field offset: 0x160
	public Button firstTimeInfoOkButton; //Field offset: 0x168
	public GameObject inventoryNewPip; //Field offset: 0x170
	private IReadOnlyCollection<ContestedTerritoryRelicType> capturedRelics; //Field offset: 0x178
	private readonly List<TeamsStoreUiDailyPanel> dailyUiPanels; //Field offset: 0x180
	private readonly List<TeamsStoreUiPanel> uiPanels; //Field offset: 0x188
	private readonly List<TeamsStoreUiPanel> inventoryUiPanels; //Field offset: 0x190
	private TeamsStoreUiPanelBase selectedUiPanel; //Field offset: 0x198
	private TeamsStoreShopTab lastSelectedShopTab; //Field offset: 0x1A0
	private CTEventData ctEventData; //Field offset: 0x1A8
	private Dictionary<String, TeamStoreItemContributions> itemContributions; //Field offset: 0x1B0
	private ContestedTerritoryRelicType[] currentCTRelics; //Field offset: 0x1B8

	private bool CanShowRelics
	{
		private get { } //Length: 189
	}

	private CtEvent CtEvent
	{
		private get { } //Length: 138
	}

	public static bool DebugShowAllItems
	{
		 get { } //Length: 3
	}

	private string GuildId
	{
		private get { } //Length: 139
	}

	private bool IsInGuild
	{
		private get { } //Length: 64
	}

	private HashSet<ContestedTerritoryRelicType> SeenRelics
	{
		private get { } //Length: 57
	}

	private HashSet<String> TeamsStoreSeen
	{
		private get { } //Length: 48
	}

	public TeamsStoreScreen() { }

	[CompilerGenerated]
	private void <Start>b__62_0() { }

	[CompilerGenerated]
	private void <Start>b__62_1() { }

	[CompilerGenerated]
	private void <Start>b__62_2(bool selected) { }

	[CompilerGenerated]
	private void <Start>b__62_3(bool selected) { }

	[CompilerGenerated]
	private void <Start>b__62_4(bool selected) { }

	[CompilerGenerated]
	private void <Start>b__62_5(bool selected) { }

	private void DisplaySelectButton(bool selected) { }

	private void GamepadUpdateSelectedGameObject() { }

	private bool get_CanShowRelics() { }

	private CtEvent get_CtEvent() { }

	public static bool get_DebugShowAllItems() { }

	private string get_GuildId() { }

	private bool get_IsInGuild() { }

	private HashSet<ContestedTerritoryRelicType> get_SeenRelics() { }

	private HashSet<String> get_TeamsStoreSeen() { }

	public TeamsStoreUiDailyPanel GetDailyPanelByContributionId(string id) { }

	public TeamsStoreUiDailyPanel GetDailyPanelById(string id) { }

	private GridLayoutGroup GetGridLayoutGroup(TeamsStoreShopTab teamsStoreShopTab) { }

	public TeamsStoreUiPanel GetInventoryPanelById(string id) { }

	public TeamsStoreUiPanel GetUiPanelById(string id) { }

	private bool HasMayorPermissions() { }

	private void OnFirstTimeInfoOkButton() { }

	private void OnHeaderTabClicked(TeamsStoreHeaderTab tab, bool selected) { }

	private void OnInfoButtonPressed() { }

	private void OnInfoPanelFundPressed() { }

	[AsyncStateMachine(typeof(<OnInfoPanelSelectPressedAsync>d__81))]
	public void OnInfoPanelSelectPressedAsync(bool unselect) { }

	public void OnPanelSelected(TeamsStoreUiPanelBase selection) { }

	[AsyncStateMachine(typeof(<OnSpendTrophies>d__84))]
	private void OnSpendTrophies(int trophies, string itemId) { }

	private void OnStoreTabClicked(TeamsStoreShopTab tab, bool selected) { }

	private void OnUnlockPanelBackPressed(TeamsStoreItem item) { }

	private void OnUnlockPanelGoPressed(TeamsStoreItem item) { }

	[AsyncStateMachine(typeof(<Open>d__63))]
	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<RefreshTeamTrophyBalance>d__65))]
	private Task RefreshTeamTrophyBalance() { }

	private void ShowInfoPanel() { }

	private void Sort(GridLayoutGroup layoutGroup) { }

	private int SortFunction(TeamsStoreUiPanel teamsStoreUiPanel) { }

	[AsyncStateMachine(typeof(<SpendTrophiesAsync>d__89))]
	private Task<ValueTuple`2<Int32, Int32>> SpendTrophiesAsync(int trophies, string itemId) { }

	public void Start() { }

	[AsyncStateMachine(typeof(<UpdateDailiesAsync>d__67))]
	private void UpdateDailiesAsync() { }

	private void UpdateInfoPanel() { }

	private void UpdateInventory(bool selectFirst) { }

	private void UpdateInventoryNewPip(bool canSaveSeen) { }

	private void UpdateSelectedRelicsDisplay() { }

	private void UpdateSubTabUIAsync(TeamsStoreShopTab selectedTab, bool selectFirst, bool canSaveSeen) { }

	private void ValidateSelectedRelics() { }

}

