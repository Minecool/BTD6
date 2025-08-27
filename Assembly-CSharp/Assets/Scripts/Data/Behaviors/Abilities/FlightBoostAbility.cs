namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "FlightBoostAbility", menuName = "BTD6/Behaviors/Abilities/FlightBoostAbility")]
public class FlightBoostAbility : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float moveSpeedMultiplier; //Field offset: 0x34
	public Effect effectDuringWorkshop; //Field offset: 0x38
	public Effect effectDuringHero; //Field offset: 0x40
	public int animationStateOnEnd; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 249
	}

	public FlightBoostAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

