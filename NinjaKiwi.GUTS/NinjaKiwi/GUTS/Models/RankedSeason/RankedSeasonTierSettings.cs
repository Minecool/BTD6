namespace NinjaKiwi.GUTS.Models.RankedSeason;

[Nullable(0)]
[NullableContext(2)]
public class RankedSeasonTierSettings
{
	[CompilerGenerated]
	private int <VictoryPoints>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <DefeatPoints>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <CompletionPoints>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Int32[] <InnerTiersStepPoints>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <HasEndlessInnerTiers>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private RankedSeasonStepRewards[] <StepRewards>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private WalletRewardGroup[] <CompletionRewards>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HasWinStreakBonus>k__BackingField; //Field offset: 0x40

	public int CompletionPoints
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public WalletRewardGroup[] CompletionRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int DefeatPoints
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool HasEndlessInnerTiers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool HasWinStreakBonus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Int32[] InnerTiersStepPoints
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public RankedSeasonStepRewards[] StepRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int VictoryPoints
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RankedSeasonTierSettings() { }

	[CompilerGenerated]
	public int get_CompletionPoints() { }

	[CompilerGenerated]
	public WalletRewardGroup[] get_CompletionRewards() { }

	[CompilerGenerated]
	public int get_DefeatPoints() { }

	[CompilerGenerated]
	public bool get_HasEndlessInnerTiers() { }

	[CompilerGenerated]
	public bool get_HasWinStreakBonus() { }

	[CompilerGenerated]
	public Int32[] get_InnerTiersStepPoints() { }

	[CompilerGenerated]
	public RankedSeasonStepRewards[] get_StepRewards() { }

	[CompilerGenerated]
	public int get_VictoryPoints() { }

	[NullableContext(0)]
	public ValueTuple<Int32, Int32> GetInnerTier(int points) { }

	[CompilerGenerated]
	public void set_CompletionPoints(int value) { }

	[CompilerGenerated]
	public void set_CompletionRewards(WalletRewardGroup[] value) { }

	[CompilerGenerated]
	public void set_DefeatPoints(int value) { }

	[CompilerGenerated]
	public void set_HasEndlessInnerTiers(bool value) { }

	[CompilerGenerated]
	public void set_HasWinStreakBonus(bool value) { }

	[CompilerGenerated]
	public void set_InnerTiersStepPoints(Int32[] value) { }

	[CompilerGenerated]
	public void set_StepRewards(RankedSeasonStepRewards[] value) { }

	[CompilerGenerated]
	public void set_VictoryPoints(int value) { }

}

