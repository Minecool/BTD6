namespace Assets.Scripts.Models.Profile;

public class QuestPartSaveData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public bool wipeEverything; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal void <Reset>b__0(QuestTaskSaveData x) { }

	}

	public bool completed; //Field offset: 0x10
	public List<QuestTaskSaveData> tasksSaveData; //Field offset: 0x18
	public bool hasCollectedRewards; //Field offset: 0x20
	public bool hasSeenQuestCompleteDialogue; //Field offset: 0x21
	public bool hasSeenQuestPart; //Field offset: 0x22
	public bool toggleDisableDialogue; //Field offset: 0x23
	public bool hasClaimedSpecialEventRewards; //Field offset: 0x24
	public int lastSelectedTaskIndex; //Field offset: 0x28

	public QuestPartSaveData() { }

	public void Reset(bool wipeEverything = false) { }

}

