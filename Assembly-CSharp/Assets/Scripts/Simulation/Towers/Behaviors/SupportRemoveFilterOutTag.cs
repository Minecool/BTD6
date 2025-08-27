namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SupportRemoveFilterOutTag : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly string removeScriptsWithSupportMutatorId; //Field offset: 0x70

		public MutatorTower(string mutatorId, string removeScriptsWithSupportMutatorId, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public SupportRemoveFilterOutTagModel supportRemoveFilterOutTagModel; //Field offset: 0x90

	public SupportRemoveFilterOutTag() { }

	public virtual bool Filter(RootBehavior behavior) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

