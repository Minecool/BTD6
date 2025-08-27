namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectileOnBlockerCollide), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnBlockerCollideModel : ProjectileBehaviorModel
{
	[ExtendedDrawer]
	public ProjectileModel projectile; //Field offset: 0x38
	[ExtendedDrawer]
	public EmissionModel emission; //Field offset: 0x40
	public PrefabReference assetId; //Field offset: 0x48
	public float displayLifetime; //Field offset: 0x50

	public CreateProjectileOnBlockerCollideModel(string name, ProjectileModel projectile, EmissionModel emission, PrefabReference assetId, float displayLifetime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

