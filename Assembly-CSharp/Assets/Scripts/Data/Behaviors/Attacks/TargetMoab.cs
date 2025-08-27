namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetMoab", menuName = "BTD6/Behaviors/Attacks/TargetMoab")]
public class TargetMoab : TargetTypeBehavior
{
	public bool findStrongest; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public TargetMoab() { }

	public virtual AttackBehaviorModel get_Def() { }

}

