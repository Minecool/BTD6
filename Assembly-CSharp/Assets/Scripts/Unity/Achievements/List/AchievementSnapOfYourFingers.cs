namespace Assets.Scripts.Unity.Achievements.List;

public class AchievementSnapOfYourFingers : ActiveAchievement
{
	public int halfStartingCash; //Field offset: 0x20
	public int halfStartingLives; //Field offset: 0x24

	public AchievementSnapOfYourFingers() { }

	public virtual void OnGameStartBeforeLoadingSave() { }

	public virtual void OnShowVictory() { }

}

