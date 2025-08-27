namespace NinjaKiwi.GUTS.Models.DailyRewards;

public class DailyRewardsSettings
{
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private TimeSpan <DailyUtcOffset>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <CanStagingInfiniteClaim>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 2, 1}])]
	private WalletRewardGroup[][] <Rewards>k__BackingField; //Field offset: 0x28

	public bool CanStagingInfiniteClaim
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public TimeSpan DailyUtcOffset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 2, 1}])]
	public WalletRewardGroup[][] Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public DailyRewardsSettings() { }

	[CompilerGenerated]
	public bool get_CanStagingInfiniteClaim() { }

	[CompilerGenerated]
	public TimeSpan get_DailyUtcOffset() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	public WalletRewardGroup[][] get_Rewards() { }

	[CompilerGenerated]
	public void set_CanStagingInfiniteClaim(bool value) { }

	[CompilerGenerated]
	public void set_DailyUtcOffset(TimeSpan value) { }

	[CompilerGenerated]
	public void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	public void set_Rewards(WalletRewardGroup[][] value) { }

}

