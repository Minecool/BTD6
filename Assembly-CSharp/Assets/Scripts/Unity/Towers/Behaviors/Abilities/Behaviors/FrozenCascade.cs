namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class FrozenCascade : AbilityBehavior
{
	public FrozenCascade parent; //Field offset: 0x88
	public string towerId; //Field offset: 0x90
	public string expTowerId; //Field offset: 0x98
	public int maxExplosions; //Field offset: 0xA0
	public string expMaxExplosions; //Field offset: 0xA8
	public float timeScale; //Field offset: 0xB0
	public string expTimeScale; //Field offset: 0xB8
	public Emission emission; //Field offset: 0xC0
	public Emission expEmission; //Field offset: 0xC8
	public Projectile explosionProjectile; //Field offset: 0xD0
	public Projectile expExplosionProjectile; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 289
	}

	public FrozenCascade() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

