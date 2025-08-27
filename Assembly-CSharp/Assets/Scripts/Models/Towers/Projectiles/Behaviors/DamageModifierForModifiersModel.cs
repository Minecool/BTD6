namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageModifierForModifiers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModifierForModifiersModel : DamageModifierModel
{
	public string modifier; //Field offset: 0x38
	public String[] modifiers; //Field offset: 0x40
	public float damageMultiplier; //Field offset: 0x48
	public float damageAddative; //Field offset: 0x4C

	public DamageModifierForModifiersModel(string name, string modifier, float damageMultiplier, float damageAddative) { }

	public virtual Model Clone() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

