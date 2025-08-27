namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class BonusLivesOnAbility : AbilityBehavior
{
	public BonusLivesOnAbility parent; //Field offset: 0x88
	public float amount; //Field offset: 0x90
	public string expAmount; //Field offset: 0x98

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public BonusLivesOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

