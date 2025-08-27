namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetFirstAirUnit", menuName = "BTD6/Behaviors/Attacks/TargetFirstAirUnit")]
public class TargetFirstAirUnit : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetFirstAirUnit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

