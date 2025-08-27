namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetCloseSharedRange", menuName = "BTD6/Behaviors/Attacks/TargetCloseSharedRange")]
public class TargetCloseSharedRange : TargetTypeBehavior
{
	public bool isSharedRangeEnabled; //Field offset: 0x38
	public bool isGlobalRange; //Field offset: 0x39

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public TargetCloseSharedRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

