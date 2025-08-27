namespace Assets.Scripts.Unity.Achievements.List;

public class AchievementRisingStar : ActiveAchievement
{
	private const int fiveMinutes = 300; //Field offset: 0x0

	public AchievementRisingStar() { }

	public virtual void UpdateProgress(Btd6Player player, AnalyticsKonFuze analyticsInfo) { }

}

