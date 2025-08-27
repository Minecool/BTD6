namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class FootprintZone : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly FootprintZone parent; //Field offset: 0x70

		public MutatorTower(FootprintZone parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public FootprintZoneModel footprintSupportModel; //Field offset: 0x90

	public FootprintZone() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

