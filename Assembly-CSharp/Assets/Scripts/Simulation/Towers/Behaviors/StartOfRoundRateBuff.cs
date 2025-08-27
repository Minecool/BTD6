namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class StartOfRoundRateBuff : TowerBehavior
{
	public StartOfRoundRateBuffModel startOfRoundRateBuffModel; //Field offset: 0x68

	public StartOfRoundRateBuff() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundStartSim(int roundNumber) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

