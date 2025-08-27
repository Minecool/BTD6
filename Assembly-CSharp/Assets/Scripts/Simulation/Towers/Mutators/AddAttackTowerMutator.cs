namespace Assets.Scripts.Simulation.Towers.Mutators;

public class AddAttackTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public AddAttackTowerMutatorModel attackModel; //Field offset: 0x78

		public Mutator(AddAttackTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AddAttackTowerMutatorModel addAttackTowerMutatorModel; //Field offset: 0x68

	public AddAttackTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

