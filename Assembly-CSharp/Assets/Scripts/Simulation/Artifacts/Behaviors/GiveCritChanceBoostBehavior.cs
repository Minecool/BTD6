namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class GiveCritChanceBoostBehavior : BoostArtifactBehavior
{
	public GiveCritChanceBoostBehaviorModel critChanceApplicationBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public GiveCritChanceBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

