namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectileOnExhaustFraction : ProjectileBehavior
{
	public CreateProjectileOnExhaustFraction parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Emission emission; //Field offset: 0x98
	public float fraction; //Field offset: 0xA0
	public string expFraction; //Field offset: 0xA8
	public float durationFraction; //Field offset: 0xB0
	public string expDurationFraction; //Field offset: 0xB8
	public bool canCreateInBetweenRounds; //Field offset: 0xC0
	public string expCanCreateInBetweenRounds; //Field offset: 0xC8
	public bool collideOnSubProjectile; //Field offset: 0xD0
	public string expCollideOnSubProjectile; //Field offset: 0xD8
	public bool passOnCollidedWith; //Field offset: 0xE0
	public string expPassOnCollidedWith; //Field offset: 0xE8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 314
	}

	public CreateProjectileOnExhaustFraction() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

