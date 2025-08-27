namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateProjectileOnExhaustFraction", menuName = "BTD6/Behaviors/Projectiles/CreateProjectileOnExhaustFraction")]
public class CreateProjectileOnExhaustFraction : ProjectileBehavior
{
	public Projectile projectile; //Field offset: 0x30
	public Emission emission; //Field offset: 0x38
	public float fraction; //Field offset: 0x40
	public float durationFraction; //Field offset: 0x44
	public bool canCreateInBetweenRounds; //Field offset: 0x48
	public bool collideOnSubProjectile; //Field offset: 0x49
	public bool passOnCollidedWith; //Field offset: 0x4A

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 313
	}

	public CreateProjectileOnExhaustFraction() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

