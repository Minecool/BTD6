namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AbilityCooldownScaleSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly AbilityCooldownScaleSupport parent; //Field offset: 0x70
		public float abilityCooldownSpeedScale; //Field offset: 0x78

		public MutatorTower(AbilityCooldownScaleSupport parent, float abilityCooldownSpeedScale, string id = "AbilityCooldownScaleSupport") { }

		private bool BuffTowerModel(TowerModel towerModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public AbilityCooldownScaleSupportModel abilityCooldownScaleSupportModel; //Field offset: 0x90

	public AbilityCooldownScaleSupport() { }

	public virtual bool Filter(RootBehavior behavior) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

