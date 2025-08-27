namespace NinjaKiwi.GUTS.Models.Endpoints.ContentBrowser;

public class ContentCurationListResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private List<PlayerContentCurationInfo> <PlayerContentCurationInfo>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <TotalResults>k__BackingField; //Field offset: 0x20

	public List<PlayerContentCurationInfo> PlayerContentCurationInfo
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

	public int TotalResults
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ContentCurationListResponse() { }

	[CompilerGenerated]
	public List<PlayerContentCurationInfo> get_PlayerContentCurationInfo() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public int get_TotalResults() { }

	[CompilerGenerated]
	public void set_PlayerContentCurationInfo(List<PlayerContentCurationInfo> value) { }

	[CompilerGenerated]
	public void set_TotalResults(int value) { }

}

