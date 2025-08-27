namespace Assets.Scripts.Unity.UI_New.Quests;

public class QuestUiData
{
	public string fromScene; //Field offset: 0x10
	public QuestDetails QuestData; //Field offset: 0x18
	public QuestCategory fromCategory; //Field offset: 0x20

	public QuestUiData(string fromScene, QuestDetails QuestData, QuestCategory fromCategory = -1) { }

}

