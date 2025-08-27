namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ArtilleryCommand", menuName = "BTD6/Behaviors/Abilities/ArtilleryCommand")]
public class ArtilleryCommand : AbilityBehavior
{
	public bool givesBuff; //Field offset: 0x30
	public float buffDuration; //Field offset: 0x34
	public Effect otherTowerEffect; //Field offset: 0x38

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 249
	}

	public ArtilleryCommand() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

