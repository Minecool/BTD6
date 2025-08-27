namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "SubmergedTarget", menuName = "BTD6/Behaviors/Attacks/SubmergedTarget")]
public class SubmergedTarget : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public SubmergedTarget() { }

	public virtual AttackBehaviorModel get_Def() { }

}

