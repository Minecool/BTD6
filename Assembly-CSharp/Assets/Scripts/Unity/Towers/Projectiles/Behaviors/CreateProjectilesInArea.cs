namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateProjectilesInArea : ProjectileBehavior
{
	public CreateProjectilesInArea parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Projectile expProjectile; //Field offset: 0x98
	public Emission emission; //Field offset: 0xA0
	public Emission expEmission; //Field offset: 0xA8
	public float interval; //Field offset: 0xB0
	public string expInterval; //Field offset: 0xB8
	public float range; //Field offset: 0xC0
	public string expRange; //Field offset: 0xC8
	public Effect effectAtProjectile; //Field offset: 0xD0
	public Effect expEffectAtProjectile; //Field offset: 0xD8
	public Effect effectBeforeProjectile; //Field offset: 0xE0
	public Effect expEffectBeforeProjectile; //Field offset: 0xE8
	public float delayBeforeEffect; //Field offset: 0xF0
	public string expDelayBeforeEffect; //Field offset: 0xF8
	public float initialDelay; //Field offset: 0x100
	public string expInitialDelay; //Field offset: 0x108
	public int maxProjectileCount; //Field offset: 0x110
	public string expMaxProjectileCount; //Field offset: 0x118

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 556
	}

	public CreateProjectilesInArea() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

