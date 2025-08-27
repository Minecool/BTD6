namespace Assets.Scripts.Models.Profile;

public class QuestEventData
{
	public string eventId; //Field offset: 0x10
	public bool hasClaimedRewards; //Field offset: 0x18
	public QuestModeData questData; //Field offset: 0x20

	public QuestEventData() { }

}

