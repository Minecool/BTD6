namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "SwordCharge", menuName = "BTD6/Behaviors/Abilities/SwordCharge")]
public class SwordCharge : AbilityBehavior
{
	public float initialDelay; //Field offset: 0x30
	public float endDelay; //Field offset: 0x34
	public int iterations; //Field offset: 0x38
	public Projectile projectile; //Field offset: 0x40
	public Effect effectAtEnd; //Field offset: 0x48
	public Effect effectDuringCharge; //Field offset: 0x50
	public float chargeEffectDestroyDelay; //Field offset: 0x58
	public Sound spawnSound; //Field offset: 0x60
	public Sound landingSound; //Field offset: 0x68

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 462
	}

	public SwordCharge() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

