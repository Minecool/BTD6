namespace NinjaKiwi.GUTS.Models.ContentBrowser;

[IsReadOnly]
public struct Accolade
{
	[CompilerGenerated]
	private readonly string <Id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly int <Quantity>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly long <LastPurchaseAt>k__BackingField; //Field offset: 0x10

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public long LastPurchaseAt
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int Quantity
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public Accolade(string id, int quantity, long lastPurchaseAt) { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public long get_LastPurchaseAt() { }

	[CompilerGenerated]
	public int get_Quantity() { }

}

