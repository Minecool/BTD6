namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateTempTargetPrioSupportZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateTempTargetPrioSupportZoneModel : AbilityBehaviorBuffModel
{
	internal class TempTargetPrioMutator : BehaviorMutator
	{
		private TargetSupplierModel targetSupplierModel; //Field offset: 0x70
		private DisplayModel displayModel; //Field offset: 0x78
		private float accuracyImprovementPercent; //Field offset: 0x80

		public TempTargetPrioMutator(string mutatorId, bool isUnique, BuffIndicatorModel buffIndicator, TargetSupplierModel targetSupplierModel, DisplayModel displayModel, float accuracyImprovementPercent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float range; //Field offset: 0x48
	public float rateModifier; //Field offset: 0x4C
	public float maxNumTowersModified; //Field offset: 0x50
	public string mutatorId; //Field offset: 0x58
	public bool isUnique; //Field offset: 0x60
	public bool canEffectThisTower; //Field offset: 0x61
	[SerializeField]
	private float lifespan; //Field offset: 0x64
	public float lifespanFrames; //Field offset: 0x68
	public DisplayModel displayModel; //Field offset: 0x70
	public TowerFilterModel[] filters; //Field offset: 0x78
	public bool useTowerRange; //Field offset: 0x80
	public TargetSupplierModel targetSupplierModel; //Field offset: 0x88
	public float accuracyImprovementPercent; //Field offset: 0x90

	public ActivateTempTargetPrioSupportZoneModel(string name, string mutatorId, bool isUnique, float range, float maxNumTowersModified, bool canEffectThisTower, float lifespan, DisplayModel addEffectToTowersAffected, string buffLocsName, string buffIconName, TowerFilterModel[] filters, bool useTowerRange, TargetSupplierModel targetSupplierModel, float accuracyImprovementPercent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

