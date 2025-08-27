namespace Assets.Scripts.Data.Quests.QuestBehaviors;

public class SpecialEventLootSetRewardableQuest : QuestBehavior
{
	public EventName eventId; //Field offset: 0x10
	public string rewardMetadata; //Field offset: 0x18
	public int partIndex; //Field offset: 0x20

	public SpecialEventLootSetRewardableQuest() { }

	public virtual void DebugClearDataTriggered() { }

}

