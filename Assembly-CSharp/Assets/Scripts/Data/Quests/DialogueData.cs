namespace Assets.Scripts.Data.Quests;

public abstract class DialogueData
{
	public string id; //Field offset: 0x10
	public bool disableBackgroundTint; //Field offset: 0x18
	public bool disableSimulationPause; //Field offset: 0x19
	[HideInInspector]
	public DialogueType dialogueType; //Field offset: 0x1C
	[ReorderableList("items", True)]
	[SerializeField]
	private DialogueContainer DialogueContainer; //Field offset: 0x20

	public List<QuestDialogueAnimData> Dialogues
	{
		 get { } //Length: 72
	}

	public bool HasDialogueData
	{
		 get { } //Length: 39
	}

	public DialogueData() { }

	public DialogueDataModel Def() { }

	public List<QuestDialogueAnimData> get_Dialogues() { }

	public bool get_HasDialogueData() { }

}

