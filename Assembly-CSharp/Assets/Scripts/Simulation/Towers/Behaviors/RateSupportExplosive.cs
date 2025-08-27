namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RateSupportExplosive : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly RateSupportExplosive parent; //Field offset: 0x70

		public MutatorTower(RateSupportExplosive parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public RateSupportExplosiveModel rateSupportExplosiveModel; //Field offset: 0x90

	public RateSupportExplosive() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

