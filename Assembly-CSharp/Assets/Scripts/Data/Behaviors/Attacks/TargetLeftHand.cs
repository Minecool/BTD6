namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetLeftHand", menuName = "BTD6/Behaviors/Attacks/TargetLeftHand")]
public class TargetLeftHand : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetLeftHand() { }

	public virtual AttackBehaviorModel get_Def() { }

}

