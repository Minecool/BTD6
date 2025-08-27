namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetFirstSharedRange", menuName = "BTD6/Behaviors/Attacks/TargetFirstSharedRange")]
public class TargetFirstSharedRange : TargetTypeBehavior
{
	public bool isSharedRangeEnabled; //Field offset: 0x38
	public bool isGlobalRange; //Field offset: 0x39

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 188
	}

	public TargetFirstSharedRange() { }

	public virtual AttackBehaviorModel get_Def() { }

}

