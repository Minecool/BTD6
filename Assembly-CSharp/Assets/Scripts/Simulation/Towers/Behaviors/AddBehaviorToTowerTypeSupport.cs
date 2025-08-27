namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AddBehaviorToTowerTypeSupport : AddBehaviorToTowerSupport
{
	public class MutatorTowerTyped : MutatorTower
	{
		private readonly string towerTypes; //Field offset: 0x78

		public MutatorTowerTyped(string towerTypes, TowerBehaviorModel[] behaviors, string mutationId, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AddBehaviorToTowerTypeSupportModel addBehaviorToTowerTypeSupportModel; //Field offset: 0x98

	public AddBehaviorToTowerTypeSupport() { }

	protected virtual void AddMutator(Tower behavior) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

