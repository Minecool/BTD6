namespace Assets.Scripts.Unity.UI_New.Quests;

public class TaskPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <ReplayDialogue>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TaskPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject defaultBg; //Field offset: 0x20
	public GameObject currentBg; //Field offset: 0x28
	public GameObject completedBg; //Field offset: 0x30
	public GameObject highlightedPanel; //Field offset: 0x38
	public GameObject highlightedPip; //Field offset: 0x40
	public GameObject completedPip; //Field offset: 0x48
	public GameObject completedPipTick; //Field offset: 0x50
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x58
	public NK_TextMeshProUGUI subTitleTxt; //Field offset: 0x60
	public Image image; //Field offset: 0x68
	public Button repeatDialogueBtn; //Field offset: 0x70
	public Button debugEditBtn; //Field offset: 0x78
	public Button panelBtn; //Field offset: 0x80
	private QuestDetails questData; //Field offset: 0x88
	private TaskData taskData; //Field offset: 0x90
	private int partIndex; //Field offset: 0x98
	private int index; //Field offset: 0x9C
	private bool hasCompleted; //Field offset: 0xA0

	public bool HasCompleted
	{
		 get { } //Length: 8
	}

	public int Index
	{
		 get { } //Length: 7
	}

	public int PartIndex
	{
		 get { } //Length: 7
	}

	public TaskPanel() { }

	public bool get_HasCompleted() { }

	public int get_Index() { }

	public int get_PartIndex() { }

	private void PanelSelected() { }

	[AsyncStateMachine(typeof(<ReplayDialogue>d__25))]
	private void ReplayDialogue() { }

	private void SetImage() { }

	public void SetSelected(int selectedTaskIndex) { }

	public void Setup(QuestDetails questData, TaskData taskData, int partIndex, int index) { }

	public void ToggleInteractable(bool interactable) { }

}

