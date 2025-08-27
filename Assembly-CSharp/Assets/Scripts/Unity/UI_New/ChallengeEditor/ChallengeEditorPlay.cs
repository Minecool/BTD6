namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeEditorPlay : EditorPlayBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public ChallengeModifierData mod; //Field offset: 0x10
		public GameObject newModifierObj; //Field offset: 0x40
		public ChallengeEditorPlay <>4__this; //Field offset: 0x48

		public <>c__DisplayClass30_0() { }

		internal void <ShowModIcons>b__0(BaseEventData _) { }

	}

	[CompilerGenerated]
	private struct <BindAsync>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ChallengeEditorPlay <>4__this; //Field offset: 0x28
		public DailyChallengeModel dcmToShow; //Field offset: 0x30
		public PlayerContentInfo playerContentInfo; //Field offset: 0x38
		private DailyChallengeModel <>7__wrap1; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ChallengeEditorPlay <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private LocalizationManager <locManager>5__2; //Field offset: 0x38
		private ProfileModel <playerData>5__3; //Field offset: 0x40
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class ProfanityFinish : MulticastDelegate
	{

		public ProfanityFinish(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool result) { }

	}

	public TMP_Text mapName; //Field offset: 0x130
	public TMP_Text difficulty; //Field offset: 0x138
	public GameObject towerDisplayPrefab; //Field offset: 0x140
	public GameObject selectedHeroDisplayPrefab; //Field offset: 0x148
	public Transform towerContainer; //Field offset: 0x150
	public ScrollRect towerScrollRect; //Field offset: 0x158
	public TMP_Text monkeysAvaliableTxt; //Field offset: 0x160
	public Color monkeysExcludedTxtColor; //Field offset: 0x168
	public GameObject maxTowerObject; //Field offset: 0x178
	public TMP_Text maxTowerTxt; //Field offset: 0x180
	public Transform modifierContent; //Field offset: 0x188
	public GameObject modifierPrefab; //Field offset: 0x190
	public ModIconTheme modTheme; //Field offset: 0x198
	public GameObject modifierInfo; //Field offset: 0x1A0
	private float modDownStartTime; //Field offset: 0x1A8
	private readonly float modPopupDelay; //Field offset: 0x1AC
	private int setScrollPosition; //Field offset: 0x1B0
	private readonly float playPopupDelay; //Field offset: 0x1B4
	private DailyChallengeModel dcm; //Field offset: 0x1B8

	protected virtual ContentType ContentType
	{
		 get { } //Length: 3
	}

	protected virtual string PlayerCreationName
	{
		 get { } //Length: 33
	}

	protected virtual IContentBrowserData SharableContentData
	{
		 get { } //Length: 8
	}

	public ChallengeEditorPlay() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[CompilerGenerated]
	private void <ShowModIcons>b__30_1(BaseEventData _) { }

	[AsyncStateMachine(typeof(<BindAsync>d__27))]
	private void BindAsync(DailyChallengeModel dcmToShow, PlayerContentInfo playerContentInfo) { }

	public void ContinueClicked() { }

	protected virtual ContentType get_ContentType() { }

	protected virtual string get_PlayerCreationName() { }

	protected virtual IContentBrowserData get_SharableContentData() { }

	protected virtual void ModChal() { }

	[AsyncStateMachine(typeof(<Open>d__26))]
	public virtual void Open(object data) { }

	private void SetSpecialConditionAutoSetValue() { }

	public void ShowChallengeRules() { }

	public void ShowModIcons() { }

	public void ShowTowers(DailyChallengeModel dcm) { }

	protected virtual void StartNewGame() { }

	private void Update() { }

}

