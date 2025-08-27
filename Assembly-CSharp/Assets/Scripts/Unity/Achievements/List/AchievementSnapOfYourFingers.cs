namespace Assets.Scripts.Unity.Achievements.List;

public class AchievementSnapOfYourFingers : ActiveAchievement
{
	public int halfStartingCash; //Field offset: 0x20
	public int halfStartingLives; //Field offset: 0x24
	public double beforeEndOfRoundCash; //Field offset: 0x28
	public double beforeEndOfRoundLives; //Field offset: 0x30

	public AchievementSnapOfYourFingers() { }

	private void OnEarlyRoundEnd(int round) { }

	public virtual void OnGameStartBeforeLoadingSave() { }

	public virtual void OnShowVictory() { }

}

