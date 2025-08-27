namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "BonusLivesOnAbility", menuName = "BTD6/Behaviors/Abilities/BonusLivesOnAbility")]
public class BonusLivesOnAbility : AbilityBehavior
{
	public float amount; //Field offset: 0x30

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public BonusLivesOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

