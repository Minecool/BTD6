namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MonkeySubParagonSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private readonly MonkeySubParagonSupport parent; //Field offset: 0x70

		public MutatorTower(MonkeySubParagonSupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public MonkeySubParagonSupportModel monkeySubParagonSupportModel; //Field offset: 0x90

	public MonkeySubParagonSupport() { }

	public virtual bool CanShowInactiveBuffIcon(Vector2 position, TowerModel forTowerModel) { }

	public virtual bool Filter(RootBehavior behavior) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

