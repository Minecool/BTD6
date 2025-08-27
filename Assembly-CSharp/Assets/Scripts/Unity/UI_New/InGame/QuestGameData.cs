namespace Assets.Scripts.Unity.UI_New.InGame;

public class QuestGameData
{
	public string questId; //Field offset: 0x10
	public string taskId; //Field offset: 0x18
	public int partIndex; //Field offset: 0x20
	public int taskIndex; //Field offset: 0x24
	public bool disableDialogue; //Field offset: 0x28

	public QuestGameData() { }

	public QuestGameData Clone() { }

}

