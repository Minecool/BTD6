namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class FlightBoostAbility : AbilityBehavior
{
	public FlightBoostAbility parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float moveSpeedMultiplier; //Field offset: 0xA0
	public string expMoveSpeedMultiplier; //Field offset: 0xA8
	public Effect effectDuringWorkshop; //Field offset: 0xB0
	public Effect expEffectDuringWorkshop; //Field offset: 0xB8
	public Effect effectDuringHero; //Field offset: 0xC0
	public Effect expEffectDuringHero; //Field offset: 0xC8
	public int animationStateOnEnd; //Field offset: 0xD0
	public string expAnimationStateOnEnd; //Field offset: 0xD8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 240
	}

	public FlightBoostAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

