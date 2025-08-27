namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DamageOverTimeDurationSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly DamageOverTimeDurationSupport parent; //Field offset: 0x70

		public MutatorTower(DamageOverTimeDurationSupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DamageOverTimeDurationSupportModel damageOverTimeDurationSupportModel; //Field offset: 0x90

	public DamageOverTimeDurationSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

