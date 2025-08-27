namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectileOnContact : ProjectileBehavior
{
	public CreateProjectileOnContact parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Projectile expProjectile; //Field offset: 0x98
	public Emission emission; //Field offset: 0xA0
	public Emission expEmission; //Field offset: 0xA8
	public bool passOnCollidedWith; //Field offset: 0xB0
	public string expPassOnCollidedWith; //Field offset: 0xB8
	public bool dontCreateAtBloon; //Field offset: 0xC0
	public string expDontCreateAtBloon; //Field offset: 0xC8
	public bool passOnDirectionToContact; //Field offset: 0xD0
	public string expPassOnDirectionToContact; //Field offset: 0xD8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 250
	}

	public CreateProjectileOnContact() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

