namespace Assets.Scripts.Unity.UI_New.Quests;

public class QuestBrowserScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<QuestPanel> <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <SortQuests>b__14_0(QuestPanel a, QuestPanel b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public QuestDetails questdata; //Field offset: 0x10
		public QuestBrowserScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <CreateQuestPanel>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public TabButton tab; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <OnTabCategoryClicked>b__0(QuestPanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public QuestDetails tutorialQuest; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <SortQuests>b__1(QuestPanel q) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public TabButton tabCategory; //Field offset: 0x10
		public QuestBrowserScreen <>4__this; //Field offset: 0x30

		public <>c__DisplayClass8_0() { }

		internal void <Awake>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadUI>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestBrowserScreen <>4__this; //Field offset: 0x28
		public QuestCategory previousCategory; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct TabButton
	{
		public QuestCategory questCategory; //Field offset: 0x0
		public Button tabBtn; //Field offset: 0x8
		public GameObject activeObj; //Field offset: 0x10
		public GameObject pipObj; //Field offset: 0x18

	}

	public static QuestBrowserScreen instance; //Field offset: 0x0
	public Transform panelTransform; //Field offset: 0x48
	public PrefabReference questPanelPrefab; //Field offset: 0x50
	public TabButton[] tabs; //Field offset: 0x58
	public Button debugResetAllQuestSaveDataBtn; //Field offset: 0x60
	public AudioClip tabSound; //Field offset: 0x68
	private List<QuestPanel> questPanelList; //Field offset: 0x70
	private QuestCategory selectedQuestCategory; //Field offset: 0x78

	public QuestBrowserScreen() { }

	protected virtual void Awake() { }

	private void ClearUI() { }

	private Task CreateQuestPanel(QuestDetails questdata) { }

	[AsyncStateMachine(typeof(<LoadUI>d__10))]
	private void LoadUI(QuestCategory previousCategory = -1) { }

	public void OnGoReplayClicked(QuestDetails questDetails) { }

	private void OnTabCategoryClicked(QuestCategory questCategoryClicked, bool justLoaded = false) { }

	public virtual void Open(object data) { }

	private void SortQuests(QuestCategory questCategoryClicked) { }

}

