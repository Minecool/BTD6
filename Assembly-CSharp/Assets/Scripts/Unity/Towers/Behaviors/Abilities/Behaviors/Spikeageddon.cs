namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Spikeageddon : AbilityBehavior
{
	public Spikeageddon parent; //Field offset: 0x88
	public Projectile projectile; //Field offset: 0x90
	public Projectile expProjectile; //Field offset: 0x98
	public Effect effectDuringFiring; //Field offset: 0xA0
	public Effect expEffectDuringFiring; //Field offset: 0xA8
	public int explodeProjectilesAnimationState; //Field offset: 0xB0
	public string expExplodeProjectilesAnimationState; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 197
	}

	public Spikeageddon() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

