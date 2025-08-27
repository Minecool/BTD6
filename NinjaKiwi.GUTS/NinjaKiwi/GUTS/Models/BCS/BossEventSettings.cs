namespace NinjaKiwi.GUTS.Models.BCS;

[Nullable(0)]
[NullableContext(1)]
public class BossEventSettings
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Dictionary<String, BossRewards> <Rewards>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Dictionary<String, BossSettings> <Settings>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private TimeSpan <MaxRewardClaimTime>k__BackingField; //Field offset: 0x20

	public TimeSpan MaxRewardClaimTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public Dictionary<String, BossRewards> Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public Dictionary<String, BossSettings> Settings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossEventSettings() { }

	[CompilerGenerated]
	public TimeSpan get_MaxRewardClaimTime() { }

	[CompilerGenerated]
	public Dictionary<String, BossRewards> get_Rewards() { }

	[CompilerGenerated]
	public Dictionary<String, BossSettings> get_Settings() { }

	public static string GetDailyLeaderboardId(string eventId, int dayIndex) { }

	public static string GetGlobalLeaderboardId(string eventId) { }

	public static string GetLeaderboardId(string eventId) { }

	[CompilerGenerated]
	public void set_MaxRewardClaimTime(TimeSpan value) { }

	[CompilerGenerated]
	public void set_Rewards(Dictionary<String, BossRewards> value) { }

	[CompilerGenerated]
	public void set_Settings(Dictionary<String, BossSettings> value) { }

}

