namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ProjectileSpeedSupport : Support
{
	internal class ProjectileSpeedSupportMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public ProjectileSpeedSupportMutator(float multiplier, bool isUnique, string mutatorId, int priority, BuffIndicatorModel buffIndicator, bool isArtifactMutator = false) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public ProjectileSpeedSupportModel projectileSpeedSupportModel; //Field offset: 0x90

	public ProjectileSpeedSupport() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

