namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class ActivityResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private InstanceActivity <InstanceActivity>k__BackingField; //Field offset: 0x18

	public InstanceActivity InstanceActivity
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

	public ActivityResponse() { }

	[CompilerGenerated]
	public InstanceActivity get_InstanceActivity() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_InstanceActivity(InstanceActivity value) { }

}

