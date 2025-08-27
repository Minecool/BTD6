namespace Assets.Scripts.Unity.UI_New.Quests;

public class QuestSingleEventScreen : QuestScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TowerData, Boolean> <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <LoadUI>b__18_0(TowerData tower) { }

	}

	[CompilerGenerated]
	private struct <ReplayDialogue>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestSingleEventScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public NK_TextMeshProUGUI longDescriptionTxt; //Field offset: 0x1F8
	public Image questIcon; //Field offset: 0x200
	public Button repeatDialogueBtn; //Field offset: 0x208
	public Button debugEditBtn; //Field offset: 0x210
	public Image mapIcon; //Field offset: 0x218
	public NK_TextMeshProUGUI mapNameTxt; //Field offset: 0x220
	public NK_TextMeshProUGUI modeTxt; //Field offset: 0x228
	public NK_TextMeshProUGUI healthTxt; //Field offset: 0x230
	public NK_TextMeshProUGUI moneyTxt; //Field offset: 0x238
	public Button rulesBtn; //Field offset: 0x240
	public ScorePanelUI timeUI; //Field offset: 0x248
	public ScorePanelUI scoreUI; //Field offset: 0x280
	private Nullable<ScorePanelUI> _selectedUI; //Field offset: 0x2B8

	public ScorePanelUI ChallengePanelUI
	{
		 get { } //Length: 1205
	}

	public QuestSingleEventScreen() { }

	[CompilerGenerated]
	private void <OnEnable>b__15_0() { }

	[CompilerGenerated]
	private void <OnEnable>b__15_1() { }

	[CompilerGenerated]
	private void <OnEnable>b__15_2() { }

	[CompilerGenerated]
	private void <OnEnable>b__15_3() { }

	[CompilerGenerated]
	private void <OnEnable>b__15_4() { }

	[CompilerGenerated]
	private void <OnEnable>b__15_5() { }

	[CompilerGenerated]
	private void <OnEnable>b__15_6(bool value) { }

	public virtual void ButtonsInteractable(bool interactable) { }

	public virtual void Close() { }

	public ScorePanelUI get_ChallengePanelUI() { }

	protected virtual void LoadButtonsAndPanels() { }

	protected virtual void LoadUI() { }

	public virtual void OnEnable() { }

	private void OnShowRulesClicked() { }

	protected virtual void OnStartGame(bool continueSave, TaskData taskDataOverride = null) { }

	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	public virtual void ReClose() { }

	public virtual void ReOpen(object data) { }

	[AsyncStateMachine(typeof(<ReplayDialogue>d__22))]
	private void ReplayDialogue() { }

}

