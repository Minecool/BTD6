namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public abstract class BrowserBase : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ContentType, String> <>9__74_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__74_0(ContentType contentType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public string playerContentId; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal bool <DisplayPlayerContents>b__0(PlayerContentInfo ci) { }

	}

	[CompilerGenerated]
	private struct <LoopAccoladeIconAnimationAsync>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BrowserBase <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static float accoladeIconLoopTime; //Field offset: 0x0
	public const int kMaxConcurrentMapLoads = 1; //Field offset: 0x0
	public static int accoladeIconsPerLoop; //Field offset: 0x4
	public NK_TextMeshProInputField searchField; //Field offset: 0x48
	public TMP_Text searchPlaceholder; //Field offset: 0x50
	public Image searchingImg; //Field offset: 0x58
	public GameObject foundNothingObj; //Field offset: 0x60
	public GameObject requiresInternetObj; //Field offset: 0x68
	public GameObject screenClickBlocker; //Field offset: 0x70
	public Button refreshBtn; //Field offset: 0x78
	public Button firstPageBtn; //Field offset: 0x80
	public Button previousPageBtn; //Field offset: 0x88
	public TMP_Text currentPageTxt; //Field offset: 0x90
	public Button nextPageBtn; //Field offset: 0x98
	public Button lastPageBtn; //Field offset: 0xA0
	[SerializeField]
	private ScrollRect scrollRect; //Field offset: 0xA8
	[SerializeField]
	private RectTransform verticalLayoutGroup; //Field offset: 0xB0
	[SerializeField]
	private RectTransform gridLayoutGroup; //Field offset: 0xB8
	private RectTransform scrollRectTransform; //Field offset: 0xC0
	public readonly List<ContentBrowserPanel> panels; //Field offset: 0xC8
	[CompilerGenerated]
	private bool <IsClosed>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <IsInBackground>k__BackingField; //Field offset: 0xD1
	protected ContentBrowserLoader loader; //Field offset: 0xD8
	protected bool requiresSave; //Field offset: 0xE0
	protected ContentBrowserDisplayInfo previousDisplayInfo; //Field offset: 0xE8
	protected string searchString; //Field offset: 0xF0
	private String[] _shareStrings; //Field offset: 0xF8
	protected readonly String[] deepLinkUrls; //Field offset: 0x100
	[CompilerGenerated]
	private int <ConcurrentMapLoadCount>k__BackingField; //Field offset: 0x108
	protected int totalPages; //Field offset: 0x10C
	protected bool isApplicationPaused; //Field offset: 0x110

	public int ConcurrentMapLoadCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsClosed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsInBackground
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	protected String[] ShareStrings
	{
		 get { } //Length: 277
	}

	private static BrowserBase() { }

	protected BrowserBase() { }

	[CompilerGenerated]
	private bool <LoopAccoladeIconAnimationAsync>b__50_0(ContentBrowserPanel panel) { }

	protected abstract bool CanDisplayContentId(PlayerContentInfo playerContentInfo) { }

	public void ClearPanels() { }

	public virtual void Close() { }

	public ContentBrowserPanel CreatePanel(PlayerContent playerContent, Transform parent) { }

	public void DisplayPlayerContent(PlayerContentInfo playerContentInfo, DisplayPosition displayPosition = 1) { }

	public override void DisplayPlayerContents(IEnumerable<PlayerContentInfo> playerContentInfos, DisplayPosition displayPosition = 1) { }

	protected override void GamepadUpdateNav() { }

	[CompilerGenerated]
	public int get_ConcurrentMapLoadCount() { }

	[CompilerGenerated]
	public bool get_IsClosed() { }

	[CompilerGenerated]
	public bool get_IsInBackground() { }

	protected String[] get_ShareStrings() { }

	public RectTransform GetLayoutGroup(ContentType contentType) { }

	protected abstract GameObject GetPanelTemplate(PlayerContentInfo playerContentInfo) { }

	protected static string GetSearchPlaceHolderTxt(ContentType contentType) { }

	[AsyncStateMachine(typeof(<LoopAccoladeIconAnimationAsync>d__50))]
	private Task LoopAccoladeIconAnimationAsync() { }

	public void OnApplicationPause(bool isApplicationPaused) { }

	public void OnApplicationQuit() { }

	public void OnChallengeLoading(bool isLoadingChallenge) { }

	private void OnClickFirstPage() { }

	private void OnClickLastPage() { }

	private void OnClickNextPage() { }

	private void OnClickPreviousPage() { }

	public static void OnRequestFinished(RequestResult requestResult, Exception exception, string message = "") { }

	protected abstract void OnSearchStrChanged(string searchString) { }

	protected void OnSubmitSearch(string searchString) { }

	public virtual void Open(object data) { }

	public virtual void ReClose() { }

	protected abstract void RefreshBrowser() { }

	public virtual void ReOpen(object data) { }

	protected abstract void RunSearch(string inputString) { }

	protected void SaveOnExit() { }

	[CompilerGenerated]
	public void set_ConcurrentMapLoadCount(int value) { }

	[CompilerGenerated]
	protected void set_IsClosed(bool value) { }

	[CompilerGenerated]
	protected void set_IsInBackground(bool value) { }

	public void SetCurrentPage(int currentPage) { }

	public void SetPagination(int totalPages, int currentPage) { }

	public override void SetSearchView(bool isSearching) { }

	protected override void Start() { }

	protected static bool TryGetContentIdFromShareString(string shareString, ContentType contentType, out string contentId) { }

}

