namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectileOnBlockerCollide : ProjectileBehavior
{
	public CreateProjectileOnBlockerCollide parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Projectile expProjectile; //Field offset: 0x98
	public Emission emission; //Field offset: 0xA0
	public Emission expEmission; //Field offset: 0xA8
	public GameObject display; //Field offset: 0xB0
	public GameObject expDisplay; //Field offset: 0xB8
	public float displayLifetime; //Field offset: 0xC0
	public string expDisplayLifetime; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 877
	}

	public CreateProjectileOnBlockerCollide() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

