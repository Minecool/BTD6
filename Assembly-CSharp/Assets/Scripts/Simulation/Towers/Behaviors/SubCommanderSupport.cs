namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SubCommanderSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly SubCommanderSupport parent; //Field offset: 0x70

		public MutatorTower(SubCommanderSupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const int mutatorPriority = 999; //Field offset: 0x0
	public SubCommanderSupportModel subCommandSupportModel; //Field offset: 0x90

	public SubCommanderSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

