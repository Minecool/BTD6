namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectilesOnTrackOnExhaustFraction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectilesOnTrackOnExhaustFractionModel : ProjectileBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x38
	public EmissionModel emission; //Field offset: 0x40
	public float fraction; //Field offset: 0x48
	public float durationfraction; //Field offset: 0x4C
	public bool canCreateInBetweenRounds; //Field offset: 0x50
	public bool collideOnSubProjectile; //Field offset: 0x51
	public bool passOnCollidedWith; //Field offset: 0x52
	public float range; //Field offset: 0x54
	public int amtOfEmissions; //Field offset: 0x58

	public CreateProjectilesOnTrackOnExhaustFractionModel(string name, ProjectileModel projectile, EmissionModel emission, float fraction, float durationfraction, bool canCreateInBetweenRounds, bool collideOnSubProjectile, bool passOnCollidedWith, float range, int amtOfEmissions) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

