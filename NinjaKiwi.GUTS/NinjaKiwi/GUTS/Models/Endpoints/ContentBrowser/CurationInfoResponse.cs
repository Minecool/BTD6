namespace NinjaKiwi.GUTS.Models.Endpoints.ContentBrowser;

public class CurationInfoResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private bool <IsCurator>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsAdmin>k__BackingField; //Field offset: 0x19

	public bool IsAdmin
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsCurator
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public CurationInfoResponse() { }

	[CompilerGenerated]
	public bool get_IsAdmin() { }

	[CompilerGenerated]
	public bool get_IsCurator() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_IsAdmin(bool value) { }

	[CompilerGenerated]
	public void set_IsCurator(bool value) { }

}

