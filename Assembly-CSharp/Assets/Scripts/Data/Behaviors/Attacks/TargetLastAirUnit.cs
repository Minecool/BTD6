namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetLastAirUnit", menuName = "BTD6/Behaviors/Attacks/TargetLastAirUnit")]
public class TargetLastAirUnit : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetLastAirUnit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

