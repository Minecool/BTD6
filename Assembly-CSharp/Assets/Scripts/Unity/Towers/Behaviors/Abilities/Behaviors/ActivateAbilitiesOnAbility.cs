namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ActivateAbilitiesOnAbility : AbilityBehavior
{
	public ActivateAbilitiesOnAbility parent; //Field offset: 0x88
	public string abilityToFind; //Field offset: 0x90
	public string expAbilityToFind; //Field offset: 0x98

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public ActivateAbilitiesOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

