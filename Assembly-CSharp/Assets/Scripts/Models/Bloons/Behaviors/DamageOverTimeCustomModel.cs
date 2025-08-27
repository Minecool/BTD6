namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DamageOverTimeCustom), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageOverTimeCustomModel : DamageOverTimeModel
{
	public String[] bloonTagsList; //Field offset: 0x80
	public float multiplier; //Field offset: 0x88
	public float additive; //Field offset: 0x8C

	public DamageOverTimeCustomModel(string name, float damage, float interval, BloonProperties immuneBloonProperties, BloonProperties immuneBloonPropertiesOriginal, PrefabReference displayPath, float displayLifetime, bool triggerImmediate, String[] bloonTagsList, float multiplier, float additive, ObjectId tower, bool rotateEffectWithBloon, float initialDelay, bool damageOnDestroy, bool overrideDistributionBlocker, DamageModifierModel[] damageModifierModels, bool isFireBased) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

