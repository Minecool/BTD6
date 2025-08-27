namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateDamageModifierSupportZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateDamageModifierSupportZoneModel : AbilityBehaviorBuffModel
{
	public string mutatorId; //Field offset: 0x48
	public bool isUnique; //Field offset: 0x50
	public float range; //Field offset: 0x54
	public float maxNumTowersModified; //Field offset: 0x58
	public bool canAffectThisTower; //Field offset: 0x5C
	[SerializeField]
	private float lifespan; //Field offset: 0x60
	public float lifespanFrames; //Field offset: 0x64
	public DamageModifierModel damageModifierModel; //Field offset: 0x68
	public TowerFilterModel[] filters; //Field offset: 0x70

	public ActivateDamageModifierSupportZoneModel(string name, string mutatorId, bool isUnique, float range, float maxNumTowersModified, bool canAffectThisTower, float lifespan, DamageModifierModel damageModifierModel, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

