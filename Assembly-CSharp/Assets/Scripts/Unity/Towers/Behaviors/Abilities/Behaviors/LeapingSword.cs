namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class LeapingSword : AbilityBehavior
{
	public LeapingSword parent; //Field offset: 0x88
	public float timeUntilFinish; //Field offset: 0x90
	public string expTimeUntilFinish; //Field offset: 0x98
	public float landDelay; //Field offset: 0xA0
	public string expLandDelay; //Field offset: 0xA8
	public Projectile impactProjectile; //Field offset: 0xB0
	public Projectile expImpactProjectile; //Field offset: 0xB8
	public Projectile dotProjectile; //Field offset: 0xC0
	public Projectile expDotProjectile; //Field offset: 0xC8
	public Effect effectAtTarget; //Field offset: 0xD0
	public Effect expEffectAtTarget; //Field offset: 0xD8
	public Effect impactEffect; //Field offset: 0xE0
	public Effect expImpactEffect; //Field offset: 0xE8
	public Effect finishingEffect; //Field offset: 0xF0
	public Effect expFinishingEffect; //Field offset: 0xF8
	public AudioClip landingSound; //Field offset: 0x100
	public AudioClip expLandingSound; //Field offset: 0x108
	public float finishingEffectDelay; //Field offset: 0x110
	public string expFinishingEffectDelay; //Field offset: 0x118

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 776
	}

	public LeapingSword() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

