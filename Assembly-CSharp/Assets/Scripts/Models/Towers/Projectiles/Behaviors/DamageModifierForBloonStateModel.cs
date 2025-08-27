namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageModifierForBloonState), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModifierForBloonStateModel : DamageModifierModel
{
	public string bloonState; //Field offset: 0x38
	public String[] bloonStates; //Field offset: 0x40
	public float damageMultiplier; //Field offset: 0x48
	public float damageAdditive; //Field offset: 0x4C
	public bool mustIncludeAllStates; //Field offset: 0x50
	public bool applyOverMaxDamage; //Field offset: 0x51
	public bool mustBeModified; //Field offset: 0x52

	public DamageModifierForBloonStateModel(string name, string bloonState, float damageMultiplier, float damageAddative, bool mustIncludeAllTags, bool applyOverMaxDamage, bool mustBeModified) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

