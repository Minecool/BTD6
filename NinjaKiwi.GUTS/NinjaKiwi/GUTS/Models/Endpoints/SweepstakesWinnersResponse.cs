namespace NinjaKiwi.GUTS.Models.Endpoints;

[Nullable(0)]
[NullableContext(2)]
public class SweepstakesWinnersResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private string <WinnerIdsCsv>k__BackingField; //Field offset: 0x18

	public override bool Success
	{
		 get { } //Length: 9
	}

	public string WinnerIdsCsv
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SweepstakesWinnersResponse() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public string get_WinnerIdsCsv() { }

	[NullableContext(1)]
	public String[] GetWinnerIds() { }

	[CompilerGenerated]
	public void set_WinnerIdsCsv(string value) { }

}

