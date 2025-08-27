namespace Assets.Scripts.Models.ServerEvents;

public class GiftEventMetadata : IEventMetadata
{
	public GiftEventType type; //Field offset: 0x10
	public Dictionary<String, String> localisedMessages; //Field offset: 0x18
	public int monkeyMoney; //Field offset: 0x20
	public int trophies; //Field offset: 0x24
	public string powers; //Field offset: 0x28
	public string trophyStoreItems; //Field offset: 0x30
	public string rawLoot; //Field offset: 0x38

	public GiftEventMetadata() { }

	public bool HasLoot() { }

}

