namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class TowerCashBoostBehavior : BoostArtifactBehavior
{
	public TowerCashBoostBehaviorModel towerCashBoostBehaviorModel; //Field offset: 0x78
	private MutatorTower mutator; //Field offset: 0x80

	public TowerCashBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

}

