namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorScreen : EditorPlayBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, String> <>9__53_0; //Field offset: 0x8
		public static Func<String, String> <>9__56_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <LoadDifficultyDropdown>b__53_0(string diff) { }

		internal string <LoadModeDropdown>b__56_0(string mode) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public MapEditorScreen <>4__this; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass57_0() { }

		internal void <OnDifficultyChanged>b__0() { }

		internal void <OnDifficultyChanged>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public MapEditorScreen <>4__this; //Field offset: 0x10
		public int index; //Field offset: 0x18

		public <>c__DisplayClass58_0() { }

		internal void <OnModeChanged>b__0() { }

		internal void <OnModeChanged>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public Action onChangeCancelled; //Field offset: 0x10
		public MapEditorScreen <>4__this; //Field offset: 0x18
		public Action onChangeConfirmed; //Field offset: 0x20

		public <>c__DisplayClass59_0() { }

		internal void <ChangeGameSettings>b__0() { }

		internal void <ChangeGameSettings>g__settingsChangeConfirmed|1() { }

	}

	[CompilerGenerated]
	private struct <LoadMapThumbnailAsync>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapModel CustomMapModel; //Field offset: 0x20
		public MapEditorScreen <>4__this; //Field offset: 0x28
		public string mapId; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<Texture2D> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnReportSuccess>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorScreen <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private string <mapId>5__2; //Field offset: 0x38
		private bool <canShowCurationInfo>5__3; //Field offset: 0x40
		private TaskAwaiter<CreatorModelWrapper`1<MapEditorCreatorModel>> <>u__1; //Field offset: 0x48
		private bool <hasNkValidation>5__4; //Field offset: 0x50
		private TaskAwaiter<IContentBrowserData> <>u__2; //Field offset: 0x58
		private TaskAwaiter<OnlineProfileModel> <>u__3; //Field offset: 0x60
		private NK_TextMeshProInputField <>7__wrap4; //Field offset: 0x68
		private TaskAwaiter<String> <>u__4; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMapNameAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string userInput; //Field offset: 0x28
		public MapEditorScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnContentReported : MulticastDelegate
	{

		public OnContentReported(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public Material grayscaleMaterial; //Field offset: 0x130
	public NK_TextMeshProInputField mapName; //Field offset: 0x138
	public Button editMapNameBtn; //Field offset: 0x140
	public Button editMapBtn; //Field offset: 0x148
	public Button clearMapBtn; //Field offset: 0x150
	public Button createInfoButton; //Field offset: 0x158
	public Button[] closeCreateInfoButtons; //Field offset: 0x160
	public GameObject gameSettingsPanel; //Field offset: 0x168
	public GameObject invalidPathFoundPanel; //Field offset: 0x170
	public GameObject creationInfoPopup; //Field offset: 0x178
	public TMP_Dropdown modeDropdown; //Field offset: 0x180
	public TMP_Dropdown difficultyDropdown; //Field offset: 0x188
	public SpriteReference defaultThumbnailImage; //Field offset: 0x190
	public ReportButton reportButton; //Field offset: 0x198
	public GameObject nkVerifiedContent; //Field offset: 0x1A0
	public MapReportPopup mapReportPopup; //Field offset: 0x1A8
	public AudioClip clickSound; //Field offset: 0x1B0
	[SerializeField]
	private Button myMapsButton; //Field offset: 0x1B8
	[SerializeField]
	private GameObject submissionPending; //Field offset: 0x1C0
	[SerializeField]
	private GameObject submissionRejected; //Field offset: 0x1C8
	[SerializeField]
	private GameObject submissionAutoAccepted; //Field offset: 0x1D0
	[SerializeField]
	private GameObject submissionHumanAccepted; //Field offset: 0x1D8
	private CreatorModelWrapper<MapEditorCreatorModel> modelWrapper; //Field offset: 0x1E0
	private MapEditorModel mapEditorModel; //Field offset: 0x1E8
	private CancellationTokenSource thumbnailCts; //Field offset: 0x1F0
	private bool showingCustomMapThumb; //Field offset: 0x1F8
	private List<String> difficulties; //Field offset: 0x200
	private int selectedDifficultyIndex; //Field offset: 0x208
	private List<String> modes; //Field offset: 0x210
	private int selectedModeIndex; //Field offset: 0x218

	protected virtual ContentType ContentType
	{
		 get { } //Length: 3
	}

	private PlayerContentInfo CreationContentInfo
	{
		private get { } //Length: 203
	}

	private bool IsCurationPlay
	{
		private get { } //Length: 106
	}

	protected virtual string PlayerCreationName
	{
		 get { } //Length: 30
	}

	private string SelectedDifficulty
	{
		private get { } //Length: 56
	}

	private string SelectedMode
	{
		private get { } //Length: 56
	}

	protected virtual IContentBrowserData SharableContentData
	{
		 get { } //Length: 8
	}

	public MapEditorScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[CompilerGenerated]
	private void <ClearCurrentMap>g__clearMapConfirmed|46_0() { }

	[CompilerGenerated]
	private Task <Open>b__37_0(RejectionReason rejectionReasons) { }

	[CompilerGenerated]
	private void <Open>b__37_1() { }

	[CompilerGenerated]
	private void <UpdateMapNameAsync>b__40_0() { }

	protected virtual void Awake() { }

	private void ChangeGameSettings(Action onChangeConfirmed, Action onChangeCancelled) { }

	private void ClearCurrentMap() { }

	public void ContinueClicked() { }

	protected virtual ContentType get_ContentType() { }

	private PlayerContentInfo get_CreationContentInfo() { }

	private bool get_IsCurationPlay() { }

	protected virtual string get_PlayerCreationName() { }

	private string get_SelectedDifficulty() { }

	private string get_SelectedMode() { }

	protected virtual IContentBrowserData get_SharableContentData() { }

	private void LoadDifficultyDropdown() { }

	[AsyncStateMachine(typeof(<LoadMapThumbnailAsync>d__39))]
	private Task LoadMapThumbnailAsync(string mapId, CustomMapModel CustomMapModel) { }

	private void LoadModeDropdown() { }

	private void MyMapsClicked() { }

	private void OnDestroy() { }

	private void OnDifficultyChanged(int index) { }

	private void OnEditMapClicked() { }

	private void OnModeChanged(int index) { }

	[AsyncStateMachine(typeof(<OnReportSuccess>d__38))]
	private void OnReportSuccess() { }

	[AsyncStateMachine(typeof(<Open>d__37))]
	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	protected virtual void StartNewGame() { }

	private void ToggleCreationInfoPopup() { }

	private void Update() { }

	[AsyncStateMachine(typeof(<UpdateMapNameAsync>d__40))]
	private void UpdateMapNameAsync(string userInput) { }

}

