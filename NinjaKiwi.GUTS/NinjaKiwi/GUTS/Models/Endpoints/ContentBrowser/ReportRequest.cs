namespace NinjaKiwi.GUTS.Models.Endpoints.ContentBrowser;

public class ReportRequest
{
	[CompilerGenerated]
	private string <ContentId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ContentType <ContentType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ContentOwnerId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private RejectionReason <ReportReason>k__BackingField; //Field offset: 0x28

	[ThrowIfNullOrEmpty]
	public string ContentId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[ThrowIfNullOrEmpty]
	public string ContentOwnerId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ContentType ContentType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RejectionReason ReportReason
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ReportRequest() { }

	[CompilerGenerated]
	public string get_ContentId() { }

	[CompilerGenerated]
	public string get_ContentOwnerId() { }

	[CompilerGenerated]
	public ContentType get_ContentType() { }

	[CompilerGenerated]
	public RejectionReason get_ReportReason() { }

	[CompilerGenerated]
	public void set_ContentId(string value) { }

	[CompilerGenerated]
	public void set_ContentOwnerId(string value) { }

	[CompilerGenerated]
	public void set_ContentType(ContentType value) { }

	[CompilerGenerated]
	public void set_ReportReason(RejectionReason value) { }

}

