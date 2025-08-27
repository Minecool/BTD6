namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetSuppliedPosition", menuName = "BTD6/Behaviors/Attacks/TargetSuppliedPosition")]
public class TargetSuppliedPosition : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetSuppliedPosition() { }

	public virtual AttackBehaviorModel get_Def() { }

}

