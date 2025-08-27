namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MonkeyCityIncomeSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private float multiplier; //Field offset: 0x70

		public MutatorTower(BuffIndicatorModel buffIndicatorModel, float multiplier, string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

		private float ScaleCost(float cost) { }

	}

	public MonkeyCityIncomeSupportModel monkeyCityIncomeSupportModel; //Field offset: 0x90

	public MonkeyCityIncomeSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

