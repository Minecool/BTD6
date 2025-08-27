namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectilesOnTrackOnExpire), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectilesOnTrackOnExpireModel : ProjectileBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40
	public bool useRotation; //Field offset: 0x48
	public int count; //Field offset: 0x4C
	public float range; //Field offset: 0x50

	public CreateProjectilesOnTrackOnExpireModel(string name, ProjectileModel projectile, EmissionModel emission, bool useRotation, int count, float range) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

