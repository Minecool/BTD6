namespace Assets.Scripts.Unity.UI_New.Quests;

public class QuestPartButton : MonoBehaviour
{
	public GameObject defaultBg; //Field offset: 0x20
	public GameObject currentBg; //Field offset: 0x28
	public GameObject completedBg; //Field offset: 0x30
	public GameObject highlightedPanel; //Field offset: 0x38
	public GameObject highlightedPip; //Field offset: 0x40
	public GameObject completedPip; //Field offset: 0x48
	public GameObject completedPipTick; //Field offset: 0x50
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x58
	public Button panelBtn; //Field offset: 0x60
	private QuestDetails questData; //Field offset: 0x68
	private int index; //Field offset: 0x70
	private bool hasCompleted; //Field offset: 0x74

	public bool HasCompleted
	{
		 get { } //Length: 5
	}

	public int Index
	{
		 get { } //Length: 4
	}

	public QuestPartButton() { }

	public bool get_HasCompleted() { }

	public int get_Index() { }

	private void PanelSelected() { }

	public void SetSelected(int selectedTaskIndex) { }

	public void Setup(QuestDetails questData, int index) { }

	public void ToggleInteractable(bool interactable) { }

}

