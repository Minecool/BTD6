namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetLastSharedRange", menuName = "BTD6/Behaviors/Attacks/TargetLastSharedRange")]
public class TargetLastSharedRange : TargetTypeBehavior
{
	public bool isSharedRangeEnabled; //Field offset: 0x38
	public bool isGlobalRange; //Field offset: 0x39

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public TargetLastSharedRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

