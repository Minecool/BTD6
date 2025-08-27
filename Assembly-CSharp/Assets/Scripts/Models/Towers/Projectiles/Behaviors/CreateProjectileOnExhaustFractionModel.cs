namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectileOnExhaustFraction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnExhaustFractionModel : ProjectileBehaviorModel
{
	[ExtendedDrawer]
	public ProjectileModel projectile; //Field offset: 0x38
	[ExtendedDrawer]
	public EmissionModel emission; //Field offset: 0x40
	public float fraction; //Field offset: 0x48
	public float durationfraction; //Field offset: 0x4C
	public bool canCreateInBetweenRounds; //Field offset: 0x50
	public bool collideOnSubProjectile; //Field offset: 0x51
	public bool passOnCollidedWith; //Field offset: 0x52

	public CreateProjectileOnExhaustFractionModel(string name, ProjectileModel projectile, EmissionModel emission, float fraction, float durationfraction, bool canCreateInBetweenRounds, bool collideOnSubProjectile, bool passOnCollidedWith) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

