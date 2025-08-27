namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageModifierForBloonType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModifierForBloonTypeModel : DamageModifierModel
{
	public string bloonId; //Field offset: 0x38
	public float damageMultiplier; //Field offset: 0x40
	public float damageAdditive; //Field offset: 0x44
	public bool includeChildren; //Field offset: 0x48

	public DamageModifierForBloonTypeModel(string name, string bloonId, float damageMultiplier, float damageAdditive, bool includeChildren) { }

	public virtual Model Clone() { }

	public virtual float GetDamageAdditive(Bloon bloon) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

