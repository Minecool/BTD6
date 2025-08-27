namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ContentBrowserPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Boolean> <>9__55_0; //Field offset: 0x8
		public static Action <>9__55_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__55_0(bool <p0>) { }

		internal void <.ctor>b__55_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public ContentType contentType; //Field offset: 0x10
		public string contentId; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

		internal bool <RefreshAccolades>b__0(AccoladeTransaction x) { }

	}

	[CompilerGenerated]
	private struct <LoadChallengeName>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerContentInfo info; //Field offset: 0x20
		public ContentBrowserPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadNameAndAvatar>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowserPanel <>4__this; //Field offset: 0x20
		private Task<Btd6PlayerStats> <playerStatsTask>5__2; //Field offset: 0x28
		private Btd6PlayerStats <playerStats>5__3; //Field offset: 0x30
		private TaskAwaiter<String> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Btd6PlayerStats> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayClicked>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContentBrowserPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<IContentBrowserData> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject currVersionObj; //Field offset: 0x20
	public GameObject oldVersionObj; //Field offset: 0x28
	public Image mapImg; //Field offset: 0x30
	public TMP_Text chalNameTxt; //Field offset: 0x38
	public Image avatarImg; //Field offset: 0x40
	public Image bannerImg; //Field offset: 0x48
	public Image verifiedAccountImg; //Field offset: 0x50
	public Image followingImg; //Field offset: 0x58
	public TMP_Text authorNameTxt; //Field offset: 0x60
	public Toggle likeTgl; //Field offset: 0x68
	public TMP_Text ratingCountTxt; //Field offset: 0x70
	public Toggle winPercTgl; //Field offset: 0x78
	public TMP_Text winPercTxt; //Field offset: 0x80
	public Toggle favouriteTgl; //Field offset: 0x88
	public Image completedImg; //Field offset: 0x90
	public ChallengeBrowserPanelPlayButton playBtn; //Field offset: 0x98
	public Button deleteBtn; //Field offset: 0xA0
	public AccoladeDisplay accoladesDisplay; //Field offset: 0xA8
	public GameObject featuredObj; //Field offset: 0xB0
	public PlayerContent playerContent; //Field offset: 0xB8
	protected BrowserBase browser; //Field offset: 0xC0
	private bool isDeleted; //Field offset: 0xC8
	[CompilerGenerated]
	private Action<Boolean> LoadingChallengeEvent; //Field offset: 0xD0
	[CompilerGenerated]
	private Action SaveOnExit; //Field offset: 0xD8

	public event Action<Boolean> LoadingChallengeEvent
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action SaveOnExit
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private ContentTypeSaveData ContentBrowserData
	{
		private get { } //Length: 126
	}

	protected ContentType ContentType
	{
		 get { } //Length: 39
	}

	public bool HasPlayedChallenge
	{
		 get { } //Length: 214
	}

	public bool HasSavedProgress
	{
		 get { } //Length: 146
	}

	public ContentBrowserPanel() { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_LoadingChallengeEvent(Action<Boolean> value) { }

	[CompilerGenerated]
	public void add_SaveOnExit(Action value) { }

	protected override void Awake() { }

	private void DeleteClicked() { }

	private void DeleteContent() { }

	private void DeleteSave() { }

	private void FavouriteToggled(bool value) { }

	private ContentTypeSaveData get_ContentBrowserData() { }

	protected ContentType get_ContentType() { }

	public bool get_HasPlayedChallenge() { }

	public bool get_HasSavedProgress() { }

	public override void Init(PlayerContent playerContent, BrowserBase browser) { }

	public bool IsAccoladeIconShowingOnScreen(RectTransform scrollTransform) { }

	[AsyncStateMachine(typeof(<LoadChallengeName>d__36))]
	protected Task LoadChallengeName(PlayerContentInfo info) { }

	[AsyncStateMachine(typeof(<LoadNameAndAvatar>d__37))]
	protected Task LoadNameAndAvatar() { }

	public override void OpenPlayScene(IContentBrowserData data) { }

	[AsyncStateMachine(typeof(<PlayClicked>d__45))]
	protected override void PlayClicked() { }

	private void RefreshAccolades(ContentType contentType, string contentId, Accolade[] accolades) { }

	[CompilerGenerated]
	public void remove_LoadingChallengeEvent(Action<Boolean> value) { }

	[CompilerGenerated]
	public void remove_SaveOnExit(Action value) { }

	private void ResetDeleteButtonState() { }

	public void ResetFavoriteState() { }

	public void ResetLikeState() { }

	public override void ResetPlayButtonState() { }

	protected void SetMap() { }

	public void ToggleWinPercTxt(bool isAttempts) { }

}

