namespace NinjaKiwi.GUTS.Models.Endpoints.ContentBrowser;

public class ContentSubmissionResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private string <ContentId>k__BackingField; //Field offset: 0x18

	public string ContentId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 22
	}

	public ContentSubmissionResponse() { }

	[CompilerGenerated]
	public string get_ContentId() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_ContentId(string value) { }

}

