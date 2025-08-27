namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class HeroXpScaleSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly HeroXpScaleSupport parent; //Field offset: 0x70

		public MutatorTower(HeroXpScaleSupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public HeroXpScaleSupportModel heroXpScaleSupportModel; //Field offset: 0x90

	public HeroXpScaleSupport() { }

	public virtual bool Filter(RootBehavior behavior) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

