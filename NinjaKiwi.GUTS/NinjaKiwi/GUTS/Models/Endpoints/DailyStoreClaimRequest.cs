namespace NinjaKiwi.GUTS.Models.Endpoints;

public class DailyStoreClaimRequest
{
	[CompilerGenerated]
	private DailyStoreClaimType <Type>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private BcsCardRarity <CardType>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <TokenIndex>k__BackingField; //Field offset: 0x18

	public BcsCardRarity CardType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int TokenIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DailyStoreClaimType Type
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DailyStoreClaimRequest() { }

	[CompilerGenerated]
	public BcsCardRarity get_CardType() { }

	[CompilerGenerated]
	public int get_TokenIndex() { }

	[CompilerGenerated]
	public DailyStoreClaimType get_Type() { }

	[CompilerGenerated]
	public void set_CardType(BcsCardRarity value) { }

	[CompilerGenerated]
	public void set_TokenIndex(int value) { }

	[CompilerGenerated]
	public void set_Type(DailyStoreClaimType value) { }

}

