namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ScaleProjectileOverTime : ProjectileBehavior
{
	public float baseScale; //Field offset: 0x88
	public string expBaseScale; //Field offset: 0x90
	public float maxScale; //Field offset: 0x98
	public string expMaxScale; //Field offset: 0xA0
	public float scalePerSecond; //Field offset: 0xA8
	public string expScalePerSecond; //Field offset: 0xB0
	public float effectOffset; //Field offset: 0xB8
	public string expEffectOffset; //Field offset: 0xC0
	public Effect effect; //Field offset: 0xC8
	public Effect expEffect; //Field offset: 0xD0
	public Projectile bonusProjectile; //Field offset: 0xD8
	public Projectile expBonusProjectile; //Field offset: 0xE0
	public Emission emission; //Field offset: 0xE8
	public Emission expEmission; //Field offset: 0xF0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 556
	}

	public ScaleProjectileOverTime() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

