namespace NinjaKiwi.GUTS.Models.Endpoints;

public class DailyRewardsClaimResponse : RewardsClaimResponse
{
	[CompilerGenerated]
	private DateTime <NextClaimTime>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private int <CurrentRewardIndex>k__BackingField; //Field offset: 0x38

	public int CurrentRewardIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DateTime NextClaimTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public DailyRewardsClaimResponse() { }

	[CompilerGenerated]
	public int get_CurrentRewardIndex() { }

	[CompilerGenerated]
	public DateTime get_NextClaimTime() { }

	[CompilerGenerated]
	public void set_CurrentRewardIndex(int value) { }

	[CompilerGenerated]
	public void set_NextClaimTime(DateTime value) { }

}

