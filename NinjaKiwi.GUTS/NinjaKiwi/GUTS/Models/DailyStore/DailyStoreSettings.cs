namespace NinjaKiwi.GUTS.Models.DailyStore;

public class DailyStoreSettings
{
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<DailyStoreClaimType, Int32[]> <Costs>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Int32[] <TokenRewards>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private String[] <PossibleDailyTokens>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <CardRollWeightsId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <HasDailyCardsLimit>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HasDailyTokensLimit>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private int <MaxDailyRefresh>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private TimeSpan <DailyUtcOffset>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Dictionary<BcsCardRarity, Int32>[] <CardPackContents>k__BackingField; //Field offset: 0x48
	public Int32[] RareChances; //Field offset: 0x50

	public Dictionary<BcsCardRarity, Int32>[] CardPackContents
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string CardRollWeightsId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public Int32[] CardsMonkeyMoneyCosts
	{
		 get { } //Length: 103
	}

	public Dictionary<DailyStoreClaimType, Int32[]> Costs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TimeSpan DailyUtcOffset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool HasDailyCardsLimit
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool HasDailyTokensLimit
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int MaxDailyRefresh
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public String[] PossibleDailyTokens
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Int32[] TokenRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public Int32[] TokensMonkeyMoneyCosts
	{
		 get { } //Length: 106
	}

	public DailyStoreSettings() { }

	[CompilerGenerated]
	public Dictionary<BcsCardRarity, Int32>[] get_CardPackContents() { }

	[CompilerGenerated]
	public string get_CardRollWeightsId() { }

	public Int32[] get_CardsMonkeyMoneyCosts() { }

	[CompilerGenerated]
	public Dictionary<DailyStoreClaimType, Int32[]> get_Costs() { }

	[CompilerGenerated]
	public TimeSpan get_DailyUtcOffset() { }

	[CompilerGenerated]
	public bool get_HasDailyCardsLimit() { }

	[CompilerGenerated]
	public bool get_HasDailyTokensLimit() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	public int get_MaxDailyRefresh() { }

	[CompilerGenerated]
	public String[] get_PossibleDailyTokens() { }

	[CompilerGenerated]
	public Int32[] get_TokenRewards() { }

	public Int32[] get_TokensMonkeyMoneyCosts() { }

	[CompilerGenerated]
	public void set_CardPackContents(Dictionary<BcsCardRarity, Int32>[] value) { }

	[CompilerGenerated]
	public void set_CardRollWeightsId(string value) { }

	[CompilerGenerated]
	public void set_Costs(Dictionary<DailyStoreClaimType, Int32[]> value) { }

	[CompilerGenerated]
	public void set_DailyUtcOffset(TimeSpan value) { }

	[CompilerGenerated]
	public void set_HasDailyCardsLimit(bool value) { }

	[CompilerGenerated]
	public void set_HasDailyTokensLimit(bool value) { }

	[CompilerGenerated]
	public void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	public void set_MaxDailyRefresh(int value) { }

	[CompilerGenerated]
	public void set_PossibleDailyTokens(String[] value) { }

	[CompilerGenerated]
	public void set_TokenRewards(Int32[] value) { }

}

