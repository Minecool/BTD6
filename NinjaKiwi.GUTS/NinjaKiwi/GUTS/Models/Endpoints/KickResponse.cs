namespace NinjaKiwi.GUTS.Models.Endpoints;

public class KickResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private KickResult <KickResult>k__BackingField; //Field offset: 0x18

	public KickResult KickResult
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public KickResponse() { }

	[CompilerGenerated]
	public KickResult get_KickResult() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_KickResult(KickResult value) { }

}

