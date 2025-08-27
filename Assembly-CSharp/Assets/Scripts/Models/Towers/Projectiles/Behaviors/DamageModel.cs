namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Damage), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModel : ProjectileBehaviorModel
{
	public float damage; //Field offset: 0x38
	public float maxDamage; //Field offset: 0x3C
	public bool distributeToChildren; //Field offset: 0x40
	public bool overrideDistributeBlocker; //Field offset: 0x41
	public bool createPopEffect; //Field offset: 0x42
	public BloonProperties immuneBloonProperties; //Field offset: 0x44
	public BloonProperties immuneBloonPropertiesOriginal; //Field offset: 0x48
	public bool ignoreImmunityDestroy; //Field offset: 0x4C
	public bool ignoreDamageMultipliers; //Field offset: 0x4D

	public float CappedDamage
	{
		 get { } //Length: 134
	}

	public DamageModel(string name, float damage, float maxDamage, bool distributeToChildren, bool overrideDistributeBlocker, bool createPopEffect, BloonProperties immuneBloonProperties, BloonProperties immuneBloonPropertiesOriginal, bool ignoreImmunityDestroy, bool ignoreDamageMultipliers) { }

	public float CapDamage(float _damage) { }

	public virtual Model Clone() { }

	public float get_CappedDamage() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

