namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectilesInArea), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectilesInAreaModel : ProjectileBehaviorModel
{
	[ExtendedDrawer]
	public ProjectileModel projectileModel; //Field offset: 0x38
	[ExtendedDrawer]
	public EmissionModel emissionModel; //Field offset: 0x40
	public int intervalFrames; //Field offset: 0x48
	public float range; //Field offset: 0x4C
	public EffectModel effectAtProjectileModel; //Field offset: 0x50
	public EffectModel effectBeforeProjectileModel; //Field offset: 0x58
	public int delayBeforeEffectFrames; //Field offset: 0x60
	public int initialDelayFrames; //Field offset: 0x64
	public int maxProjectileCount; //Field offset: 0x68

	public CreateProjectilesInAreaModel(string name, ProjectileModel projectileModel, EmissionModel emissionModel, int intervalFrames, float range, EffectModel effectAtProjectileModel, EffectModel effectBeforeProjectileModel, int delayBeforeEffectFrames, int initialDelayFrames, int maxProjectileCount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

