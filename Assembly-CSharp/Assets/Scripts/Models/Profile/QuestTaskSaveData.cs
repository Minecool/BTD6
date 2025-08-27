namespace Assets.Scripts.Models.Profile;

public class QuestTaskSaveData
{
	public bool completed; //Field offset: 0x10
	public HashSet<String> seenDialogueEvents; //Field offset: 0x18
	public bool hasCollectedRewards; //Field offset: 0x20
	public int score; //Field offset: 0x24
	public string jsonMetadata; //Field offset: 0x28

	public QuestTaskSaveData() { }

	public void Reset(bool wipeEverything = false) { }

}

