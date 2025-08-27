namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateAbilitiesOnAbility", menuName = "BTD6/Behaviors/Abilities/ActivateAbilitiesOnAbility")]
public class ActivateAbilitiesOnAbility : AbilityBehavior
{
	public string abilityToFind; //Field offset: 0x30

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public ActivateAbilitiesOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

