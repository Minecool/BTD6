namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class EditorPlayBase : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public EditorPlayBase <>4__this; //Field offset: 0x10
		public LocalizationManager loc; //Field offset: 0x18

		public <>c__DisplayClass62_0() { }

		internal void <ShareChallengeConfirmed>b__0(RequestResult result, string contentId, Exception exception) { }

	}

	[CompilerGenerated]
	private struct <OnCopyToClipboard>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject tick; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShareChallengeConfirmed>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EditorPlayBase <>4__this; //Field offset: 0x28
		private <>c__DisplayClass62_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text screenTitleTxt; //Field offset: 0x48
	public Button continueBtn; //Field offset: 0x50
	public Button playBtn; //Field offset: 0x58
	public Image mapImage; //Field offset: 0x60
	public Image difficultyImage; //Field offset: 0x68
	public SpriteReference[] difficultySprites; //Field offset: 0x70
	public GameObject createModeObj; //Field offset: 0x78
	public Button modChalBtn; //Field offset: 0x80
	public GameObject playModeObj; //Field offset: 0x88
	public Button shareBtn; //Field offset: 0x90
	public GameObject shareLockedMessagePanel; //Field offset: 0x98
	public GameObject shareTimerPanelObj; //Field offset: 0xA0
	public TMP_Text shareTimerTxt; //Field offset: 0xA8
	public TMP_Text shareLockedPopupDescTxt; //Field offset: 0xB0
	public GameObject sharedObj; //Field offset: 0xB8
	public TMP_Text sharedChalCode; //Field offset: 0xC0
	public Button createSocialShareBtn; //Field offset: 0xC8
	public GameObject createCopyCodeTick; //Field offset: 0xD0
	public GameObject sharingLoadingSpinner; //Field offset: 0xD8
	public PlayerContentInfoPanel playerContentInfoPanel; //Field offset: 0xE0
	protected PlayerContent playerContent; //Field offset: 0xE8
	public AccoladesDisplayButton accoladesDisplay; //Field offset: 0xF0
	protected MapSaveDataModel mapSaveData; //Field offset: 0xF8
	protected bool isCreationMode; //Field offset: 0x100
	protected bool isMenuLoaded; //Field offset: 0x101
	protected bool isMenuClosed; //Field offset: 0x102
	protected bool locked; //Field offset: 0x103
	protected float playDownStartTime; //Field offset: 0x104
	public GameObject lockedMessagePanel; //Field offset: 0x108
	private bool isSharring; //Field offset: 0x110
	private bool canShare; //Field offset: 0x111
	[CompilerGenerated]
	private readonly IContentBrowserData <SharableContentData>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private readonly string <PlayerCreationName>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private readonly ContentType <ContentType>k__BackingField; //Field offset: 0x128

	protected ChallengeType ChallengeType
	{
		 get { } //Length: 166
	}

	protected override ContentType ContentType
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected override string PlayerCreationName
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	protected override IContentBrowserData SharableContentData
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private string SubmittedContentId
	{
		private get { } //Length: 309
		private set { } //Length: 330
	}

	public EditorPlayBase() { }

	[CompilerGenerated]
	private void <Awake>b__45_0() { }

	[CompilerGenerated]
	private void <Awake>b__45_1() { }

	[CompilerGenerated]
	private void <Play>b__52_0() { }

	[CompilerGenerated]
	private void <Play>b__52_1() { }

	protected virtual void Awake() { }

	protected void CheckOldVersionPopupThenNewGame() { }

	public virtual void Close() { }

	protected ChallengeType get_ChallengeType() { }

	[CompilerGenerated]
	protected override ContentType get_ContentType() { }

	[CompilerGenerated]
	protected override string get_PlayerCreationName() { }

	[CompilerGenerated]
	protected override IContentBrowserData get_SharableContentData() { }

	private string get_SubmittedContentId() { }

	protected SpriteReference GetDifficultySprite(string difficulty) { }

	private string GetShareAgainLockTxt() { }

	private string GetSharedLockTxt() { }

	protected override void ModChal() { }

	[AsyncStateMachine(typeof(<OnCopyToClipboard>d__47))]
	private void OnCopyToClipboard(GameObject tick) { }

	private void OnPlayBtnDown(BaseEventData ed) { }

	private void OnPlayBtnUp(BaseEventData ed) { }

	private void OnShareBtnDown(BaseEventData ed) { }

	private void OnShareBtnUp(BaseEventData ed) { }

	public virtual bool OverrideClose() { }

	protected void Play() { }

	protected void RemoveCurrentChalSave() { }

	private void set_SubmittedContentId(string value) { }

	[AsyncStateMachine(typeof(<ShareChallengeConfirmed>d__62))]
	private void ShareChallengeConfirmed() { }

	public void ShareClicked() { }

	protected override void StartNewGame() { }

	public void UpdateSharedStatus() { }

}

