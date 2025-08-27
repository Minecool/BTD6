namespace Assets.Scripts.Unity.Achievements.List;

public class AchievementTopOfYourGame : ActiveAchievement
{
	private const int threeMinutes = 180; //Field offset: 0x0

	public AchievementTopOfYourGame() { }

	public virtual void UpdateProgress(Btd6Player player, AnalyticsKonFuze analyticsInfo) { }

}

