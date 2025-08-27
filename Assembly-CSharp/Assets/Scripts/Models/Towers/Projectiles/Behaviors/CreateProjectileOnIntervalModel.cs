namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectileOnInterval), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnIntervalModel : ProjectileBehaviorModel
{
	[ExtendedDrawer]
	public ProjectileModel projectile; //Field offset: 0x38
	[ExtendedDrawer]
	public EmissionModel emission; //Field offset: 0x40
	public int intervalFrames; //Field offset: 0x48
	public bool onlyIfHasTarget; //Field offset: 0x4C
	public float range; //Field offset: 0x50
	public TargetType targetType; //Field offset: 0x58
	public bool isBuffedByRate; //Field offset: 0x70
	public bool useRawWeaponRate; //Field offset: 0x71
	public bool onlyEmitOnce; //Field offset: 0x72

	public CreateProjectileOnIntervalModel(string name, ProjectileModel projectile, EmissionModel emission, int intervalFrames, bool onlyIfHasTarget, float range, string targetType, bool isBuffedByRate, bool useRawWeaponRate, bool onlyEmitOnce) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

