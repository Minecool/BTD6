namespace NinjaKiwi.GUTS.Models.Endpoints;

public class BossRushScoreResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private BossRushStatus <BossRushStatus>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsKillingBlow>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsScoreSubmitted>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	private uint <ScoreIncrement>k__BackingField; //Field offset: 0x24

	public BossRushStatus BossRushStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool IsKillingBlow
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsScoreSubmitted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public uint ScoreIncrement
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 19
	}

	public BossRushScoreResponse() { }

	[CompilerGenerated]
	public BossRushStatus get_BossRushStatus() { }

	[CompilerGenerated]
	public bool get_IsKillingBlow() { }

	[CompilerGenerated]
	public bool get_IsScoreSubmitted() { }

	[CompilerGenerated]
	public uint get_ScoreIncrement() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_BossRushStatus(BossRushStatus value) { }

	[CompilerGenerated]
	public void set_IsKillingBlow(bool value) { }

	[CompilerGenerated]
	public void set_IsScoreSubmitted(bool value) { }

	[CompilerGenerated]
	public void set_ScoreIncrement(uint value) { }

}

