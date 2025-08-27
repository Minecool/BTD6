namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(EmitOnDamage), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmitOnDamageModel : ProjectileBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40

	public EmitOnDamageModel(string name, EmissionModel emission, ProjectileModel projectile) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

