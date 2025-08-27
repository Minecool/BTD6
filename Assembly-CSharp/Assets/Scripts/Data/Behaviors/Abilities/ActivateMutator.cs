namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "ActivateMutator", menuName = "BTD6/Behaviors/Abilities/ActivateMutator")]
public class ActivateMutator : AbilityBehavior
{
	public TowerMutator towerMutator; //Field offset: 0x30

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 137
	}

	public ActivateMutator() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

