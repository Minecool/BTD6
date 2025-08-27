namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "Deploy", menuName = "BTD6/Behaviors/Abilities/Deploy")]
public class Deploy : AbilityBehavior
{
	public Sound activateSound; //Field offset: 0x30
	public Sound dropOffSound; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public Deploy() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

