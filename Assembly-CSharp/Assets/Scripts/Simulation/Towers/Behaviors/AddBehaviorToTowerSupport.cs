namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AddBehaviorToTowerSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly TowerBehaviorModel[] behaviors; //Field offset: 0x70

		public MutatorTower(TowerBehaviorModel[] behaviors, string mutationId, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AddBehaviorToTowerSupportModel addBehaviorToTowerSupportModel; //Field offset: 0x90

	public AddBehaviorToTowerSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

