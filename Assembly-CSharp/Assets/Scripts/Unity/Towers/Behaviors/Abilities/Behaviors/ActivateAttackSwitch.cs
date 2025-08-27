namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ActivateAttackSwitch : AbilityBehavior
{
	public ActivateAttackSwitch parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public Attack firstAttack; //Field offset: 0xA0
	public Attack secondAttack; //Field offset: 0xA8
	public bool processOnActivate; //Field offset: 0xB0
	public string expProcessOnActivate; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 388
	}

	public ActivateAttackSwitch() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

