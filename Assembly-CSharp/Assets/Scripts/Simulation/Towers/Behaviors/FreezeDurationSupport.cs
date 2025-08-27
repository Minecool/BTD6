namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class FreezeDurationSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly float additive; //Field offset: 0x70
		private readonly float multiplier; //Field offset: 0x74

		public MutatorTower(bool isUnique, string mutatorId, float additive, float multiplier, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public FreezeDurationSupportModel freezeSupportModel; //Field offset: 0x90

	public FreezeDurationSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

