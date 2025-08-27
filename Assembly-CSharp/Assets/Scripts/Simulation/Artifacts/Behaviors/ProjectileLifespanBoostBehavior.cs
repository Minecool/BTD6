namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class ProjectileLifespanBoostBehavior : BoostArtifactBehavior
{
	public ProjectileLifespanBoostBehaviorModel projectileLifespanBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public ProjectileLifespanBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

