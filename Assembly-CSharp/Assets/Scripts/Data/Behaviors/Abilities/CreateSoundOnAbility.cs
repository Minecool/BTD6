namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CreateSoundOnAbility", menuName = "BTD6/Behaviors/Abilities/CreateSoundOnAbility")]
public class CreateSoundOnAbility : AbilityBehavior
{
	public Sound sound; //Field offset: 0x30
	public Sound heroSound; //Field offset: 0x38
	public Sound heroSound2; //Field offset: 0x40

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 253
	}

	public CreateSoundOnAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

