namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectileOnExpire), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnExpireModel : ProjectileBehaviorModel
{
	[ExtendedDrawer]
	public ProjectileModel projectile; //Field offset: 0x38
	[ExtendedDrawer]
	public EmissionModel emission; //Field offset: 0x40
	public bool useRotation; //Field offset: 0x48
	public bool useTargetPosition; //Field offset: 0x49

	public CreateProjectileOnExpireModel(string name, ProjectileModel projectile, EmissionModel emission, bool useRotation, bool useTargetPosition) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

