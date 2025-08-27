namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class StartScoreRequest : BaseSignedInRequest
{
	[CompilerGenerated]
	private int <NodeId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <Misc>k__BackingField; //Field offset: 0x28

	public string Misc
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[ValidRange(0, 2147483647)]
	public int NodeId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public StartScoreRequest() { }

	[CompilerGenerated]
	public string get_Misc() { }

	[CompilerGenerated]
	public int get_NodeId() { }

	[CompilerGenerated]
	public void set_Misc(string value) { }

	[CompilerGenerated]
	public void set_NodeId(int value) { }

}

