namespace NinjaKiwi.GUTS.Models.Endpoints.ContentBrowser;

public class ContentSubmissionRequest
{
	[CompilerGenerated]
	private PlayerContentInfo <PlayerContentInfo>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <EncodedContentData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ContentType <ContentType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <ReplayId>k__BackingField; //Field offset: 0x28

	public ContentType ContentType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[ThrowIfNullOrEmpty]
	public string EncodedContentData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[ThrowIfNullOrEmpty]
	public PlayerContentInfo PlayerContentInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string ReplayId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ContentSubmissionRequest() { }

	[CompilerGenerated]
	public ContentType get_ContentType() { }

	[CompilerGenerated]
	public string get_EncodedContentData() { }

	[CompilerGenerated]
	public PlayerContentInfo get_PlayerContentInfo() { }

	[CompilerGenerated]
	public string get_ReplayId() { }

	[CompilerGenerated]
	public void set_ContentType(ContentType value) { }

	[CompilerGenerated]
	public void set_EncodedContentData(string value) { }

	[CompilerGenerated]
	public void set_PlayerContentInfo(PlayerContentInfo value) { }

	[CompilerGenerated]
	public void set_ReplayId(string value) { }

}

