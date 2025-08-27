namespace Assets.Scripts.Simulation.Towers.Mutators;

public class DamageTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public readonly DamageTowerMutatorModel damageModel; //Field offset: 0x78

		public Mutator(DamageTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DamageTowerMutatorModel damageTowerMutatorModel; //Field offset: 0x68

	public DamageTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

