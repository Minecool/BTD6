namespace NinjaKiwi.GUTS.Models.Endpoints;

public class OpenCardPackResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private Dictionary<String, Dictionary`2<String, Int64>> <Rewards>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, Dictionary`2<String, Int64>> <ShardedRewards>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Dictionary<String, Dictionary`2<String, Int64>> <NewBalances>k__BackingField; //Field offset: 0x28

	public Dictionary<String, Dictionary`2<String, Int64>> NewBalances
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
		 get { } //Length: 19
	}

	public OpenCardPackResponse() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<String, Int64>> get_NewBalances() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<String, Int64>> get_Rewards() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<String, Int64>> get_ShardedRewards() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_NewBalances(Dictionary<String, Dictionary`2<String, Int64>> value) { }

	[CompilerGenerated]
	public void set_Rewards(Dictionary<String, Dictionary`2<String, Int64>> value) { }

	[CompilerGenerated]
	public void set_ShardedRewards(Dictionary<String, Dictionary`2<String, Int64>> value) { }

}

