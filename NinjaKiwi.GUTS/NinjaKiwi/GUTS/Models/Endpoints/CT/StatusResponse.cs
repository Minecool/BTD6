namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class StatusResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private bool <IsRegistered>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <InstanceId>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private EventStatus <EventStatus>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private TicketStatus <TicketStatus>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private GuildInfo[] <GuildInfos>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Dictionary<Int32, NodeStatus> <CapturedNodes>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private InstanceActivity <InstanceActivity>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private List<ContestedTerritoryRelicType> <Relics>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private bool <CanClaimBonusRewards>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private Nullable<DateTime> <NextBonusRewardsAt>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private byte <ClaimedBonusRewardCount>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private String[] <CompetitivePlayerIds>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private Nullable<Int64> <Ts>k__BackingField; //Field offset: 0xC8

	public bool CanClaimBonusRewards
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Dictionary<Int32, NodeStatus> CapturedNodes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public byte ClaimedBonusRewardCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public String[] CompetitivePlayerIds
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public EventStatus EventStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GuildInfo[] GuildInfos
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public InstanceActivity InstanceActivity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int InstanceId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public bool IsCompetitive
	{
		 get { } //Length: 21
	}

	public bool IsRegistered
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Nullable<DateTime> NextBonusRewardsAt
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 11
	}

	public List<ContestedTerritoryRelicType> Relics
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 18
	}

	public TicketStatus TicketStatus
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		 set { } //Length: 50
	}

	public Nullable<Int64> Ts
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 11
	}

	public StatusResponse() { }

	[CompilerGenerated]
	public bool get_CanClaimBonusRewards() { }

	[CompilerGenerated]
	public Dictionary<Int32, NodeStatus> get_CapturedNodes() { }

	[CompilerGenerated]
	public byte get_ClaimedBonusRewardCount() { }

	[CompilerGenerated]
	public String[] get_CompetitivePlayerIds() { }

	[CompilerGenerated]
	public EventStatus get_EventStatus() { }

	[CompilerGenerated]
	public GuildInfo[] get_GuildInfos() { }

	[CompilerGenerated]
	public InstanceActivity get_InstanceActivity() { }

	[CompilerGenerated]
	public int get_InstanceId() { }

	public bool get_IsCompetitive() { }

	[CompilerGenerated]
	public bool get_IsRegistered() { }

	[CompilerGenerated]
	public Nullable<DateTime> get_NextBonusRewardsAt() { }

	[CompilerGenerated]
	public List<ContestedTerritoryRelicType> get_Relics() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public TicketStatus get_TicketStatus() { }

	[CompilerGenerated]
	public Nullable<Int64> get_Ts() { }

	[CompilerGenerated]
	public void set_CanClaimBonusRewards(bool value) { }

	[CompilerGenerated]
	public void set_CapturedNodes(Dictionary<Int32, NodeStatus> value) { }

	[CompilerGenerated]
	public void set_ClaimedBonusRewardCount(byte value) { }

	[CompilerGenerated]
	public void set_CompetitivePlayerIds(String[] value) { }

	[CompilerGenerated]
	public void set_EventStatus(EventStatus value) { }

	[CompilerGenerated]
	public void set_GuildInfos(GuildInfo[] value) { }

	[CompilerGenerated]
	public void set_InstanceActivity(InstanceActivity value) { }

	[CompilerGenerated]
	public void set_InstanceId(int value) { }

	[CompilerGenerated]
	public void set_IsRegistered(bool value) { }

	[CompilerGenerated]
	public void set_NextBonusRewardsAt(Nullable<DateTime> value) { }

	[CompilerGenerated]
	public void set_Relics(List<ContestedTerritoryRelicType> value) { }

	[CompilerGenerated]
	public void set_TicketStatus(TicketStatus value) { }

	[CompilerGenerated]
	public void set_Ts(Nullable<Int64> value) { }

}

