namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamagePercentOfMax), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamagePercentOfMaxModel : DamageModifierModel
{
	public float percent; //Field offset: 0x38
	public String[] tags; //Field offset: 0x40
	public bool damageBloonsOffscreenOnly; //Field offset: 0x48

	public DamagePercentOfMaxModel(string name, float percent, String[] tags, bool damageBloonsOffscreenOnly) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

