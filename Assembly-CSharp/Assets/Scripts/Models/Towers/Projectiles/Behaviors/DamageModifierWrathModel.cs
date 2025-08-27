namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageModifierWrath), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageModifierWrathModel : DamageModifierModel
{
	public int rbeThreshold; //Field offset: 0x38
	public int damage; //Field offset: 0x3C
	public int maxDamageBoost; //Field offset: 0x40

	public DamageModifierWrathModel(string name, int rbeThreshold, int damage, int maxDamageBoost) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

