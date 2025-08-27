namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(GiveCritChanceBoostBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GiveCritChanceBoostBehaviorModel : BoostArtifactBehaviorModel
{
	internal class AddCritChanceAndMultiplyMutator : BehaviorMutator
	{
		private CritMultiplierModel critModel; //Field offset: 0x70
		private ShowTextOnHitModel hitTextModel; //Field offset: 0x78
		private float multiplier; //Field offset: 0x80
		private bool overridesExistingCrit; //Field offset: 0x84

		public AddCritChanceAndMultiplyMutator(string mutatorId, bool isUnique, CritMultiplierModel critModel, float multiplier, ShowTextOnHitModel hitTextModel, bool overridesExistingCrit) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int upper; //Field offset: 0x38
	public int lower; //Field offset: 0x3C
	public bool distributeToChildren; //Field offset: 0x40
	public PrefabReference critTextPrefab; //Field offset: 0x48
	public string critText; //Field offset: 0x50
	public bool critTextUseTowerPosition; //Field offset: 0x58
	public float critTextLifeSpan; //Field offset: 0x5C
	public ShowTextOnHitModel showTextOnHitModel; //Field offset: 0x60
	public CritMultiplierModel critModel; //Field offset: 0x68
	public bool overridesExistingCrit; //Field offset: 0x70

	public GiveCritChanceBoostBehaviorModel(string name, float multiplier, int upper, int lower, bool distributeToChildren, PrefabReference critTextPrefab, string critText, bool critTextUseTowerPosition, float critTextLifeSpan, bool overridesExisitingCrit) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

