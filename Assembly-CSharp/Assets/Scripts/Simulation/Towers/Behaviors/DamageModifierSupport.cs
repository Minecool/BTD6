namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DamageModifierSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly DamageModifierModel damageModifierModel; //Field offset: 0x70

		public MutatorTower(DamageModifierModel damageModifierModel, bool isUnique, string mutatorId, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DamageModifierSupportModel damageModifierSupportModel; //Field offset: 0x90

	public DamageModifierSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

