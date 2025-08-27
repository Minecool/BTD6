namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DamageSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly float increase; //Field offset: 0x70

		public MutatorTower(float increase, bool isUnique, string mutatorId, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DamageSupportModel damageSupportModel; //Field offset: 0x90

	public DamageSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

