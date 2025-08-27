namespace Assets.Scripts.Simulation.Towers.Mutators;

public class PierceTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public readonly PierceTowerMutatorModel pierceModel; //Field offset: 0x78

		public Mutator(PierceTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PierceTowerMutatorModel pierceTowerMutatorModel; //Field offset: 0x68

	public PierceTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

