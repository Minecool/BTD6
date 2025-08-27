namespace Assets.Scripts.Models.ServerEvents;

[Extension]
public static class DailyChallengeExtensions
{

	[Extension]
	public static string GetContinueMapSaveId(ChallengeType chalType, bool isCoop, Nullable<BossType> bossChallengeType = null) { }

	[Extension]
	public static string GetMapSaveId(ChallengeType chalType, bool isCoop = false, Nullable<BossType> bossChallengeType = null) { }

	[Extension]
	public static string GetTowerId(TowerData tower) { }

	[Extension]
	public static string GetVerifiedHeroSelection(string selectedSkin, List<String> limitedHeroSelection, IEnumerable<String> unlockedHeroes, PlayerCosmeticInfo cosmetics) { }

	[Extension]
	public static bool IsChosenHero(TowerData tower) { }

}

