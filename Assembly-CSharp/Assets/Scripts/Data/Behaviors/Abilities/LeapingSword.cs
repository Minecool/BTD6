namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "LeapingSword", menuName = "BTD6/Behaviors/Abilities/LeapingSword")]
public class LeapingSword : AbilityBehavior
{
	public float timeUntilFinish; //Field offset: 0x30
	public float landDelay; //Field offset: 0x34
	public Projectile impactProjectile; //Field offset: 0x38
	public Projectile dotProjectile; //Field offset: 0x40
	public Effect effectAtTarget; //Field offset: 0x48
	public Effect impactEffect; //Field offset: 0x50
	public Effect finishingEffect; //Field offset: 0x58
	public Sound landingSound; //Field offset: 0x60
	public float finishingEffectDelay; //Field offset: 0x68

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 655
	}

	public LeapingSword() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

