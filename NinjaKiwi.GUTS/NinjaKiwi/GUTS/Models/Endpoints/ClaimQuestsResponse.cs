namespace NinjaKiwi.GUTS.Models.Endpoints;

public class ClaimQuestsResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private ActiveQuests <PlayerQuests>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ActiveQuest <NewQuest>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <HasClaimed>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Dictionary<String, Dictionary`2<String, Int64>> <Rewards>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Dictionary<String, Dictionary`2<String, Int64>> <NewBalances>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Dictionary<String, Dictionary`2<String, Int64>> <ShardedRewards>k__BackingField; //Field offset: 0x40

	public bool HasClaimed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, Dictionary`2<String, Int64>> NewBalances
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ActiveQuest NewQuest
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ActiveQuests PlayerQuests
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<String, Dictionary`2<String, Int64>> Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<String, Dictionary`2<String, Int64>> ShardedRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public ClaimQuestsResponse() { }

	[CompilerGenerated]
	public bool get_HasClaimed() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<String, Int64>> get_NewBalances() { }

	[CompilerGenerated]
	public ActiveQuest get_NewQuest() { }

	[CompilerGenerated]
	public ActiveQuests get_PlayerQuests() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<String, Int64>> get_Rewards() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<String, Int64>> get_ShardedRewards() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_HasClaimed(bool value) { }

	[CompilerGenerated]
	public void set_NewBalances(Dictionary<String, Dictionary`2<String, Int64>> value) { }

	[CompilerGenerated]
	public void set_NewQuest(ActiveQuest value) { }

	[CompilerGenerated]
	public void set_PlayerQuests(ActiveQuests value) { }

	[CompilerGenerated]
	public void set_Rewards(Dictionary<String, Dictionary`2<String, Int64>> value) { }

	[CompilerGenerated]
	public void set_ShardedRewards(Dictionary<String, Dictionary`2<String, Int64>> value) { }

}

