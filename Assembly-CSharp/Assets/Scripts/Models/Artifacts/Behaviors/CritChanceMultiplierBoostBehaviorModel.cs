namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(CritChanceMultiplierBoostBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CritChanceMultiplierBoostBehaviorModel : BoostArtifactBehaviorModel
{
	internal class CritChanceMultiplierMutator : BehaviorMutator
	{
		private float multiplier; //Field offset: 0x70

		public CritChanceMultiplierMutator(string mutatorId, bool isUnique, float multiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}


	public CritChanceMultiplierBoostBehaviorModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

