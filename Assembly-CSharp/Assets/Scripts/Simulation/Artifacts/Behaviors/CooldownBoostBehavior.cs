namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class CooldownBoostBehavior : BoostArtifactBehavior
{
	public CooldownBoostBehaviorModel cooldownBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public CooldownBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

