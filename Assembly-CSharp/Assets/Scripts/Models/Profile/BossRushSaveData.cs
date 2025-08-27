namespace Assets.Scripts.Models.Profile;

public class BossRushSaveData
{
	public string eventId; //Field offset: 0x10
	public Nullable<Int32> rewardTierClaimed; //Field offset: 0x18
	public int purchasedTicketCount; //Field offset: 0x20
	public Nullable<Int32> availableTickets; //Field offset: 0x24
	public Nullable<DateTime> nextRefilTime; //Field offset: 0x30
	public bool hasClaimedRewards; //Field offset: 0x40
	public bool hasSeenInitialSpawn; //Field offset: 0x41
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"guildId", "index"}])]
	public ValueTuple<String, Int32> lastSeenIsland; //Field offset: 0x48

	[JsonIgnore]
	public bool HasPendingRewards
	{
		 get { } //Length: 8
	}

	public BossRushSaveData() { }

	public void ConsumeTicket(BossRushTicketSettings ticketSettings) { }

	public bool get_HasPendingRewards() { }

	public ValueTuple<Int32, Nullable`1<DateTime>> GetAvailableTickets(BossRushTicketSettings ticketSettings) { }

	public void TicketPurchased() { }

}

