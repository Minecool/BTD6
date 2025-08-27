namespace NinjaKiwi.GUTS.Models.DailyStore;

public class DailyStoreInfo
{
	[CompilerGenerated]
	private readonly String[] <DailyTokenNames>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Boolean[] <TokenSlotsAvailable>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Boolean[] <CardSlotsAvailable>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <ReRollCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly DateTime <NextRefreshAt>k__BackingField; //Field offset: 0x30

	public Boolean[] CardSlotsAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] DailyTokenNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime NextRefreshAt
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int ReRollCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public Boolean[] TokenSlotsAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConstructor]
	public DailyStoreInfo(String[] dailyTokenNames, Boolean[] tokenSlotsAvailable, Boolean[] cardSlotsAvailable, int reRollCount, DateTime nextRefreshAt) { }

	public bool CanRequestRefresh(DailyStoreSettings settings) { }

	[CompilerGenerated]
	public Boolean[] get_CardSlotsAvailable() { }

	[CompilerGenerated]
	public String[] get_DailyTokenNames() { }

	[CompilerGenerated]
	public DateTime get_NextRefreshAt() { }

	[CompilerGenerated]
	public int get_ReRollCount() { }

	[CompilerGenerated]
	public Boolean[] get_TokenSlotsAvailable() { }

	[CompilerGenerated]
	public void set_CardSlotsAvailable(Boolean[] value) { }

	[CompilerGenerated]
	public void set_TokenSlotsAvailable(Boolean[] value) { }

}

