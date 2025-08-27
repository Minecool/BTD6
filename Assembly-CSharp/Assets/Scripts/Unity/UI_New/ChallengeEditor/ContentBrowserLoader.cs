namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ContentBrowserLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ContentBrowserPanel, Boolean> <>9__16_0; //Field offset: 0x8
		public static Func<PlayerContentInfo, String> <>9__29_0; //Field offset: 0x10
		public static Func<MapDetails, String> <>9__37_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal string <get_MapIds>b__37_0(MapDetails x) { }

		internal string <RunLoadAndDisplay>b__29_0(PlayerContentInfo pci) { }

		internal bool <set_IsLoading>b__16_0(ContentBrowserPanel cp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public string searchString; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal bool <TryGetMatchingMapId>b__0(string id) { }

	}

	[CompilerGenerated]
	private struct <CancelRunningTasks>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowserLoader <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetContentWithId>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PlayerContent> <>t__builder; //Field offset: 0x8
		public ContentBrowserLoader <>4__this; //Field offset: 0x20
		public string playerContentId; //Field offset: 0x28
		public ContentType contentType; //Field offset: 0x30
		private TaskAwaiter<PlayerContentCurationInfo> <>u__1; //Field offset: 0x38
		private TaskAwaiter<PlayerContentInfo> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAndDisplayContent>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowserLoader <>4__this; //Field offset: 0x28
		public RequestCompleted callOnFinish; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunContentSearch>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string searchInput; //Field offset: 0x20
		public ContentBrowserLoader <>4__this; //Field offset: 0x28
		public ContentType contentType; //Field offset: 0x30
		public Func<PlayerContentInfo, Boolean> canShowContent; //Field offset: 0x38
		public Action<ContentBrowserQuery> setQueryParameters; //Field offset: 0x40
		public int maxPanels; //Field offset: 0x48
		public RequestCompleted callOnFinish; //Field offset: 0x50
		private string <searchString>5__2; //Field offset: 0x58
		private RectTransform <panelContainer>5__3; //Field offset: 0x60
		private YieldAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter<PlayerContent> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunLoadAndDisplay>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isCustomSearch; //Field offset: 0x20
		public ContentBrowserLoader <>4__this; //Field offset: 0x28
		public RequestCompleted callOnFinish; //Field offset: 0x30
		private IEnumerable<PlayerContentInfo> <playerContentInfos>5__2; //Field offset: 0x38
		private int <totalResults>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x44
		private TaskAwaiter<ContentCurationListResponse> <>u__2; //Field offset: 0x48
		private TaskAwaiter<PlayerContentSearchResult> <>u__3; //Field offset: 0x50
		private TaskAwaiter <>u__4; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SearchContent>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowserLoader <>4__this; //Field offset: 0x28
		public string searchString; //Field offset: 0x30
		public ContentType contentType; //Field offset: 0x38
		public int maxPanels; //Field offset: 0x3C
		public Func<PlayerContentInfo, Boolean> canShowContent; //Field offset: 0x40
		public Action<ContentBrowserQuery> setQueryParameters; //Field offset: 0x48
		public RequestCompleted callOnFinish; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class RequestCompleted : MulticastDelegate
	{

		public RequestCompleted(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RequestResult result, Exception exception, string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RequestResult result, Exception exception = null, string message = null) { }

	}

	private static readonly Regex alphaStringRegex; //Field offset: 0x0
	private readonly BrowserBase browser; //Field offset: 0x10
	private CancellationTokenSource loadingToken; //Field offset: 0x18
	private CancellationTokenSource searchToken; //Field offset: 0x20
	private Task loadingTask; //Field offset: 0x28
	private Task searchTask; //Field offset: 0x30
	[CompilerGenerated]
	private ContentBrowserDisplayInfo <DisplayInfo>k__BackingField; //Field offset: 0x38
	private DateTime lastLoadTime; //Field offset: 0x40
	private DateTime lastSearchTime; //Field offset: 0x48
	private IEnumerable<String> _mapIds; //Field offset: 0x50

	private ContentBrowserSettings ContentBrowserDisplaySettings
	{
		private get { } //Length: 150
	}

	public private ContentBrowserDisplayInfo DisplayInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private bool IsClosed
	{
		private get { } //Length: 125
	}

	private bool IsLoading
	{
		private set { } //Length: 485
	}

	private IEnumerable<String> MapIds
	{
		private get { } //Length: 356
	}

	private static ContentBrowserLoader() { }

	public ContentBrowserLoader(BrowserBase browser, ContentBrowserDisplayInfo displayInfo) { }

	[AsyncStateMachine(typeof(<CancelRunningTasks>d__17))]
	private Task CancelRunningTasks() { }

	public void CloneAndSetDisplayInfo(ContentBrowserDisplayInfo displayInfo) { }

	private ContentBrowserSettings get_ContentBrowserDisplaySettings() { }

	[CompilerGenerated]
	public ContentBrowserDisplayInfo get_DisplayInfo() { }

	private bool get_IsClosed() { }

	private IEnumerable<String> get_MapIds() { }

	[AsyncStateMachine(typeof(<GetContentWithId>d__33))]
	public Task<PlayerContent> GetContentWithId(string playerContentId, ContentType contentType) { }

	private int GetTotalPagesToDisplay(int availablePages) { }

	public static bool IsValidContentId(string text) { }

	[AsyncStateMachine(typeof(<LoadAndDisplayContent>d__24))]
	public void LoadAndDisplayContent(RequestCompleted callOnFinish) { }

	public void LoadAndDisplayContent(ContentBrowserQuery query, ElasticQueryOptions options, string hint, RequestCompleted callOnFinish, WinRateDisplayType winRateDisplayType, int maxPanels, int maxPages, IEnumerable<String> contentIds = null, bool canShowDeletedContent = false) { }

	public void LoadAndDisplayFirstPage(RequestCompleted callOnFinish) { }

	public void LoadAndDisplayLastPage(RequestCompleted callOnFinish) { }

	public void LoadAndDisplayNextPage(RequestCompleted callOnFinish) { }

	public void LoadAndDisplayPreviousPage(RequestCompleted callOnFinish) { }

	public void LoadEmptyPage() { }

	public void ResetTotalPages() { }

	[AsyncStateMachine(typeof(<RunContentSearch>d__32))]
	private Task RunContentSearch(string searchInput, ContentType contentType, int maxPanels, Func<PlayerContentInfo, Boolean> canShowContent, Action<ContentBrowserQuery> setQueryParameters, RequestCompleted callOnFinish) { }

	[AsyncStateMachine(typeof(<RunLoadAndDisplay>d__29))]
	private Task RunLoadAndDisplay(RequestCompleted callOnFinish, bool isCustomSearch = false) { }

	[AsyncStateMachine(typeof(<SearchContent>d__27))]
	public void SearchContent(string searchString, ContentType contentType, int maxPanels, Func<PlayerContentInfo, Boolean> canShowContent, Action<ContentBrowserQuery> setQueryParameters, RequestCompleted callOnFinish) { }

	[CompilerGenerated]
	private void set_DisplayInfo(ContentBrowserDisplayInfo value) { }

	private void set_IsLoading(bool value) { }

	private void SetPageButtons() { }

	private bool TryGetMatchingMapId(string searchString, out string mapId) { }

}

