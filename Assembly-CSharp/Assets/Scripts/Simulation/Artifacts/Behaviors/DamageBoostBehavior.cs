namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class DamageBoostBehavior : BoostArtifactBehavior
{
	internal class DamageBoostMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public DamageBoostMutator(bool isUnique, string mutatorId, float multiplier, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DamageBoostBehaviorModel damageBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public DamageBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

