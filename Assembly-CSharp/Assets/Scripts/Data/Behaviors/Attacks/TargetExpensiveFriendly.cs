namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetExpensiveFriendly", menuName = "BTD6/Behaviors/Attacks/TargetExpensiveFriendly")]
public class TargetExpensiveFriendly : TargetTypeBehavior
{
	public string ignoreList; //Field offset: 0x38
	public bool ignorePrevious; //Field offset: 0x40
	public string previousId; //Field offset: 0x48
	public bool useRange; //Field offset: 0x50

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 182
	}

	public TargetExpensiveFriendly() { }

	public virtual AttackBehaviorModel get_Def() { }

}

