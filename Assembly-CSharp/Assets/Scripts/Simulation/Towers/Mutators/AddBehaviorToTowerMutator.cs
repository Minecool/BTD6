namespace Assets.Scripts.Simulation.Towers.Mutators;

public class AddBehaviorToTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public AddBehaviorToTowerMutatorModel addBehaviorToTowerModel; //Field offset: 0x78

		public Mutator(AddBehaviorToTowerMutatorModel addBehaviorToTowerModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AddBehaviorToTowerMutatorModel addBehaviorToTowerModel; //Field offset: 0x68

	public AddBehaviorToTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

