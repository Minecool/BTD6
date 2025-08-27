namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ScaleProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ScaleProjectileModel : ProjectileBehaviorModel
{
	public Single[] samples; //Field offset: 0x38
	public Curve curve; //Field offset: 0x40

	public ScaleProjectileModel(string name, Single[] samples) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

