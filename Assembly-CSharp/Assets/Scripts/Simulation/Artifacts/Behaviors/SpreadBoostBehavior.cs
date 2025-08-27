namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class SpreadBoostBehavior : BoostArtifactBehavior
{
	internal class SpreadBoostMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public SpreadBoostMutator(bool isUnique, string mutatorId, float multiplier, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public SpreadBoostBehaviorModel spreadBoostBehaviorModel; //Field offset: 0x78
	private BehaviorMutator mutator; //Field offset: 0x80

	public SpreadBoostBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual BehaviorMutator Mutator() { }

	protected virtual void OnDestroy() { }

}

