namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetStrongSharedRange", menuName = "BTD6/Behaviors/Attacks/TargetStrongSharedRange")]
public class TargetStrongSharedRange : TargetTypeBehavior
{
	public bool isSharedRangeEnabled; //Field offset: 0x38
	public bool isGlobalRange; //Field offset: 0x39

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public TargetStrongSharedRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

