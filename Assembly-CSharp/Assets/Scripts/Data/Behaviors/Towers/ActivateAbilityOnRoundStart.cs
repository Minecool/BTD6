namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ActivateAbilityOnRoundStart", menuName = "BTD6/Behaviors/Towers/ActivateAbilityOnRoundStart")]
public class ActivateAbilityOnRoundStart : TowerBehavior
{
	public Ability ability; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 214
	}

	public ActivateAbilityOnRoundStart() { }

	public virtual TowerBehaviorModel get_Def() { }

}

