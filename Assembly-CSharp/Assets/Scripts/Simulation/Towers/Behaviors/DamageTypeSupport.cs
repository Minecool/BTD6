namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DamageTypeSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private BloonProperties immuneBloonProperties; //Field offset: 0x70

		public MutatorTower(string id, bool isUnique, BuffIndicatorModel buffIndicator, BloonProperties immuneBloonProperties) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DamageTypeSupportModel damageTypeSupportModel; //Field offset: 0x90

	public DamageTypeSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

