namespace Assets.Scripts.Data.Quests;

public class TowerUnlockQuest
{
	[TowerType]
	public string towerId; //Field offset: 0x10
	public int unlockLevel; //Field offset: 0x18
	public string unlockQuestId; //Field offset: 0x20
	public int questPartIndex; //Field offset: 0x28

	public TowerUnlockQuest() { }

}

