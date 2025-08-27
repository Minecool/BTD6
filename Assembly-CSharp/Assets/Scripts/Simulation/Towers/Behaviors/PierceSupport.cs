namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PierceSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly PierceSupport parent; //Field offset: 0x70

		public MutatorTower(PierceSupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PierceSupportModel pierceSupportModel; //Field offset: 0x90

	public PierceSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

