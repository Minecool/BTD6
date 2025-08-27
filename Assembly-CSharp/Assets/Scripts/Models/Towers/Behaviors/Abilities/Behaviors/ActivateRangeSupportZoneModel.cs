namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateRangeSupportZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateRangeSupportZoneModel : AbilityBehaviorBuffModel
{
	public string mutatorId; //Field offset: 0x48
	public bool isUnique; //Field offset: 0x50
	public float multiplier; //Field offset: 0x54
	public float additive; //Field offset: 0x58
	public float range; //Field offset: 0x5C
	public float maxNumTowersModified; //Field offset: 0x60
	public bool canAffectThisTower; //Field offset: 0x64
	[SerializeField]
	private float lifespan; //Field offset: 0x68
	public float lifespanFrames; //Field offset: 0x6C
	public TowerFilterModel[] filters; //Field offset: 0x70

	public ActivateRangeSupportZoneModel(string name, string mutatorId, bool isUnique, float multiplier, float additive, float range, float maxNumTowersModified, bool canAffectThisTower, float lifespan, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

