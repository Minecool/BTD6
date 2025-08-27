namespace NinjaKiwi.GUTS.Models.CT;

public struct TicketStatus
{
	[CompilerGenerated]
	private int <AvailableFromPersonal>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <AvailableFromGuild>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private int <AvailableFromPurchase>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <GuildTicketAllowance>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <RefilCount>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable<DateTime> <NextRefillAt>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<DateTime> <NextPersonalRefillAt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <AvailableForPurchase>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable<DateTime> <PurchaseAvailableAt>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <GuildTickets>k__BackingField; //Field offset: 0x50

	public int AvailableForPurchase
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int AvailableFromGuild
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int AvailableFromPersonal
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 8900
	}

	public int AvailableFromPurchase
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int GuildTicketAllowance
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int GuildTickets
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Nullable<DateTime> NextPersonalRefillAt
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<DateTime> NextRefillAt
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public Nullable<DateTime> PurchaseAvailableAt
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int RefilCount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public int TotalAvailable
	{
		 get { } //Length: 118
	}

	[CompilerGenerated]
	[IsReadOnly]
	public int get_AvailableForPurchase() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_AvailableFromGuild() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_AvailableFromPersonal() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_AvailableFromPurchase() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_GuildTicketAllowance() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_GuildTickets() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Nullable<DateTime> get_NextPersonalRefillAt() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Nullable<DateTime> get_NextRefillAt() { }

	[CompilerGenerated]
	[IsReadOnly]
	public Nullable<DateTime> get_PurchaseAvailableAt() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_RefilCount() { }

	public int get_TotalAvailable() { }

	[CompilerGenerated]
	public void set_AvailableForPurchase(int value) { }

	[CompilerGenerated]
	public void set_AvailableFromGuild(int value) { }

	[CompilerGenerated]
	public void set_AvailableFromPersonal(int value) { }

	[CompilerGenerated]
	public void set_AvailableFromPurchase(int value) { }

	[CompilerGenerated]
	public void set_GuildTicketAllowance(int value) { }

	[CompilerGenerated]
	public void set_GuildTickets(int value) { }

	[CompilerGenerated]
	public void set_NextPersonalRefillAt(Nullable<DateTime> value) { }

	[CompilerGenerated]
	public void set_NextRefillAt(Nullable<DateTime> value) { }

	[CompilerGenerated]
	public void set_PurchaseAvailableAt(Nullable<DateTime> value) { }

	[CompilerGenerated]
	public void set_RefilCount(int value) { }

}

