namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "CreateTowersInSequenceAbilityIcon", menuName = "BTD6/Behaviors/Abilities/CreateTowersInSequenceAbilityIcon")]
public class CreateTowersInSequenceAbilityIcon : AbilityBehavior
{
	public SpriteReference[] icons; //Field offset: 0x30

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public CreateTowersInSequenceAbilityIcon() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

