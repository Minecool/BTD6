namespace Assets.Scripts.Data.Quests;

public class DialogueData
{
	public string id; //Field offset: 0x10
	public bool disableBackgroundTint; //Field offset: 0x18
	public bool disableSimulationPause; //Field offset: 0x19
	[HideInInspector]
	public DialogueType dialogueType; //Field offset: 0x1C
	[JsonProperty]
	[ReorderableList("items", True)]
	[SerializeField]
	private DialogueContainer DialogueContainer; //Field offset: 0x20

	[JsonIgnore]
	public List<QuestDialogueAnimData> Dialogues
	{
		 get { } //Length: 72
	}

	[JsonIgnore]
	public bool HasDialogueData
	{
		 get { } //Length: 44
	}

	public DialogueData() { }

	public DialogueDataModel Def() { }

	public List<QuestDialogueAnimData> get_Dialogues() { }

	public bool get_HasDialogueData() { }

}

