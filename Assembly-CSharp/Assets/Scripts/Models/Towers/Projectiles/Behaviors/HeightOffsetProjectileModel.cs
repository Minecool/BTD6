namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(HeightOffsetProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeightOffsetProjectileModel : ProjectileBehaviorModel
{
	public Single[] samples; //Field offset: 0x38
	public Curve curve; //Field offset: 0x40

	public HeightOffsetProjectileModel(string name, Single[] samples) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

