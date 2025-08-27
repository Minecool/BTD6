namespace Assets.Scripts.Unity.Achievements;

public class AchievementManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public KeyValuePair<Int32, Single> achievementProgress; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <LoadFromPlayer>b__0(ActiveAchievement element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_1
	{
		public int achievementClaimed; //Field offset: 0x10

		public <>c__DisplayClass11_1() { }

		internal bool <LoadFromPlayer>b__1(ActiveAchievement element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Achievement achievementModel; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <CreateAchievement>b__0(ActiveAchievement element) { }

	}

	private readonly List<ActiveAchievement> activeAchievements; //Field offset: 0x20

	public AchievementManager() { }

	public LootSet ClaimAchievementReward(ActiveAchievement achievement) { }

	private void CreateAchievement(Achievement achievementModel) { }

	public List<ActiveAchievement> GetAchievements() { }

	public void IncreaseAchievementProgress(int achievementId, float progressIncrease = 1) { }

	public void Initialise(ILocProvider locProvider) { }

	public void LoadFromPlayer(Btd6Player player, List<ActiveAchievement> achievementList) { }

	public void LoadPlayerData(Btd6Player player) { }

	public void SetAchievementProgress(int achievementId, float progress) { }

	private bool TryGetActiveAchievement(int id, out ActiveAchievement outVar) { }

	public void UpdateWithPlayerData(Btd6Player player) { }

}

