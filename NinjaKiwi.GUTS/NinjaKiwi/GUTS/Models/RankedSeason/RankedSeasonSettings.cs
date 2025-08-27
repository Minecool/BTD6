namespace NinjaKiwi.GUTS.Models.RankedSeason;

public class RankedSeasonSettings
{
	[Nullable(0)]
	[NullableContext(1)]
	internal static class WalletKeys
	{
		public const string WalletId = "RankSeason"; //Field offset: 0x0
		public const string SeasonId = "SeasonId"; //Field offset: 0x0
		public const string Tier = "Tier"; //Field offset: 0x0
		public const string Points = "Points"; //Field offset: 0x0
		public const string AvailableRewardTier = "AvailableRewardTier"; //Field offset: 0x0
		public const string ClaimedRewardTier = "ClaimedRewardTier"; //Field offset: 0x0
		public const string WinStreak = "WinStreak"; //Field offset: 0x0
		public const string SeenEndScreen = "SeenEndScreen"; //Field offset: 0x0

	}

	public const int kTierRewardIdMultiplier = 1000000; //Field offset: 0x0
	[CompilerGenerated]
	private int <WinStreak>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <WinStreakMultiplier>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1, 1}])]
	private Dictionary<String, Dictionary`2<Int32, RankedSeasonTierSettings>> <TierSettings>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1, 1}])]
	public Dictionary<String, Dictionary`2<Int32, RankedSeasonTierSettings>> TierSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int WinStreak
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float WinStreakMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public RankedSeasonSettings() { }

	[CompilerGenerated]
	public Dictionary<String, Dictionary`2<Int32, RankedSeasonTierSettings>> get_TierSettings() { }

	[CompilerGenerated]
	public int get_WinStreak() { }

	[CompilerGenerated]
	public float get_WinStreakMultiplier() { }

	[CompilerGenerated]
	public void set_TierSettings(Dictionary<String, Dictionary`2<Int32, RankedSeasonTierSettings>> value) { }

	[CompilerGenerated]
	public void set_WinStreak(int value) { }

	[CompilerGenerated]
	public void set_WinStreakMultiplier(float value) { }

}

