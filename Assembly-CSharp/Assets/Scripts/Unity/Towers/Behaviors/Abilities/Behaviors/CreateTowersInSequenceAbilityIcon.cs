namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CreateTowersInSequenceAbilityIcon : AbilityBehavior
{
	public CreateTowersInSequenceAbilityIcon parent; //Field offset: 0x88
	public GameObject icon1; //Field offset: 0x90
	public GameObject expIcon1; //Field offset: 0x98
	public GameObject icon2; //Field offset: 0xA0
	public GameObject expIcon2; //Field offset: 0xA8
	public GameObject icon3; //Field offset: 0xB0
	public GameObject expIcon3; //Field offset: 0xB8
	public GameObject icon4; //Field offset: 0xC0
	public GameObject expIcon4; //Field offset: 0xC8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 943
	}

	public CreateTowersInSequenceAbilityIcon() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

