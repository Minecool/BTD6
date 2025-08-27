namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ContentBrowser : BrowserBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Task, Boolean> <>9__61_0; //Field offset: 0x8
		public static Func<Task, Boolean> <>9__61_1; //Field offset: 0x10
		public static Func<Task, AggregateException> <>9__61_2; //Field offset: 0x18
		public static Func<ContentBrowserPanel, Boolean> <>9__62_0; //Field offset: 0x20
		public static Func<BaseSaveDataModel, String> <>9__82_0; //Field offset: 0x28
		public static Func<ContentBrowserPanel, Boolean> <>9__108_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <GetActivePanels>b__108_0(ContentBrowserPanel panel) { }

		internal bool <ReOpen>b__62_0(ContentBrowserPanel cp) { }

		internal bool <RunLoadingTasksInParallel>b__61_0(Task x) { }

		internal bool <RunLoadingTasksInParallel>b__61_1(Task t) { }

		internal AggregateException <RunLoadingTasksInParallel>b__61_2(Task t) { }

		internal string <ShowSaved>b__82_0(BaseSaveDataModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public List<String> seenFeaturedIds; //Field offset: 0x10

		public <>c__DisplayClass126_0() { }

		internal bool <DisplayPlayerContents>b__0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public ContentType contentType; //Field offset: 0x10
		public ContentBrowser <>4__this; //Field offset: 0x18

		public <>c__DisplayClass53_0() { }

		internal void <Start>b__1(bool isEnabled) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public string latestCreatedId; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal bool <ReOpen>b__1(ContentBrowserPanel cp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public KeyValuePair<String, List`1<DirtyStatus>> dirtyChallengeIdStatuses; //Field offset: 0x10

		public <>c__DisplayClass64_0() { }

		internal bool <RefreshDirtyChallenges>b__0(ContentBrowserPanel cp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public string inputString; //Field offset: 0x10

		public <>c__DisplayClass94_0() { }

		internal bool <OnSearchStrChanged>b__0(string deepLinkUrl) { }

		internal bool <OnSearchStrChanged>b__1(string shareString) { }

	}

	[CompilerGenerated]
	private struct <DownloadAndDisplayContent>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string contentId; //Field offset: 0x20
		public ContentBrowser <>4__this; //Field offset: 0x28
		private TaskAwaiter<PlayerContentInfo> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetLatestCreatedIds>d__63 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ContentBrowser <>4__this; //Field offset: 0x28
		private IEnumerator<String> <>7__wrap1; //Field offset: 0x30

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <GetLatestCreatedIds>d__63(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <OnClickContinueAsync>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowser <>4__this; //Field offset: 0x20
		private PlayerContentInfo <playerContentInfo>5__2; //Field offset: 0x28
		private TaskAwaiter<PlayerContentInfo> <>u__1; //Field offset: 0x30
		private PlayerContent <playerContent>5__3; //Field offset: 0x38
		private TaskAwaiter<IContentBrowserData> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowser <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunLoadingTasksInParallel>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowser <>4__this; //Field offset: 0x20
		private Task[] <loadingTasks>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunSearch>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowser <>4__this; //Field offset: 0x28
		public string inputString; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetCurationButtonAsync>d__118 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowser <>4__this; //Field offset: 0x28
		private TaskAwaiter<CurationInfoResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowser <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForInternetAndRefresh>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowser <>4__this; //Field offset: 0x20
		public object data; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<DateTime> <>u__2; //Field offset: 0x38
		private TaskAwaiter <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static bool <JumpToMyMaps>k__BackingField; //Field offset: 0x0
	private static readonly ContentType[] ContentTypes; //Field offset: 0x8
	private static Task<CurationInfoResponse> curationInfoResponseTask; //Field offset: 0x10
	private static CurationInfoResponse curationInfoResponse; //Field offset: 0x18
	[CompilerGenerated]
	private static readonly List<String> <RecentlyDeletedContentIds>k__BackingField; //Field offset: 0x20
	[SerializeField]
	private Toggle challengeTog; //Field offset: 0x118
	[SerializeField]
	private Toggle odysseyTog; //Field offset: 0x120
	[SerializeField]
	private Toggle mapTog; //Field offset: 0x128
	[SerializeField]
	private Toggle gameTog; //Field offset: 0x130
	[SerializeField]
	private TMP_Dropdown flavorDropdown; //Field offset: 0x138
	[SerializeField]
	private Button continueBtn; //Field offset: 0x140
	[SerializeField]
	private Button createBtn; //Field offset: 0x148
	[SerializeField]
	private GameObject createBtnDisabledObj; //Field offset: 0x150
	[SerializeField]
	private Image createBtnIcon; //Field offset: 0x158
	[SerializeField]
	private SpriteReference[] createBtnIconSprites; //Field offset: 0x160
	[SerializeField]
	private GameObject gamePanelTemplate; //Field offset: 0x168
	[SerializeField]
	private GameObject mapPanelTemplate; //Field offset: 0x170
	[SerializeField]
	private GameObject chalPanelTemplate; //Field offset: 0x178
	[SerializeField]
	private GameObject odysseyPanelTemplate; //Field offset: 0x180
	[SerializeField]
	private Button advancedSearchBtn; //Field offset: 0x188
	[SerializeField]
	public ChallengeBrowserSearchPanel advancedSearchPanel; //Field offset: 0x190
	[SerializeField]
	private Button gamepadToggleFilterModeBtn; //Field offset: 0x198
	[SerializeField]
	private Button mapCurationBtn; //Field offset: 0x1A0
	[SerializeField]
	private AccoladeNotificationButton accoladeNotifBtn; //Field offset: 0x1A8
	[SerializeField]
	private AccoladesNotificationPanel accoladesNotificationPanel; //Field offset: 0x1B0
	[SerializeField]
	private Image featuredStar; //Field offset: 0x1B8
	private string continueBtnContentId; //Field offset: 0x1C0
	private bool gamepadFilterMode; //Field offset: 0x1C8
	private bool hasBeenOpened; //Field offset: 0x1C9
	private List<SelectionType> _selectionTypes; //Field offset: 0x1D0
	private SelectionType previousSelection; //Field offset: 0x1D8
	private bool requiresRefresh; //Field offset: 0x1DC

	private static ContentBrowserServerSettings BrowserServerSettings
	{
		private get { } //Length: 138
	}

	private static ContentBrowserSettings BrowserSettings
	{
		private get { } //Length: 150
	}

	public static bool CanOpenBrowser
	{
		 get { } //Length: 179
	}

	private ContentTypeSettings ContentTypeSettings
	{
		private get { } //Length: 171
	}

	public SelectionType CurrentSelectionType
	{
		 get { } //Length: 95
	}

	private ChallengeBrowserTabSettings CurrentTabSettings
	{
		private get { } //Length: 139
	}

	private bool HasCuration
	{
		private get { } //Length: 30
	}

	private bool HasCustomDropdown
	{
		private get { } //Length: 118
	}

	public static bool IsAdmin
	{
		 get { } //Length: 93
	}

	public static bool IsCurator
	{
		 get { } //Length: 93
	}

	private bool IsOnline
	{
		private get { } //Length: 7
	}

	public static bool JumpToMyMaps
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		 set { } //Length: 83
	}

	public static List<String> RecentlyDeletedContentIds
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	public private ContentType SelectedTab
	{
		 get { } //Length: 560
		private set { } //Length: 251
	}

	public List<SelectionType> SelectionTypes
	{
		 get { } //Length: 379
	}

	private static ContentBrowser() { }

	public ContentBrowser() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__1(object data) { }

	[CompilerGenerated]
	private bool <get_SelectionTypes>b__39_0(SelectionType selectionType) { }

	[CompilerGenerated]
	private void <SetCurationButtonAsync>b__118_0() { }

	[CompilerGenerated]
	private bool <ShowFavorite>b__80_0(string x) { }

	[CompilerGenerated]
	private bool <ShowPlayed>b__81_0(string x) { }

	[CompilerGenerated]
	private bool <ShowSaved>b__82_1(string x) { }

	[CompilerGenerated]
	private void <Start>b__53_0() { }

	private static void AddMaxToQuery(ContentBrowserQuery query, List<String> queryScripts, string variableName, int maxValue) { }

	private static void AddMinToQuery(ContentBrowserQuery query, List<String> queryScripts, string variableName, int minValue) { }

	protected virtual void Awake() { }

	protected virtual bool CanDisplayContentId(PlayerContentInfo playerContentInfo) { }

	private bool CanShowSearchContentInfo(PlayerContentInfo playerContentInfo) { }

	public virtual void Close() { }

	public virtual void DisplayPlayerContents(IEnumerable<PlayerContentInfo> playerContentInfos, DisplayPosition displayPosition = 1) { }

	[AsyncStateMachine(typeof(<DownloadAndDisplayContent>d__66))]
	private Task DownloadAndDisplayContent(string contentId) { }

	private void GamepadSelectFirst() { }

	private void GamepadToggleFilterMode() { }

	protected virtual void GamepadUpdateNav() { }

	private static ContentBrowserServerSettings get_BrowserServerSettings() { }

	private static ContentBrowserSettings get_BrowserSettings() { }

	public static bool get_CanOpenBrowser() { }

	private ContentTypeSettings get_ContentTypeSettings() { }

	public SelectionType get_CurrentSelectionType() { }

	private ChallengeBrowserTabSettings get_CurrentTabSettings() { }

	private bool get_HasCuration() { }

	private bool get_HasCustomDropdown() { }

	public static bool get_IsAdmin() { }

	public static bool get_IsCurator() { }

	private bool get_IsOnline() { }

	[CompilerGenerated]
	public static bool get_JumpToMyMaps() { }

	[CompilerGenerated]
	public static List<String> get_RecentlyDeletedContentIds() { }

	public ContentType get_SelectedTab() { }

	public List<SelectionType> get_SelectionTypes() { }

	private IEnumerable<ContentBrowserPanel> GetActivePanels() { }

	private SelectionType GetDefaultPage(ContentType contentType) { }

	public static string GetEditorSceneName(ContentType contentType) { }

	private static ContentFilterLevel GetFilterLevel(bool isCodeSearch) { }

	[IteratorStateMachine(typeof(<GetLatestCreatedIds>d__63))]
	private IEnumerable<String> GetLatestCreatedIds() { }

	protected virtual GameObject GetPanelTemplate(PlayerContentInfo info) { }

	public static string GetPlaySceneName(ContentType contentType) { }

	private RichPresenceBrowsing GetRichPresenceType() { }

	private Toggle GetToggle(ContentType contentType) { }

	private static int GetValidAvailabilityScore(ContentFilterLevel filterLevel) { }

	public static bool IsEnabledOnSKU(ContentType contentType) { }

	private void LoadChallengesWithIds(IEnumerable<String> challengeIds, string hint, TabSettings tabSettings) { }

	private void OnClickContinue() { }

	[AsyncStateMachine(typeof(<OnClickContinueAsync>d__89))]
	private Task OnClickContinueAsync() { }

	private void OnClickCreate() { }

	public void OnClickTab(ContentType tab) { }

	private void OnDestroy() { }

	private void OnDropdownChanged(int selectionTypeInt) { }

	private void OnOnlineProfileRefreshed() { }

	protected virtual void OnSearchStrChanged(string inputString) { }

	[AsyncStateMachine(typeof(<Open>d__58))]
	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	public virtual void ReClose() { }

	protected virtual void RefreshBrowser() { }

	private void RefreshDirtyChallenges() { }

	private void RefreshPanel(ContentBrowserPanel dirtyPanel, List<DirtyStatus> dirtyStatuses) { }

	public virtual void ReOpen(object data) { }

	[AsyncStateMachine(typeof(<RunLoadingTasksInParallel>d__61))]
	private Task RunLoadingTasksInParallel() { }

	[AsyncStateMachine(typeof(<RunSearch>d__95))]
	protected virtual void RunSearch(string inputString) { }

	[CompilerGenerated]
	public static void set_JumpToMyMaps(bool value) { }

	private void set_SelectedTab(ContentType value) { }

	[AsyncStateMachine(typeof(<SetCurationButtonAsync>d__118))]
	private void SetCurationButtonAsync() { }

	private void SetFlavorDropdownValues(ContentType contentType) { }

	private void SetQueryCurationFilters(ContentBrowserQuery query) { }

	private void SetQueryFilters(ContentBrowserQuery query, TabSettings tabSettings, bool requiresMinPlaysCheck = false) { }

	public virtual void SetSearchView(bool isSearching) { }

	private void SetSeenMapBrowser() { }

	private void ShowCasual() { }

	private void ShowChallenges(SelectionType selectionType) { }

	public void ShowChallenges() { }

	private void ShowExpert() { }

	private void ShowFavorite() { }

	private void ShowFeatured() { }

	private void ShowFollowing() { }

	private void ShowMostLiked() { }

	private void ShowMyChallenges() { }

	private void ShowNewest() { }

	private void ShowPlayed() { }

	private void ShowSaved() { }

	private void ShowTrending() { }

	[AsyncStateMachine(typeof(<Start>d__53))]
	protected virtual void Start() { }

	private void ToggleAccoladeNotif() { }

	private void UpdateContinueButton() { }

	[AsyncStateMachine(typeof(<WaitForInternetAndRefresh>d__60))]
	public Task WaitForInternetAndRefresh(object data) { }

}

