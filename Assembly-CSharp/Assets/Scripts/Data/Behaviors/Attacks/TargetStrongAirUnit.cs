namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetStrongAirUnit", menuName = "BTD6/Behaviors/Attacks/TargetStrongAirUnit")]
public class TargetStrongAirUnit : TargetTypeBehavior
{
	public AttackFilter[] filters; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 130
	}

	public TargetStrongAirUnit() { }

	public virtual AttackBehaviorModel get_Def() { }

}

