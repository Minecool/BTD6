namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetRightHand", menuName = "BTD6/Behaviors/Attacks/TargetRightHand")]
public class TargetRightHand : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetRightHand() { }

	public virtual AttackBehaviorModel get_Def() { }

}

