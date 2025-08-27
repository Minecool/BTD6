namespace Assets.Scripts.Simulation.Towers.Mutators;

public class ProjectileSizeTowerMutator : TowerMutator
{
	public class Mutator : BaseMutator
	{
		public readonly ProjectileSizeTowerMutatorModel sizeModel; //Field offset: 0x78

		public Mutator(ProjectileSizeTowerMutatorModel model) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public ProjectileSizeTowerMutatorModel projectileSizeModel; //Field offset: 0x68

	public ProjectileSizeTowerMutator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

