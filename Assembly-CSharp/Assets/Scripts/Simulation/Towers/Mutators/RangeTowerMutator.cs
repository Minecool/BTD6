namespace Assets.Scripts.Simulation.Towers.Mutators;

public class RangeTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public readonly RangeTowerMutatorModel rangeTowerModel; //Field offset: 0x78

		public Mutator(RangeTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public RangeTowerMutatorModel rangeTowerMutatorModel; //Field offset: 0x68

	public RangeTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

