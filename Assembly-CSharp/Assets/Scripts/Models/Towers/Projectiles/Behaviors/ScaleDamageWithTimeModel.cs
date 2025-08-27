namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ScaleDamageWithTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ScaleDamageWithTimeModel : DamageModifierModel
{
	public float maxDamage; //Field offset: 0x38
	public float scalePerSecond; //Field offset: 0x3C
	public float baseDamage; //Field offset: 0x40

	public ScaleDamageWithTimeModel(string name, float maxDamage, float scalePerSecond, float baseDamage) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

