namespace NinjaKiwi.GUTS.Models.Endpoints.ContentBrowser;

public class CurationRequest
{
	[CompilerGenerated]
	private string <ContentId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ContentType <ContentType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <ContentOwnerId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsValidVote>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private RejectionReason <RejectionReason>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private Nullable<Boolean> <IsCool>k__BackingField; //Field offset: 0x30

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

	public Nullable<Boolean> IsCool
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool IsValidVote
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RejectionReason RejectionReason
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CurationRequest() { }

	[CompilerGenerated]
	public string get_ContentId() { }

	[CompilerGenerated]
	public string get_ContentOwnerId() { }

	[CompilerGenerated]
	public ContentType get_ContentType() { }

	[CompilerGenerated]
	public Nullable<Boolean> get_IsCool() { }

	[CompilerGenerated]
	public bool get_IsValidVote() { }

	[CompilerGenerated]
	public RejectionReason get_RejectionReason() { }

	[CompilerGenerated]
	public void set_ContentId(string value) { }

	[CompilerGenerated]
	public void set_ContentOwnerId(string value) { }

	[CompilerGenerated]
	public void set_ContentType(ContentType value) { }

	[CompilerGenerated]
	public void set_IsCool(Nullable<Boolean> value) { }

	[CompilerGenerated]
	public void set_IsValidVote(bool value) { }

	[CompilerGenerated]
	public void set_RejectionReason(RejectionReason value) { }

}

