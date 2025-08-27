namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class GrabBloon : ProjectileBehavior
{
	public GrabBloon parent; //Field offset: 0x88
	public float grabDuration; //Field offset: 0x90
	public string expGrabDuration; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public Emission expEmission; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 205
	}

	public GrabBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

