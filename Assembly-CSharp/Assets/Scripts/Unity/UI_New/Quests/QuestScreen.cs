namespace Assets.Scripts.Unity.UI_New.Quests;

public class QuestScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<AsyncOperationHandle`1<GameObject>> <>9__96_0; //Field offset: 0x8
		public static Func<LegendsType, String> <>9__102_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <LoadUI>b__96_0(AsyncOperationHandle<GameObject> h) { }

		internal string <SetStoreButton>b__102_0(LegendsType legendsType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass111_0
	{
		public QuestScreen <>4__this; //Field offset: 0x10
		public bool continueSave; //Field offset: 0x18

		public <>c__DisplayClass111_0() { }

		internal void <OnClickPlay>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass116_0
	{
		public QuestScreen <>4__this; //Field offset: 0x10
		public DialogueData dialogueData; //Field offset: 0x18
		public int taskIndex; //Field offset: 0x20

		public <>c__DisplayClass116_0() { }

		internal void <CheckForQuestDialogue>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public QuestScreen <>4__this; //Field offset: 0x10
		public int count; //Field offset: 0x18
		public Action<AsyncOperationHandle`1<GameObject>> <>9__2; //Field offset: 0x20

		public <>c__DisplayClass96_0() { }

		internal void <LoadUI>b__1(AsyncOperationHandle<GameObject> h) { }

		internal void <LoadUI>b__2(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_0
	{
		public QuestScreen <>4__this; //Field offset: 0x10
		public TaskData task; //Field offset: 0x18
		public int index; //Field offset: 0x20

		public <>c__DisplayClass97_0() { }

		internal void <CreateTaskPanel>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <CheckForQuestDialogue>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPreviousEventRewards>d__107 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestScreen <>4__this; //Field offset: 0x20
		private QuestEvent <pendingRewards>5__2; //Field offset: 0x28
		private TaskAwaiter<QuestEvent> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadUI>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestScreen <>4__this; //Field offset: 0x28
		private float <percentProgress>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickClaim>d__126 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestScreen <>4__this; //Field offset: 0x28
		private bool <hasAvailableHolidayEventSpecificRewards>5__2; //Field offset: 0x30
		private bool <hasClaimedHolidayRewards>5__3; //Field offset: 0x31
		private LootSet <holidayLootSet>5__4; //Field offset: 0x38
		private bool <hasClaimedBaseLootset>5__5; //Field offset: 0x40
		private LootSet <uiLootSet>5__6; //Field offset: 0x48
		private bool <hasTowerUnlock>5__7; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public QuestScreen <>4__this; //Field offset: 0x30
		private Task <previousEventTask>5__2; //Field offset: 0x38
		private TaskAwaiter<QuestDataModel> <>u__1; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReOpen>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public QuestScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnSetSelectedQuestPartClicked : MulticastDelegate
	{

		public OnSetSelectedQuestPartClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(QuestPartButton taskPanel, int index, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(QuestPartButton taskPanel, int index) { }

	}

	internal sealed class OnSetSelectedTaskClicked : MulticastDelegate
	{

		public OnSetSelectedTaskClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TaskPanel taskPanel, TaskData taskData, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TaskPanel taskPanel, TaskData taskData) { }

	}

	protected const int openStateQuestCompleted = 4; //Field offset: 0x0
	protected const int openStateQuestCompletedChestOpened = 6; //Field offset: 0x0
	protected const int openStateQuestCompletedShowChest = 5; //Field offset: 0x0
	public Transform worldParent; //Field offset: 0x48
	public Animator titleAnimator; //Field offset: 0x50
	public Animator doorAnimator; //Field offset: 0x58
	public Transform titleParent; //Field offset: 0x60
	public GameObject genericTitle; //Field offset: 0x68
	public NK_TextMeshProUGUI genericTitleTxt; //Field offset: 0x70
	public NK_TextMeshProUGUI rewardDescTxt; //Field offset: 0x78
	public TMP_Text timeRemainingTxt; //Field offset: 0x80
	public Button playBtn; //Field offset: 0x88
	public Button restartBtn; //Field offset: 0x90
	public Button replayTaskBtn; //Field offset: 0x98
	public Button claimBtn; //Field offset: 0xA0
	public Button continueBtn; //Field offset: 0xA8
	public Button infoOpenBtn; //Field offset: 0xB0
	public Button openChestBtn; //Field offset: 0xB8
	public NK_TextMeshProUGUI playBtnTxt; //Field offset: 0xC0
	public PrefabReference questPanelPrefab; //Field offset: 0xC8
	public PrefabReference questLargePanelPrefab; //Field offset: 0xD0
	public PrefabReference questPartButtonPrefab; //Field offset: 0xD8
	public Transform questPanelTransform; //Field offset: 0xE0
	public Transform questPartPanelTransform; //Field offset: 0xE8
	public GameObject questCompletedTitlesPanel; //Field offset: 0xF0
	public GameObject specialLootPanelObj; //Field offset: 0xF8
	public LootPanel specialLoot; //Field offset: 0x100
	public GameObject specialRewardsClaimedPanel; //Field offset: 0x108
	public GameObject genericLootPanelObj; //Field offset: 0x110
	public LootPanel genericLoot; //Field offset: 0x118
	public GameObject genericRewardsClaimedPanel; //Field offset: 0x120
	public GameObject largeQuestPanel; //Field offset: 0x128
	public Transform largeQuestTransform; //Field offset: 0x130
	public GameObject multiQuestPanel; //Field offset: 0x138
	public Image fillBar; //Field offset: 0x140
	public ScrollRect taskScrollRect; //Field offset: 0x148
	public GameObject disableDialoguePanel; //Field offset: 0x150
	public Toggle disableDialogueToggle; //Field offset: 0x158
	public GameObject infoPanel; //Field offset: 0x160
	public Lightbox infoBackgroundCloseBtn; //Field offset: 0x168
	public Button infoOkBtn; //Field offset: 0x170
	public Animator infoAnimator; //Field offset: 0x178
	public Button storeButton; //Field offset: 0x180
	public NK_TextMeshProUGUI storeButtonTxt; //Field offset: 0x188
	public AudioClip click2Sound; //Field offset: 0x190
	protected QuestEvent questEvent; //Field offset: 0x198
	[CompilerGenerated]
	private QuestDetails <QuestData>k__BackingField; //Field offset: 0x1A0
	protected List<QuestPartButton> questPartButtons; //Field offset: 0x1A8
	protected List<TaskPanel> taskPanels; //Field offset: 0x1B0
	protected QuestUiData questUiData; //Field offset: 0x1B8
	protected int selectedTaskIndex; //Field offset: 0x1C0
	protected int CurrentPartIndex; //Field offset: 0x1C4
	private Nullable<Boolean> hasClaimedRewards; //Field offset: 0x1C8
	private Nullable<Boolean> hasCompletedAllTasks; //Field offset: 0x1CA
	protected AsyncOperationHandle<GameObject> worldSceneAssetHandle; //Field offset: 0x1D0
	protected Animator worldAnimator; //Field offset: 0x1E8
	protected int introTransitionState; //Field offset: 0x1F0
	protected bool screenReady; //Field offset: 0x1F4
	protected bool hasAvailableHolidayEventSpecificRewards; //Field offset: 0x1F5
	protected bool hasClaimedHolidayRewards; //Field offset: 0x1F6
	private bool claimingRewards; //Field offset: 0x1F7

	protected DailyChallengeModel DCM
	{
		 get { } //Length: 109
	}

	protected bool GameModeRequiresSaveDataOverwrite
	{
		 get { } //Length: 205
	}

	protected bool HasClaimedRewards
	{
		 get { } //Length: 195
	}

	protected bool HasCompletedAllTasks
	{
		 get { } //Length: 230
	}

	protected bool HasCustomGoal
	{
		 get { } //Length: 166
	}

	protected bool HasMapSaveData
	{
		 get { } //Length: 170
	}

	protected LootPanel LootPanel
	{
		 get { } //Length: 70
	}

	protected string MapSaveName
	{
		 get { } //Length: 78
	}

	protected QuestPartData PartData
	{
		 get { } //Length: 69
	}

	protected QuestDetails QuestData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected QuestTrackerManager QuestTrackerManager
	{
		 get { } //Length: 68
	}

	protected GameObject RewardsClaimedPanel
	{
		 get { } //Length: 70
	}

	protected QuestPartData SelectedPartData
	{
		 get { } //Length: 69
	}

	protected TaskData SelectedTaskData
	{
		 get { } //Length: 94
	}

	protected bool ShowMapSaveOverrideMessage
	{
		 get { } //Length: 60
	}

	public QuestScreen() { }

	[CompilerGenerated]
	private void <OnClickReplay>b__123_0() { }

	[CompilerGenerated]
	private void <OnEnable>b__92_0() { }

	[CompilerGenerated]
	private void <OnEnable>b__92_1() { }

	[CompilerGenerated]
	private void <OnEnable>b__92_2() { }

	[CompilerGenerated]
	private void <OnEnable>b__92_3() { }

	[CompilerGenerated]
	private void <OnEnable>b__92_4() { }

	[CompilerGenerated]
	private void <OnEnable>b__92_5() { }

	[CompilerGenerated]
	private void <OnEnable>b__92_6(bool value) { }

	[CompilerGenerated]
	private void <OnEnable>b__92_7() { }

	protected void AnimatedDialogueCompleted(DialogueData dialogueData, int index) { }

	protected virtual void Awake() { }

	public override void ButtonsInteractable(bool interactable) { }

	[AsyncStateMachine(typeof(<CheckForQuestDialogue>d__116))]
	protected void CheckForQuestDialogue() { }

	public virtual void Close() { }

	private Task CreateTaskPanel(PrefabReference prefab, Transform transform, TaskData task, int index) { }

	public void ExecuteQuestBehaviorCoroutine(IEnumerator coroutine) { }

	protected DailyChallengeModel get_DCM() { }

	protected bool get_GameModeRequiresSaveDataOverwrite() { }

	protected bool get_HasClaimedRewards() { }

	protected bool get_HasCompletedAllTasks() { }

	protected bool get_HasCustomGoal() { }

	protected bool get_HasMapSaveData() { }

	protected LootPanel get_LootPanel() { }

	protected string get_MapSaveName() { }

	protected QuestPartData get_PartData() { }

	[CompilerGenerated]
	protected QuestDetails get_QuestData() { }

	protected QuestTrackerManager get_QuestTrackerManager() { }

	protected GameObject get_RewardsClaimedPanel() { }

	protected QuestPartData get_SelectedPartData() { }

	protected TaskData get_SelectedTaskData() { }

	protected bool get_ShowMapSaveOverrideMessage() { }

	public QuestGameData GetQuestInGameData() { }

	private bool HasMapSaveDataForThisQuestTask() { }

	private bool HasStartGameOverride(TaskData taskData) { }

	protected void InfoClose() { }

	protected void InfoOpenClicked() { }

	protected override void LoadButtonsAndPanels() { }

	[AsyncStateMachine(typeof(<LoadPreviousEventRewards>d__107))]
	protected override Task LoadPreviousEventRewards() { }

	[AsyncStateMachine(typeof(<LoadUI>d__96))]
	protected override void LoadUI() { }

	[AsyncStateMachine(typeof(<OnClickClaim>d__126))]
	protected override void OnClickClaim() { }

	protected override void OnClickPlay(bool continueSave, TaskData taskDataOverride = null) { }

	protected override void OnClickReplay() { }

	protected override void OnClickReplayConfirmed() { }

	protected override void OnDialoguePopupClosed() { }

	protected override void OnDialogueTriggers(String[] triggers) { }

	public override void OnDisable() { }

	public override void OnEnable() { }

	public void OnReplayTaskClicked() { }

	private void OnResetQuestTriggered() { }

	public void OnSetSelectedQuestPart(QuestPartButton taskPanel, int index) { }

	public void OnSetSelectedTask(TaskPanel taskPanel, TaskData selectedTaskData) { }

	private void OnShowStoreIapClicked() { }

	protected override void OnStartGame(bool continueSave, TaskData taskDataOverride = null) { }

	protected void OnToggleDisableDialog(bool value) { }

	[AsyncStateMachine(typeof(<Open>d__94))]
	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	public virtual void ReClose() { }

	[AsyncStateMachine(typeof(<ReOpen>d__95))]
	public virtual void ReOpen(object data) { }

	[CompilerGenerated]
	protected void set_QuestData(QuestDetails value) { }

	public void SetBrowserMenuData(QuestUiData uiData) { }

	private void SetStoreButton() { }

	protected bool TryGetUnseenTaskDialogueData(out DialogueData dialogueData, out int index) { }

}

