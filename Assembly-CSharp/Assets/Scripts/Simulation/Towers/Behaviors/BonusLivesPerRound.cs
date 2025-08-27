namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BonusLivesPerRound : TowerBehavior
{
	public BonusLivesPerRoundModel bonusLivesPerRoundModel; //Field offset: 0x68

	public BonusLivesPerRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int round) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

