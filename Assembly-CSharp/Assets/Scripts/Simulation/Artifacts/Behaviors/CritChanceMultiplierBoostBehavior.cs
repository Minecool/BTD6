namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class CritChanceMultiplierBoostBehavior : BoostArtifactBehavior
{
	public CritChanceMultiplierBoostBehaviorModel critChanceMultiplierBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public CritChanceMultiplierBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

