namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PiercePercentageSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly PiercePercentageSupport parent; //Field offset: 0x70

		public MutatorTower(PiercePercentageSupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PiercePercentageSupportModel piercePercentageSupportModel; //Field offset: 0x90

	public PiercePercentageSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

