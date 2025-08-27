namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "PathMovementFromScreenCenterPattern", menuName = "BTD6/Behaviors/Attacks/PathMovementFromScreenCenterPattern")]
public class PathMovementFromScreenCenterPattern : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public PathMovementFromScreenCenterPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

