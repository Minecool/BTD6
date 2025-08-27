namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CarryProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CarryProjectileModel : BloonBehaviorModelWithTowerTracking
{
	public ProjectileModel projectile; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40

	public CarryProjectileModel() { }

	public CarryProjectileModel(string name, ProjectileModel projectile, EmissionModel emission, ObjectId tower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

