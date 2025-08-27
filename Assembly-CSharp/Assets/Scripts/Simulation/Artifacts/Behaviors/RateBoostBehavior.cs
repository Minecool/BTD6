namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class RateBoostBehavior : BoostArtifactBehavior
{
	public RateBoostBehaviorModel rateBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public RateBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

