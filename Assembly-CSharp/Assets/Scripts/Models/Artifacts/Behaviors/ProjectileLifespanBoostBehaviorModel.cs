namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(ProjectileLifespanBoostBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileLifespanBoostBehaviorModel : BoostArtifactBehaviorModel
{
	internal class ProjectileLifespanMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public ProjectileLifespanMutator(bool isUnique, string mutatorId, float multiplier, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}


	public ProjectileLifespanBoostBehaviorModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

