namespace Assets.Scripts.Unity.UI_New.TrophyStore;

public class TrophyStoreScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TrophyItemPanel, Boolean> <>9__71_2; //Field offset: 0x8
		public static Func<TrophyItemPanel, Boolean> <>9__82_0; //Field offset: 0x10
		public static Func<TrophyItemPanel, Boolean> <>9__95_0; //Field offset: 0x18
		public static Func<TrophyItemPanel, Boolean> <>9__95_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <DisplayFilteredSubs>b__95_0(TrophyItemPanel x) { }

		internal bool <DisplayFilteredSubs>b__95_1(TrophyItemPanel x) { }

		internal bool <DisplayTabItems>b__82_0(TrophyItemPanel x) { }

		internal bool <SortPanels>b__71_2(TrophyItemPanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public TrophyStoreScreen <>4__this; //Field offset: 0x10
		public List<TrophyStoreFilter> orderedFilters; //Field offset: 0x18

		public <>c__DisplayClass56_0() { }

		internal void <Start>b__0(bool selected) { }

		internal void <Start>b__1(bool selected) { }

		internal void <Start>b__10() { }

		internal void <Start>b__11() { }

		internal void <Start>b__12() { }

		internal void <Start>b__13(GameObject obj) { }

		internal void <Start>b__2(bool selected) { }

		internal void <Start>b__3(bool selected) { }

		internal void <Start>b__4(bool selected) { }

		internal void <Start>b__5(bool selected) { }

		internal void <Start>b__6(bool selected) { }

		internal void <Start>b__7() { }

		internal void <Start>b__8() { }

		internal void <Start>b__9() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_1
	{
		public GameObject obj; //Field offset: 0x10

		public <>c__DisplayClass56_1() { }

		internal bool <Start>b__14(TrophyItemPanel p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public bool isPurchased; //Field offset: 0x10
		public TrophyStoreItem trophyStoreItem; //Field offset: 0x18
		public bool isLimitedTime; //Field offset: 0x20
		public TrophyStoreScreen <>4__this; //Field offset: 0x28
		public TrophyItemPanel trophyItemPanel; //Field offset: 0x30

		public <>c__DisplayClass69_0() { }

		internal void <InstantiateItem>b__1() { }

		internal bool <InstantiateItem>b__2(string x) { }

		internal bool <InstantiateItem>b__3(string x) { }

		internal bool <InstantiateItem>g__isVisible|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public TrophyStoreScreen <>4__this; //Field offset: 0x10
		public TrophyStoreFilter tabFilter; //Field offset: 0x18
		public TrophyItemSubFilter subFilter; //Field offset: 0x1C

		public <>c__DisplayClass89_0() { }

		internal void <CreateSubFilterButton>b__0(bool selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public TrophyStoreFilterButton subToggle; //Field offset: 0x10

		public <>c__DisplayClass90_0() { }

		internal bool <DisplaySubFiltersForTab>b__0(TrophyItemSubFilter x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public AsyncOperationHandle<GameObject> handle; //Field offset: 0x10

		public <>c__DisplayClass96_0() { }

		internal void <BeginPurchaseItem>b__0() { }

	}

	[CompilerGenerated]
	private struct <CheckForTrophyItemChangesAndUpdate>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public TrophyStoreScreen <>4__this; //Field offset: 0x30
		private bool <wasPurchasedBefore>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitTrophyStore>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TrophyStoreScreen <>4__this; //Field offset: 0x20
		public TrophyStoreItem itemToDisplay; //Field offset: 0x28
		private IEnumerator<TrophyStoreItem> <>7__wrap1; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TrophyStoreScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Purchase>d__106 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TrophyItemPanel item; //Field offset: 0x20
		public TrophyStoreScreen <>4__this; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private TrophyStoreItem <storeItem>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Setup>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TrophyStoreScreen <>4__this; //Field offset: 0x20
		private TrophyStoreItem <itemToDisplay>5__2; //Field offset: 0x28
		private TaskAwaiter<TrophyStoreBankData> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncTrophyCountWithLiNKAsync>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TrophyStoreScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryPurchase>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TrophyStoreScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class TrophyStoreFilterData
	{
		public TrophyStoreFilter trophyStoreTab; //Field offset: 0x10
		public List<TrophyItemSubFilter> trophyStoreFilters; //Field offset: 0x18

		public TrophyStoreFilterData() { }

	}

	private const int kPanelsToLoadPerFrame = 5; //Field offset: 0x0
	private const string SaleIdPostfix = "_sale"; //Field offset: 0x0
	public TrophyItemPanel trophyPrefab; //Field offset: 0x48
	public RectTransform scrollContainer; //Field offset: 0x50
	public ScrollRect scrollRect; //Field offset: 0x58
	public Toggle trophyStoreToggle; //Field offset: 0x60
	public Toggle inventoryToggle; //Field offset: 0x68
	public Toggle featuredTab; //Field offset: 0x70
	public Toggle heroesTab; //Field offset: 0x78
	public Toggle monkeysTab; //Field offset: 0x80
	public Toggle bloonsTab; //Field offset: 0x88
	public Toggle coopTab; //Field offset: 0x90
	public Toggle gameuiTab; //Field offset: 0x98
	public Toggle inventoryTab; //Field offset: 0xA0
	public GameObject bottomInfo; //Field offset: 0xA8
	public TMP_Text heading; //Field offset: 0xB0
	public TMP_Text description; //Field offset: 0xB8
	public TMP_Text price; //Field offset: 0xC0
	public TMP_Text emoteIconText; //Field offset: 0xC8
	public Image icon; //Field offset: 0xD0
	public Button purchaseButton; //Field offset: 0xD8
	public Button questButton; //Field offset: 0xE0
	public Button enableButton; //Field offset: 0xE8
	public Button infoButton; //Field offset: 0xF0
	public TMP_Text questButtonTxt; //Field offset: 0xF8
	public GameObject enableTick; //Field offset: 0x100
	public GameObject purchasedObj; //Field offset: 0x108
	public GameObject subFiltersObject; //Field offset: 0x110
	public GameObject subFilterButtonPrefab; //Field offset: 0x118
	public ToggleGroup subFiltersToggleGroup; //Field offset: 0x120
	private readonly List<TrophyStoreFilterButton> subFiltersToggles; //Field offset: 0x128
	public List<TrophyStoreFilterData> trophyStoreFilterData; //Field offset: 0x130
	public AudioClip clickSound; //Field offset: 0x138
	public AudioClip openSound; //Field offset: 0x140
	public AudioClip returnSound; //Field offset: 0x148
	public AudioClip selectSound; //Field offset: 0x150
	public AudioClip purchaseSound; //Field offset: 0x158
	public AudioPreviewModule audioPreviewModule; //Field offset: 0x160
	public TMP_Text trophyCount; //Field offset: 0x168
	private readonly List<TrophyItemPanel> trophyItemPanels; //Field offset: 0x170
	private TrophyItemPanel selectedPanel; //Field offset: 0x178
	private TrophyStoreFilter selectedTab; //Field offset: 0x180
	private TrophyItemSubFilter selectedSubFilter; //Field offset: 0x184
	private Dictionary<String, TrophyStoreBankItem> onlineBankItems; //Field offset: 0x188
	[CompilerGenerated]
	private bool <InInventory>k__BackingField; //Field offset: 0x190
	public Button prevTabBtn; //Field offset: 0x198
	public Button nextTabBtn; //Field offset: 0x1A0
	public Button prevSubTabBtn; //Field offset: 0x1A8
	public Button nextSubTabBtn; //Field offset: 0x1B0
	public Button toggleModeBtn; //Field offset: 0x1B8
	public GameObject nothingFoundObj; //Field offset: 0x1C0
	private TrophyStoreScreenData screenData; //Field offset: 0x1C8
	private readonly List<String> featuredIds; //Field offset: 0x1D0
	private readonly List<String> onSaleIds; //Field offset: 0x1D8
	private readonly Dictionary<String, DateTime> itemSaleEndTimes; //Field offset: 0x1E0
	private bool isInit; //Field offset: 0x1E8
	private TrophyItemPanel purchasingItem; //Field offset: 0x1F0
	private bool isPurchasing; //Field offset: 0x1F8

	private bool InInventory
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsPurchasing
	{
		private get { } //Length: 8
		private set { } //Length: 107
	}

	private static TrophyStoreSKU TrophyStoreSku
	{
		private get { } //Length: 138
	}

	public TrophyStoreScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[CompilerGenerated]
	private void <Setup>b__60_0() { }

	[CompilerGenerated]
	internal static bool <SortPanels>g__isLimitedTimeAndNew|71_1(TrophyItemPanel panel) { }

	[CompilerGenerated]
	internal static bool <SortPanels>g__isLimitedTimeAndNotNew|71_0(TrophyItemPanel panel) { }

	private void BeginPurchaseItem() { }

	[AsyncStateMachine(typeof(<CheckForTrophyItemChangesAndUpdate>d__97))]
	public void CheckForTrophyItemChangesAndUpdate(object data) { }

	public virtual void Close() { }

	private void CreateSubFilterButton(TrophyStoreFilter tabFilter, TrophyItemSubFilter subFilter) { }

	private void CreateSubFilterButtons() { }

	private void DisplayFilteredSubs(TrophyStoreFilter tabFilter, TrophyItemSubFilter subFilter) { }

	private void DisplaySubFiltersForTab(TrophyStoreFilter tabFilter) { }

	private void DisplayTabItems(TrophyStoreFilter trophyItemFilter) { }

	private void EnableDisableItem() { }

	private void EnableTrophyItem(TrophyItemPanel item) { }

	private void GamepadUpdateSelectedGameObject() { }

	[CompilerGenerated]
	private bool get_InInventory() { }

	private bool get_IsPurchasing() { }

	private static TrophyStoreSKU get_TrophyStoreSku() { }

	private Toggle GetFilterToggle(TrophyStoreFilter tabSelected) { }

	private int GetSelectedSubIndex(IList<Selectable> selectables) { }

	private List<TrophyItemSubFilter> GetSubFiltersForTab(TrophyStoreFilter tabFilter) { }

	private TrophyItemPanel GetTrophyItemPanel(TrophyStoreItem trophyStoreItem) { }

	private void GoToQuestScreen() { }

	[AsyncStateMachine(typeof(<InitTrophyStore>d__66))]
	public Task InitTrophyStore(TrophyStoreItem itemToDisplay = null) { }

	private void InstantiateItem(TrophyStoreItem trophyStoreItem, Dictionary<String, TrophyStoreSD> purchasedItems) { }

	private bool IsActive(TrophyItemPanel trophyPanel, TrophyStoreFilter trophyItemFilter) { }

	private void OnMainToggleChanged(bool isInventory) { }

	public void OnTabClicked(TrophyStoreFilter trophyItemFilter, bool isSelected) { }

	[AsyncStateMachine(typeof(<Open>d__59))]
	public virtual void Open(object data) { }

	private void PreviewMusic() { }

	[AsyncStateMachine(typeof(<Purchase>d__106))]
	private Task Purchase(TrophyItemPanel item) { }

	private void PurchaseComplete() { }

	private void RefreshBottomBar() { }

	private void RefreshTrophyStore() { }

	public virtual void ReOpen(object data) { }

	private void ResetScrollPosition() { }

	private void ResumeMenuMusic() { }

	public void ScrollToBottom() { }

	private void SelectFirstPanel() { }

	public void SelectPanel(TrophyItemPanel itemPanel) { }

	[CompilerGenerated]
	private void set_InInventory(bool value) { }

	private void set_IsPurchasing(bool value) { }

	private void SetActiveSubFilter(TrophyItemSubFilter subFilter) { }

	[AsyncStateMachine(typeof(<Setup>d__60))]
	private Task Setup() { }

	private void ShowInfoPanel() { }

	private void ShowItemsForSubFilter(TrophyStoreFilter tabFilter, TrophyItemSubFilter subFilter) { }

	private void ShowItemsForTab(TrophyStoreFilter trophyItemFilter, TrophyItemSubFilter subFilter = 0) { }

	private void SortPanels() { }

	private Task SpendTrophies(Btd6Player player, TrophyItemPanel item) { }

	public void Start() { }

	private void SubFilterToggleClicked(TrophyStoreFilter tabFilter, TrophyItemSubFilter subFilter, bool selected) { }

	[AsyncStateMachine(typeof(<SyncTrophyCountWithLiNKAsync>d__73))]
	private void SyncTrophyCountWithLiNKAsync() { }

	public void TrophyStoreItemClicked(TrophyItemPanel trophyStorePanel) { }

	[AsyncStateMachine(typeof(<TryPurchase>d__105))]
	private void TryPurchase() { }

	public void Update() { }

	private void UpdateTrophyCount() { }

}

