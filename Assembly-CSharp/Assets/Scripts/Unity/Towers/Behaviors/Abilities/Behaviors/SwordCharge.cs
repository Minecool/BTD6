namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class SwordCharge : AbilityBehavior
{
	public SwordCharge parent; //Field offset: 0x88
	public float initialDelay; //Field offset: 0x90
	public string expInitialDelay; //Field offset: 0x98
	public float endDelay; //Field offset: 0xA0
	public string expEndDelay; //Field offset: 0xA8
	public int iterations; //Field offset: 0xB0
	public string expIterations; //Field offset: 0xB8
	public Projectile projectile; //Field offset: 0xC0
	public Projectile expProjectile; //Field offset: 0xC8
	public Effect effectAtEnd; //Field offset: 0xD0
	public Effect expEffectAtEnd; //Field offset: 0xD8
	public Effect effectDuringCharge; //Field offset: 0xE0
	public Effect expEffectDuringCharge; //Field offset: 0xE8
	public float chargeEffectDestroyDelay; //Field offset: 0xF0
	public string expChargeEffectDestroyDelay; //Field offset: 0xF8
	public AudioClip spawnSound; //Field offset: 0x100
	public AudioClip expSpawnSound; //Field offset: 0x108
	public AudioClip landingSound; //Field offset: 0x110
	public AudioClip expLandingSound; //Field offset: 0x118

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 732
	}

	public SwordCharge() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

