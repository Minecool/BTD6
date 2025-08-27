namespace Assets.Scripts.Simulation.Towers.Mutators;

public class AddTowerToTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public TowerModel towerModel; //Field offset: 0x78

		public Mutator(TowerModel tower, string mutationId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AddTowerToTowerMutatorModel addTowerToTowerMutatorModel; //Field offset: 0x68

	public AddTowerToTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

