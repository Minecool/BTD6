namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class CurationMapInfoPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapEditorAreaData, Boolean> <>9__55_0; //Field offset: 0x8
		public static Func<MapEditorAreaData, Boolean> <>9__55_1; //Field offset: 0x10
		public static Func<MapEditorAreaData, Boolean> <>9__55_2; //Field offset: 0x18
		public static Func<MapEditorAreaData, Boolean> <>9__55_4; //Field offset: 0x20
		public static Func<MapEditorAreaData, IEnumerable`1<LayerData>> <>9__55_5; //Field offset: 0x28
		public static Func<MapEditorAreaData, Boolean> <>9__55_6; //Field offset: 0x30
		public static Func<MapEditorAreaData, IEnumerable`1<LayerData>> <>9__55_7; //Field offset: 0x38
		public static Func<MapEditorAreaData, Boolean> <>9__55_8; //Field offset: 0x40
		public static Func<MapEditorAreaData, IEnumerable`1<LayerData>> <>9__55_9; //Field offset: 0x48
		public static Func<CurationVote, Boolean> <>9__66_0; //Field offset: 0x50
		public static Func<ReportInfo, Boolean> <>9__66_1; //Field offset: 0x58
		public static Func<Object, DateTime> <>9__66_2; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal bool <LoadCurationInfoPanel>b__66_0(CurationVote x) { }

		internal bool <LoadCurationInfoPanel>b__66_1(ReportInfo x) { }

		internal DateTime <LoadCurationInfoPanel>b__66_2(object obj) { }

		internal bool <LoadMapThumbnailAsync>b__55_0(MapEditorAreaData x) { }

		internal bool <LoadMapThumbnailAsync>b__55_1(MapEditorAreaData x) { }

		internal bool <LoadMapThumbnailAsync>b__55_2(MapEditorAreaData areaData) { }

		internal bool <LoadMapThumbnailAsync>b__55_4(MapEditorAreaData areaData) { }

		internal IEnumerable<LayerData> <LoadMapThumbnailAsync>b__55_5(MapEditorAreaData areaData) { }

		internal bool <LoadMapThumbnailAsync>b__55_6(MapEditorAreaData areaData) { }

		internal IEnumerable<LayerData> <LoadMapThumbnailAsync>b__55_7(MapEditorAreaData areaData) { }

		internal bool <LoadMapThumbnailAsync>b__55_8(MapEditorAreaData areaData) { }

		internal IEnumerable<LayerData> <LoadMapThumbnailAsync>b__55_9(MapEditorAreaData areaData) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public CurationBrowser curationBrowser; //Field offset: 0x10
		public PlayerContent playerContent; //Field offset: 0x18
		public CurationMapInfoPanel <>4__this; //Field offset: 0x20
		public OnSharedToClipboard <>9__4; //Field offset: 0x28

		public <>c__DisplayClass54_0() { }

		internal void <Load>b__0() { }

		internal void <Load>b__1() { }

		internal void <Load>b__2() { }

		internal void <Load>b__3() { }

		internal void <Load>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public RejectionReason rejectionReason; //Field offset: 0x10

		public <>c__DisplayClass69_0() { }

		internal bool <GetReportDisplayCount>b__0(ReportInfo x) { }

	}

	[CompilerGenerated]
	private struct <LoadMapThumbnailAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CurationMapInfoPanel <>4__this; //Field offset: 0x20
		public PlayerContent playerContent; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private LocalizationManager <locs>5__3; //Field offset: 0x38
		private TaskAwaiter<IContentBrowserData> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadThumbAreas>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapModel customMapModel; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public CurationMapInfoPanel <>4__this; //Field offset: 0x30
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadThumbBase>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapModel customMapModel; //Field offset: 0x20
		public CurationMapInfoPanel <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadThumbPaths>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapModel customMapModel; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public CurationMapInfoPanel <>4__this; //Field offset: 0x30
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

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

	[SerializeField]
	private Selectable[] closeButtons; //Field offset: 0x20
	[SerializeField]
	private Button validateButton; //Field offset: 0x28
	[SerializeField]
	private Button rejectButton; //Field offset: 0x30
	[SerializeField]
	private Button playButton; //Field offset: 0x38
	[SerializeField]
	private Image mapLoadingSpinner; //Field offset: 0x40
	[SerializeField]
	private Image mapImg; //Field offset: 0x48
	[SerializeField]
	private Image hiddenAreas; //Field offset: 0x50
	[SerializeField]
	private Image hiddenPaths; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI totalReportsTxt; //Field offset: 0x60
	[SerializeField]
	private NK_TextMeshProUGUI offensiveVisualsTxt; //Field offset: 0x68
	[SerializeField]
	private NK_TextMeshProUGUI offensiveLanguageTxt; //Field offset: 0x70
	[SerializeField]
	private NK_TextMeshProUGUI offensiveHiddenAreasTxt; //Field offset: 0x78
	[SerializeField]
	private NK_TextMeshProUGUI offensiveInteractablesTxt; //Field offset: 0x80
	[SerializeField]
	private NK_TextMeshProUGUI mapCodeTxt; //Field offset: 0x88
	[SerializeField]
	private NK_TextMeshProUGUI rejectButtonTxt; //Field offset: 0x90
	[SerializeField]
	private GameObject curationVoteInfoTemplate; //Field offset: 0x98
	[SerializeField]
	private RectTransform curationVoteInfoContainer; //Field offset: 0xA0
	[SerializeField]
	private Button shareCodeButton; //Field offset: 0xA8
	[SerializeField]
	private GameObject codeSharedTick; //Field offset: 0xB0
	[SerializeField]
	private Toggle highlightPathsToggle; //Field offset: 0xB8
	[SerializeField]
	private Toggle showHiddenAreasToggle; //Field offset: 0xC0
	[SerializeField]
	private NK_TextMeshProUGUI showHiddenAreasTxt; //Field offset: 0xC8
	[SerializeField]
	private NK_TextMeshProUGUI likesTxt; //Field offset: 0xD0
	[SerializeField]
	private Toggle winrateToggle; //Field offset: 0xD8
	[SerializeField]
	private NK_TextMeshProUGUI winRateTxt; //Field offset: 0xE0
	[SerializeField]
	private HoverableInfoPopup winPercHoverableZone; //Field offset: 0xE8
	[SerializeField]
	private NK_TextMeshProUGUI uniquePlayerCountTxt; //Field offset: 0xF0
	[SerializeField]
	private HoverableInfoPopup validateDisabledHoverableZone; //Field offset: 0xF8
	[SerializeField]
	private Button statsButton; //Field offset: 0x100
	[SerializeField]
	private GameObject adminValidatedTag; //Field offset: 0x108
	[SerializeField]
	private GameObject contentDeletedTag; //Field offset: 0x110
	[SerializeField]
	private NK_TextMeshProUGUI mapNameText; //Field offset: 0x118
	[SerializeField]
	private Toggle favouriteTgl; //Field offset: 0x120
	[SerializeField]
	private NK_TextMeshProUGUI interactablePropsText; //Field offset: 0x128
	[SerializeField]
	private NK_TextMeshProUGUI removableAreasText; //Field offset: 0x130
	public PlayerContentStatsPanel playerContentStatsPanel; //Field offset: 0x138
	private readonly List<CurationVoteInfo> curationVoteInfos; //Field offset: 0x140
	private int curationVoteInfosAssignedIndex; //Field offset: 0x148
	[CompilerGenerated]
	private bool <IsRunningConfirmation>k__BackingField; //Field offset: 0x14C
	private PlayerContent playerContent; //Field offset: 0x150
	private PlayerContentCurationInfo playerContentCurationInfo; //Field offset: 0x158
	private bool hasSeenPaths; //Field offset: 0x160
	private bool hasSeenHiddenAreas; //Field offset: 0x161
	private bool hasHiddenAreas; //Field offset: 0x162
	private bool hasRemovableAreas; //Field offset: 0x163
	private bool hasInteractableProps; //Field offset: 0x164
	private CancellationTokenSource thumbnailCts; //Field offset: 0x168

	public string ContentId
	{
		 get { } //Length: 29
	}

	private bool IsEnabled
	{
		private get { } //Length: 113
	}

	public internal bool IsRunningConfirmation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	public CurationMapInfoPanel() { }

	[CompilerGenerated]
	private void <Awake>b__52_0() { }

	[CompilerGenerated]
	private void <Awake>b__52_1() { }

	[CompilerGenerated]
	internal static bool <LoadMapThumbnailAsync>g__isInteractableLayer|55_3(LayerData layerData) { }

	private void Awake() { }

	private void FavouriteToggled(bool isFavorite) { }

	public string get_ContentId() { }

	private bool get_IsEnabled() { }

	[CompilerGenerated]
	public bool get_IsRunningConfirmation() { }

	private CurationVoteInfo GetCurationVoteInfoLine() { }

	private static string GetReportDisplayCount(PlayerContentCurationInfo playerContentCurationInfo, RejectionReason rejectionReason) { }

	private void HighlightPathToggleChanged(bool isOn) { }

	public void Load(PlayerContent playerContent, CurationBrowser curationBrowser) { }

	private void LoadCurationInfoPanel() { }

	[AsyncStateMachine(typeof(<LoadMapThumbnailAsync>d__55))]
	private Task LoadMapThumbnailAsync(PlayerContent playerContent) { }

	[AsyncStateMachine(typeof(<LoadThumbAreas>d__57))]
	private Task LoadThumbAreas(CustomMapModel customMapModel, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<LoadThumbBase>d__56))]
	private Task LoadThumbBase(CustomMapModel customMapModel, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<LoadThumbPaths>d__58))]
	private Task LoadThumbPaths(CustomMapModel customMapModel, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<OnCopyToClipboard>d__61))]
	private void OnCopyToClipboard(GameObject tick) { }

	private void OnDisable() { }

	[CompilerGenerated]
	internal void set_IsRunningConfirmation(bool value) { }

	private void SetWinRateDisplay(bool isAttempts) { }

	private void ShowHiddenAreasToggleChanged(bool isOn) { }

	private void ToggleStatsPopup() { }

}

