namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateAttackCreateTowerPlacement", menuName = "BTD6/Behaviors/Abilities/ActivateAttackCreateTowerPlacement")]
public class ActivateAttackCreateTowerPlacement : AbilityBehavior
{
	public Attack[] attacks; //Field offset: 0x30

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 132
	}

	public ActivateAttackCreateTowerPlacement() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

