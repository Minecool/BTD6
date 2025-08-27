namespace Assets.Scripts.Models.Profile;

public class QuestSaveData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public bool wipeEverything; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal void <Reset>b__0(QuestPartSaveData x) { }

	}

	public string questId; //Field offset: 0x10
	public List<QuestPartSaveData> questPartSaveData; //Field offset: 0x18
	public bool hasSeenQuest; //Field offset: 0x20
	public int lastSelectedPartIndex; //Field offset: 0x24
	[Obsolete("Use QuestPartSaveData instead")]
	public List<QuestTaskSaveData> tasksSaveData; //Field offset: 0x28
	[Obsolete("Use QuestPartSaveData instead")]
	public bool hasCollectedRewards; //Field offset: 0x30
	[Obsolete("Use QuestPartSaveData instead")]
	public bool hasSeenQuestCompleteDialogue; //Field offset: 0x31
	[Obsolete("Use QuestPartSaveData instead")]
	public int lastSelectedTaskIndex; //Field offset: 0x34
	[Obsolete("Use QuestPartSaveData instead")]
	public bool hasClaimedSpecialEventRewards; //Field offset: 0x38
	[Obsolete("Use QuestPartSaveData instead")]
	public bool toggleDisableDialogue; //Field offset: 0x39

	public QuestSaveData() { }

	public void Reset(bool wipeEverything = false) { }

}

