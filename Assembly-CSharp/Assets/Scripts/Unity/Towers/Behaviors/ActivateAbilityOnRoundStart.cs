namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ActivateAbilityOnRoundStart : TowerBehavior
{
	public ActivateAbilityOnRoundStart parent; //Field offset: 0x98
	public Ability ability; //Field offset: 0xA0
	public Ability expAbility; //Field offset: 0xA8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 221
	}

	public ActivateAbilityOnRoundStart() { }

	public virtual TowerBehaviorModel get_Def() { }

}

