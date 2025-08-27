namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateTowerDamageSupportZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateTowerDamageSupportZoneModel : AbilityBehaviorBuffModel
{
	public float range; //Field offset: 0x48
	public float damageIncrease; //Field offset: 0x4C
	public float maxNumTowersModified; //Field offset: 0x50
	public string mutatorId; //Field offset: 0x58
	public bool isUnique; //Field offset: 0x60
	public bool canEffectThisTower; //Field offset: 0x61
	[SerializeField]
	private float lifespan; //Field offset: 0x64
	public float lifespanFrames; //Field offset: 0x68
	public DisplayModel displayModel; //Field offset: 0x70
	public BloonProperties immuneBloonProperties; //Field offset: 0x78
	public bool replaceImmuneBloonProperties; //Field offset: 0x7C
	public bool useTowerRange; //Field offset: 0x7D
	public TowerFilterModel[] filters; //Field offset: 0x80

	public ActivateTowerDamageSupportZoneModel(string name, string mutatorId, bool isUnique, float damageIncrease, float range, float maxNumTowersModified, bool canEffectThisTower, float lifespan, DisplayModel addEffectToTowersAffected, string buffLocsName, string buffIconName, BloonProperties immuneBloonProperties, bool replaceImmuneBloonProperties, bool useTowerRange, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

