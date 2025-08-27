namespace Assets.Scripts.Data.Quests;

public class QuestPartData
{
	public string id; //Field offset: 0x10
	public int unlockLevel; //Field offset: 0x18
	[ExtendedDrawer]
	[ReorderableList("Behaviors", True)]
	[SerializeField]
	private QuestBehaviorContainer QuestBehaviorContainer; //Field offset: 0x20
	[ExtendedDrawer]
	[ReorderableList("Dialogues", True)]
	[SerializeField]
	private QuestDialogueContainer QuestDialogueContainer; //Field offset: 0x28
	[SerializeReference]
	public TaskData[] TasksData; //Field offset: 0x30
	[ReorderableList("items", True)]
	[SerializeField]
	private RewardsContainer QuestCompleteRewardsContainer; //Field offset: 0x38

	public bool IsQuestPartLocked
	{
		 get { } //Length: 199
	}

	public bool IsSpecialRewardsQuest
	{
		 get { } //Length: 91
	}

	public bool IsSpotLightQuest
	{
		 get { } //Length: 91
	}

	public IEnumerable<QuestBehavior> QuestBehaviors
	{
		 get { } //Length: 27
	}

	public IEnumerable<DialogueDataQuest> QuestDialogues
	{
		 get { } //Length: 27
	}

	public List<LootData> Rewards
	{
		 get { } //Length: 143
	}

	public QuestPartData() { }

	public DialogueData CheckForNextScreenDialogue(string questId, int CurrentPartIndex, int selectedTaskIndex) { }

	public bool get_IsQuestPartLocked() { }

	public bool get_IsSpecialRewardsQuest() { }

	public bool get_IsSpotLightQuest() { }

	public IEnumerable<QuestBehavior> get_QuestBehaviors() { }

	public IEnumerable<DialogueDataQuest> get_QuestDialogues() { }

	public List<LootData> get_Rewards() { }

	public bool TryGetQuestBehavior(out T behavior) { }

	public bool TryGetQuestDialogue(out T dialogue) { }

}

