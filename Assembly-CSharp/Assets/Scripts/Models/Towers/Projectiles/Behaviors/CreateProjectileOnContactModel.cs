namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectileOnContact), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnContactModel : ProjectileBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40
	public bool passOnCollidedWith; //Field offset: 0x48
	public bool dontCreateAtBloon; //Field offset: 0x49
	public bool passOnDirectionToContact; //Field offset: 0x4A

	public CreateProjectileOnContactModel(string name, ProjectileModel projectile, EmissionModel emission, bool passOnCollidedWith, bool dontCreateAtBloon, bool passOnDirectionToContact) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

