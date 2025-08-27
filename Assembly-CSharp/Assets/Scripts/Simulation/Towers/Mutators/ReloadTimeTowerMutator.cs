namespace Assets.Scripts.Simulation.Towers.Mutators;

public class ReloadTimeTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public readonly ReloadTimeTowerMutatorModel reloadTimeModel; //Field offset: 0x78

		public Mutator(ReloadTimeTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public ReloadTimeTowerMutatorModel reloadTimeTowerMutatorModel; //Field offset: 0x68

	public ReloadTimeTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

