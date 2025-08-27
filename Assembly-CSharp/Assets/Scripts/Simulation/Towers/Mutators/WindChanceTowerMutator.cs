namespace Assets.Scripts.Simulation.Towers.Mutators;

public class WindChanceTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public readonly WindChanceTowerMutatorModel windChanceTowerModel; //Field offset: 0x78

		public Mutator(WindChanceTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public WindChanceTowerMutatorModel windChanceTowerMutatorModel; //Field offset: 0x68

	public WindChanceTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

