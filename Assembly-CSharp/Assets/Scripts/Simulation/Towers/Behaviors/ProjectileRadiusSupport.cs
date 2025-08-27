namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ProjectileRadiusSupport : Support
{
	public class MutatorTower : BehaviorMutator
	{
		private const int MAX_VALUE = 999999; //Field offset: 0x0
		private readonly ProjectileRadiusSupport parent; //Field offset: 0x70

		public MutatorTower(ProjectileRadiusSupport parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public ProjectileRadiusSupportModel projectileRadiusSupportModel; //Field offset: 0x90

	public ProjectileRadiusSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

