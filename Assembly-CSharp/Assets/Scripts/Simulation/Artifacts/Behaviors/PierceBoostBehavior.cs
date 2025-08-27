namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class PierceBoostBehavior : BoostArtifactBehavior
{
	internal class PierceBoostMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public PierceBoostMutator(bool isUnique, string mutatorId, float multiplier, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PierceBoostBehaviorModel pierceBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public PierceBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

