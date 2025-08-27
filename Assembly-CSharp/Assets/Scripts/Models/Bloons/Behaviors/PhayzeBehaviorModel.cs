namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PhayzeBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PhayzeBehaviorModel : BloonBehaviorModel
{
	internal class AddCamoMutator : BehaviorMutator
	{

		public AddCamoMutator(string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class RemoveCamoDetectionTowerMutator : BehaviorMutator
	{
		public DisplayModel towerDisplayModel; //Field offset: 0x70

		public RemoveCamoDetectionTowerMutator(string id, DisplayModel towerDisplayModel) { }

		public virtual bool CountBuffTowardsAchievement() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string speedBoostMutatorID = "ShieldSpeedBoost"; //Field offset: 0x0
	public Single[] powerLevels; //Field offset: 0x30
	public float shieldSpeedBoost; //Field offset: 0x38
	public string enterCamoAnimationName; //Field offset: 0x40
	public string enterCamoImmunityAnimationName; //Field offset: 0x48
	public string exitCamoImmunityAnimationName; //Field offset: 0x50
	public string exitCamoAnimationName; //Field offset: 0x58
	public PrefabReference camoRemovalTowerDisplay; //Field offset: 0x60
	public DisplayModel camoRemovalTowerDisplayModel; //Field offset: 0x68
	private AddCamoMutator camoMutator; //Field offset: 0x70
	private SpeedPercentMutator speedMutator; //Field offset: 0x78
	private RemoveCamoDetectionTowerMutator camoDetectionTowerMutator; //Field offset: 0x80

	public RemoveCamoDetectionTowerMutator CamoDetectionTowerMutator
	{
		 get { } //Length: 260
	}

	public AddCamoMutator CamoMutator
	{
		 get { } //Length: 228
	}

	public SpeedPercentMutator SpeedMutator
	{
		 get { } //Length: 140
	}

	public PhayzeBehaviorModel() { }

	public PhayzeBehaviorModel(string name, Single[] powerLevels, string enterCamoAnimationName, string enterCamoImmunityAnimationName, string exitCamoImmunityAnimationName, string exitCamoAnimationName, float shieldSpeedBoost, PrefabReference camoRemovalTowerDisplay) { }

	public virtual Model Clone() { }

	public List<RateSupportMutator> CreateDebuffMutators() { }

	public RemoveCamoDetectionTowerMutator get_CamoDetectionTowerMutator() { }

	public AddCamoMutator get_CamoMutator() { }

	public SpeedPercentMutator get_SpeedMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

