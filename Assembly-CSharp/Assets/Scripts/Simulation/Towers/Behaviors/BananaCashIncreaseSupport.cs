namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BananaCashIncreaseSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private BananaCashIncreaseSupportModel bananaCashIncreaseSupportModel; //Field offset: 0x70

		public MutatorTower(BananaCashIncreaseSupportModel parentModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public BananaCashIncreaseSupportModel bananaCashIncreaseSupportModel; //Field offset: 0x90

	public BananaCashIncreaseSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

