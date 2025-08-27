namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageInRingRadius), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageInRingRadiusModel : DamageModel
{
	public float innerRingRadius; //Field offset: 0x50

	public DamageInRingRadiusModel(string name, float damage, float maxDamage, bool distributeToChildren, bool overrideDistributeBlocker, bool createPopEffect, float innerRingRadius, BloonProperties immuneBloonProperties, BloonProperties immuneBloonPropertiesOriginal, bool ignoreImmunityDestroy, bool ignoreDamageMultipliers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

