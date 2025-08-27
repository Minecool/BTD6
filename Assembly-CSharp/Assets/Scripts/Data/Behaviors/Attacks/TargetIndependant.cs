namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetIndependant", menuName = "BTD6/Behaviors/Attacks/TargetIndependant")]
public class TargetIndependant : TargetTypeBehavior
{
	public AttackBehavior targetProvider; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 318
	}

	public TargetIndependant() { }

	public virtual AttackBehaviorModel get_Def() { }

}

