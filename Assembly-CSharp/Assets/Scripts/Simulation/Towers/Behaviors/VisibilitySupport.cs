namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class VisibilitySupport : Support
{
	public class MutatorTower : BehaviorMutator
	{

		public MutatorTower(VisibilitySupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public VisibilitySupportModel visibilitySupportModel; //Field offset: 0x90

	public VisibilitySupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

