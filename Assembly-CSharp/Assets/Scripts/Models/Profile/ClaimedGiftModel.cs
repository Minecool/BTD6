namespace Assets.Scripts.Models.Profile;

public class ClaimedGiftModel : ILocalisedGift
{
	[CompilerGenerated]
	private string <SerialisedLoot>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private DateTime <ReceivedTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, String> <LocalisedMessages>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private GiftType <GiftType>k__BackingField; //Field offset: 0x28

	[JsonProperty("type")]
	public override GiftType GiftType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonProperty("messages")]
	public override Dictionary<String, String> LocalisedMessages
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonProperty("time")]
	public DateTime ReceivedTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonProperty("loot")]
	public string SerialisedLoot
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ClaimedGiftModel() { }

	[CompilerGenerated]
	public override GiftType get_GiftType() { }

	[CompilerGenerated]
	public override Dictionary<String, String> get_LocalisedMessages() { }

	[CompilerGenerated]
	public DateTime get_ReceivedTime() { }

	[CompilerGenerated]
	public string get_SerialisedLoot() { }

	public LootSet GetLootSet() { }

	[CompilerGenerated]
	public void set_GiftType(GiftType value) { }

	[CompilerGenerated]
	public void set_LocalisedMessages(Dictionary<String, String> value) { }

	[CompilerGenerated]
	public void set_ReceivedTime(DateTime value) { }

	[CompilerGenerated]
	public void set_SerialisedLoot(string value) { }

}

