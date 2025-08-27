namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectileOnExhaustPierce), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnExhaustPierceModel : ProjectileBehaviorModel
{
	[ExtendedDrawer]
	public ProjectileModel projectile; //Field offset: 0x38
	[ExtendedDrawer]
	public EmissionModel emission; //Field offset: 0x40
	public float pierceInterval; //Field offset: 0x48
	public int count; //Field offset: 0x4C
	public int minimumTimeDifferenceInFrames; //Field offset: 0x50
	public bool destroyProjectile; //Field offset: 0x54
	public PrefabReference assetId; //Field offset: 0x58
	public float displayLifetime; //Field offset: 0x60
	public bool displayFullscreen; //Field offset: 0x64
	public bool useBloonPosition; //Field offset: 0x65

	public CreateProjectileOnExhaustPierceModel(string name, ProjectileModel projectile, EmissionModel emission, float pierceInterval, int count, int minimumTimeDifferenceInFrames, bool destroyProjectile, PrefabReference assetId, float displayLifetime, bool displayFullscreen, bool useBloonPosition) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

