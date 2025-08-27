namespace Assets.Scripts.Unity.UI_New.Achievements;

public class AchievementsScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ActiveAchievement, Boolean> <>9__12_1; //Field offset: 0x8
		public static Action<String> <>9__12_2; //Field offset: 0x10
		public static Func<ActiveAchievement, Boolean> <>9__20_0; //Field offset: 0x18
		public static Func<ActiveAchievement, Boolean> <>9__20_1; //Field offset: 0x20
		public static Func<ActiveAchievement, Single> <>9__20_2; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <GetSortedAchievements>b__20_0(ActiveAchievement x) { }

		internal bool <GetSortedAchievements>b__20_1(ActiveAchievement x) { }

		internal float <GetSortedAchievements>b__20_2(ActiveAchievement x) { }

		internal bool <Open>b__12_1(ActiveAchievement a) { }

		internal void <Open>b__12_2(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public IEnumerable<ActiveAchievement> achievements; //Field offset: 0x10

		public <>c__DisplayClass19_0() { }

		internal bool <LoadAchievementPanelsAsync>b__0(AchievementPanel ap) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public ActiveAchievement achievement; //Field offset: 0x10

		public <>c__DisplayClass19_1() { }

		internal bool <LoadAchievementPanelsAsync>b__1(AchievementPanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string searchString; //Field offset: 0x10
		public bool canShowHidden; //Field offset: 0x18

		public <>c__DisplayClass21_0() { }

		internal bool <FilterAchievements>b__0(ActiveAchievement a) { }

	}

	[CompilerGenerated]
	private struct <DisplayAchievementsAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AchievementsScreen <>4__this; //Field offset: 0x28
		public IEnumerable<ActiveAchievement> achievements; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GooglePlayClicked>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AchievementsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAchievementPanelsAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<ActiveAchievement> achievements; //Field offset: 0x20
		public AchievementsScreen <>4__this; //Field offset: 0x28
		private <>c__DisplayClass19_1 <>8__1; //Field offset: 0x30
		private int <displayCount>5__2; //Field offset: 0x38
		private int <count>5__3; //Field offset: 0x3C
		private IEnumerator<ActiveAchievement> <>7__wrap3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AchievementsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public AchievementPanel achievementPanelPrefab; //Field offset: 0x48
	public RectTransform container; //Field offset: 0x50
	public TMP_InputField searchField; //Field offset: 0x58
	public TMP_Text searchPlaceholder; //Field offset: 0x60
	public Button btnGooglePlay; //Field offset: 0x68
	public Button btnGamepadSearch; //Field offset: 0x70
	public GamepadInputField gamepadSearchInputField; //Field offset: 0x78
	public NK_TextMeshProUGUI achievementCountTxt; //Field offset: 0x80
	public GameObject nothingFoundObj; //Field offset: 0x88
	private ContentSizeFitter contentSizeFitter; //Field offset: 0x90
	private readonly List<AchievementPanel> achievementPanels; //Field offset: 0x98
	private CancellationTokenSource loadingToken; //Field offset: 0xA0
	private Task achievementLoadingTask; //Field offset: 0xA8
	private bool isClosed; //Field offset: 0xB0

	private List<ActiveAchievement> AllAchievements
	{
		private get { } //Length: 77
	}

	public AchievementsScreen() { }

	[CompilerGenerated]
	private void <Open>b__12_0() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<DisplayAchievementsAsync>d__18))]
	private void DisplayAchievementsAsync(IEnumerable<ActiveAchievement> achievements) { }

	private void FilterAchievements(string searchString) { }

	private void GamepadSelectFirst() { }

	private List<ActiveAchievement> get_AllAchievements() { }

	private IEnumerable<ActiveAchievement> GetSortedAchievements(IEnumerable<ActiveAchievement> achievements) { }

	[AsyncStateMachine(typeof(<GooglePlayClicked>d__25))]
	public void GooglePlayClicked() { }

	[AsyncStateMachine(typeof(<LoadAchievementPanelsAsync>d__19))]
	private Task LoadAchievementPanelsAsync(IEnumerable<ActiveAchievement> achievements) { }

	[AsyncStateMachine(typeof(<Open>d__12))]
	public virtual void Open(object data) { }

	public virtual void ReClose() { }

	public virtual void ReOpen(object data) { }

	private void UpdateAchievementCounter() { }

}

