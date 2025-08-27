namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RateSupportBombExpert : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly RateSupportBombExpert parent; //Field offset: 0x70

		public MutatorTower(RateSupportBombExpert parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public RateSupportBombExpertModel rateSupportBombExpertModel; //Field offset: 0x90

	public RateSupportBombExpert() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

