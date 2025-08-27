namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public struct TowerLists
{
	[CompilerGenerated]
	private String[] <Primary>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private String[] <Military>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private String[] <Magic>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private String[] <Support>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private String[] <AllTowers>k__BackingField; //Field offset: 0x20

	public String[] AllTowers
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] Magic
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] Military
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] Primary
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public String[] Support
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TowerLists(String[] primary, String[] military, String[] magic, String[] support, String[] allTowers) { }

	[CompilerGenerated]
	[IsReadOnly]
	public String[] get_AllTowers() { }

	[CompilerGenerated]
	[IsReadOnly]
	public String[] get_Magic() { }

	[CompilerGenerated]
	[IsReadOnly]
	public String[] get_Military() { }

	[CompilerGenerated]
	[IsReadOnly]
	public String[] get_Primary() { }

	[CompilerGenerated]
	[IsReadOnly]
	public String[] get_Support() { }

	[CompilerGenerated]
	public void set_AllTowers(String[] value) { }

	[CompilerGenerated]
	public void set_Magic(String[] value) { }

	[CompilerGenerated]
	public void set_Military(String[] value) { }

	[CompilerGenerated]
	public void set_Primary(String[] value) { }

	[CompilerGenerated]
	public void set_Support(String[] value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

