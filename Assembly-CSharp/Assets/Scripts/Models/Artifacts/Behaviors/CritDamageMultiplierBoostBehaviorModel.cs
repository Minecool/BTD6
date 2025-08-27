namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(CritDamageMultiplierBoostBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CritDamageMultiplierBoostBehaviorModel : BoostArtifactBehaviorModel
{
	internal class CritDamageMultiplierMutator : BehaviorMutator
	{
		private float multiplier; //Field offset: 0x70

		public CritDamageMultiplierMutator(string mutatorId, bool isUnique, float multiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}


	public CritDamageMultiplierBoostBehaviorModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

