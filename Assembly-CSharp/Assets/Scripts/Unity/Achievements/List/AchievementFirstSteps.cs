namespace Assets.Scripts.Unity.Achievements.List;

public class AchievementFirstSteps : ActiveAchievement
{
	public const string tutorialQuestID = "1stTutorial"; //Field offset: 0x0

	public AchievementFirstSteps() { }

	public virtual void UpdateProgress(Btd6Player player, AnalyticsKonFuze analyticsInfo) { }

}

