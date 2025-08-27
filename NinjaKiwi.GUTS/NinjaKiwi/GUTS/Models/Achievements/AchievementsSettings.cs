namespace NinjaKiwi.GUTS.Models.Achievements;

public class AchievementsSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public AchievementDetails achievementDetails; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal long <TryGetAchievementProgress>g__GetAchievementStats|0(KeyValuePair<String, Int64> statKeyScore) { }

	}

	[JsonIgnore]
	public const string kAchievementsWalletId = "ClaimedAchievements"; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, AchievementDetails> <Achievements>k__BackingField; //Field offset: 0x18

	public Dictionary<String, AchievementDetails> Achievements
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

	public AchievementsSettings() { }

	[CompilerGenerated]
	public Dictionary<String, AchievementDetails> get_Achievements() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	private static bool IsMatchingStatKey(string skuSettingStatKey, string statKey) { }

	[OnDeserialized]
	public void OnDeserialized(StreamingContext context = null) { }

	[CompilerGenerated]
	public void set_Achievements(Dictionary<String, AchievementDetails> value) { }

	[CompilerGenerated]
	public void set_IsEnabled(bool value) { }

	public bool TryGetAchievementDetails(string achievementId, out AchievementDetails achievementDetails) { }

	public bool TryGetAchievementProgress(string achievementId, Dictionary<String, Int64> statsWallet, out AchievementProgress achievementProgress) { }

}

