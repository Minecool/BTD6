namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DistanceBasedCrit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DistanceBasedCritModel : ProjectileBehaviorModel
{
	public float critDamageBonusMult; //Field offset: 0x38
	public float baseCritChance; //Field offset: 0x3C
	public float bonusCritChancePerDistance; //Field offset: 0x40
	public float happyCurveInfluence; //Field offset: 0x44
	public PrefabReference textDisplayReference; //Field offset: 0x48
	public float textLifespan; //Field offset: 0x50
	public string text; //Field offset: 0x58

	public DistanceBasedCritModel(string name, float critDamageBonusMult, float baseCritChance, float bonusCritChancePerDistance, float happyCurveInfluence, PrefabReference textDisplayReference, float textLifespan, string text) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

