namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetCloseAirUnit", menuName = "BTD6/Behaviors/Attacks/TargetCloseAirUnit")]
public class TargetCloseAirUnit : TargetTypeBehavior
{

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetCloseAirUnit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

