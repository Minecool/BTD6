namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "BrewTargetting", menuName = "BTD6/Behaviors/Attacks/BrewTargetting")]
public class BrewTargetting : TargetTypeBehavior
{
	public string towerIgnoreList; //Field offset: 0x38
	public string ignoreMutationsByOrder; //Field offset: 0x40

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 225
	}

	public BrewTargetting() { }

	public virtual AttackBehaviorModel get_Def() { }

}

