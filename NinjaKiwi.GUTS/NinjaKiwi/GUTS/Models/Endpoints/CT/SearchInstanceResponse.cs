namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class SearchInstanceResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private int <InstanceId>k__BackingField; //Field offset: 0x18

	public int InstanceId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 18
	}

	public SearchInstanceResponse() { }

	[CompilerGenerated]
	public int get_InstanceId() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_InstanceId(int value) { }

}

