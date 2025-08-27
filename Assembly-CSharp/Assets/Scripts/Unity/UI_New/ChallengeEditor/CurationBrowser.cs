namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class CurationBrowser : BrowserBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ContentBrowserPanel, Boolean> <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ReOpen>b__18_0(ContentBrowserPanel cp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public string contentId; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <ShowInfoPanel>b__0(ContentBrowserPanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string inputString; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <OnSearchStrChanged>b__0(string deepLinkUrl) { }

		internal bool <OnSearchStrChanged>b__1(string shareString) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public PlayerContentInfo playerContentInfo; //Field offset: 0x10
		public CurationBrowser <>4__this; //Field offset: 0x18

		public <>c__DisplayClass24_0() { }

		internal Task <ValidateContent>b__0(RejectionReason _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public PlayerContentInfo playerContentInfo; //Field offset: 0x10
		public CurationBrowser <>4__this; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal Task <RejectContent>b__0(RejectionReason rejectionReason) { }

	}

	[CompilerGenerated]
	private struct <ShowInfoPanel>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string contentId; //Field offset: 0x20
		public CurationBrowser <>4__this; //Field offset: 0x28
		private TaskAwaiter<PlayerContent> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class MenuOpenInfo
	{
		[CompilerGenerated]
		private readonly ContentType <ContentType>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private readonly ContentBrowserDisplayInfo <DisplayInfo>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private readonly string <InfoTabMapId>k__BackingField; //Field offset: 0x20

		public ContentType ContentType
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public ContentBrowserDisplayInfo DisplayInfo
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public string InfoTabMapId
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public MenuOpenInfo(ContentType contentType, ContentBrowserDisplayInfo displayInfo, string contentId) { }

		[CompilerGenerated]
		public ContentType get_ContentType() { }

		[CompilerGenerated]
		public ContentBrowserDisplayInfo get_DisplayInfo() { }

		[CompilerGenerated]
		public string get_InfoTabMapId() { }

	}

	[SerializeField]
	private GameObject mapCurationPanelTemplate; //Field offset: 0x118
	[SerializeField]
	private GameObject gameCurationPanelTemplate; //Field offset: 0x120
	[SerializeField]
	private MapValidatePopup mapValidatePopup; //Field offset: 0x128
	[SerializeField]
	private MapRejectPopup mapRejectPopup; //Field offset: 0x130
	[SerializeField]
	private CurationMapInfoPanel curationMapInfoPanel; //Field offset: 0x138
	[SerializeField]
	private Toggle hideCuratedToggle; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI totalCuratedTxt; //Field offset: 0x148
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x150
	private bool hasBeenOpened; //Field offset: 0x158
	[CompilerGenerated]
	private ContentType <ContentType>k__BackingField; //Field offset: 0x159

	public private ContentType ContentType
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public CurationBrowser() { }

	[CompilerGenerated]
	private void <Awake>b__14_0(bool _) { }

	protected virtual void Awake() { }

	protected virtual bool CanDisplayContentId(PlayerContentInfo playerContentInfo) { }

	public virtual void Close() { }

	[CompilerGenerated]
	public ContentType get_ContentType() { }

	protected virtual GameObject GetPanelTemplate(PlayerContentInfo info) { }

	protected virtual void OnSearchStrChanged(string inputString) { }

	public virtual void Open(object data) { }

	public void OpenInfoPanel(PlayerContent playerContent) { }

	public virtual bool OverrideClose() { }

	protected virtual void RefreshBrowser() { }

	public void RejectContent(PlayerContentInfo playerContentInfo) { }

	public virtual void ReOpen(object data) { }

	protected virtual void RunSearch(string inputString) { }

	[CompilerGenerated]
	private void set_ContentType(ContentType value) { }

	[AsyncStateMachine(typeof(<ShowInfoPanel>d__17))]
	public Task ShowInfoPanel(string contentId) { }

	protected virtual void Start() { }

	public void ValidateContent(PlayerContentInfo playerContentInfo) { }

}

