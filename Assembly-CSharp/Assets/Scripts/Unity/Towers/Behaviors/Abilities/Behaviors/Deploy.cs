namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class Deploy : AbilityBehavior
{
	public Deploy parent; //Field offset: 0x88
	public AudioClip activateSound; //Field offset: 0x90
	public AudioClip expActivateSound; //Field offset: 0x98
	public AudioClip dropOffSound; //Field offset: 0xA0
	public AudioClip expDropOffSound; //Field offset: 0xA8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 467
	}

	public Deploy() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

