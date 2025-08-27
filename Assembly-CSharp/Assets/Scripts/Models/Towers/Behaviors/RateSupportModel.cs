namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RateSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RateSupportModel : SupportModel
{
	internal class RateSupportMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70
		private readonly DisplayModel buffDisplayModel; //Field offset: 0x78

		public RateSupportMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator, bool isArtifactMutator = false, DisplayModel buffDisplayModel = null) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float multiplier; //Field offset: 0x60
	public bool isUnique; //Field offset: 0x64
	public string mutatorId; //Field offset: 0x68
	public int priority; //Field offset: 0x70
	public DisplayModel buffDisplayModel; //Field offset: 0x78

	public RateSupportModel(string name, float multiplier, bool isUnique, string mutatorId, bool isGlobal, int priority, TowerFilterModel[] filters, string buffLocsName, string buffIconName, bool onlyAffectParagon = false, DisplayModel buffDisplayModel = null) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

