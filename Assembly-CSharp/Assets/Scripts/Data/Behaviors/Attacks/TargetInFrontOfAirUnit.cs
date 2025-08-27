namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetInFrontOfAirUnit", menuName = "BTD6/Behaviors/Attacks/TargetInFrontOfAirUnit")]
public class TargetInFrontOfAirUnit : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetInFrontOfAirUnit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

