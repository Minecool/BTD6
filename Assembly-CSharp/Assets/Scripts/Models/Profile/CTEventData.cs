namespace Assets.Scripts.Models.Profile;

public class CTEventData
{
	public string eventId; //Field offset: 0x10
	public bool hasClaimedRewards; //Field offset: 0x18
	public Tuple<Nullable`1<Int32>, String> lastParticipation; //Field offset: 0x20
	public Dictionary<Int32, WonCTTileStats> wonTileIdStats; //Field offset: 0x28
	public int teamTrophiesEarnt; //Field offset: 0x30
	public List<ContestedTerritoryRelicType> selectedRelics; //Field offset: 0x38
	public HashSet<ContestedTerritoryRelicType> seenRelicTypes; //Field offset: 0x40
	public HashSet<String> blackListedGuildIds; //Field offset: 0x48
	public bool hasTicketsAvaliable; //Field offset: 0x50
	public Nullable<DateTime> ticketRefillTime; //Field offset: 0x58

	[JsonIgnore]
	public bool HasPendingRewards
	{
		 get { } //Length: 111
	}

	public CTEventData() { }

	public bool get_HasPendingRewards() { }

	public int GetTotalCaptures() { }

	public int GetTotalRelicCaptures() { }

}

