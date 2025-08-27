namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "WingmonkeyPattern", menuName = "BTD6/Behaviors/Attacks/WingmonkeyPattern")]
public class WingmonkeyPattern : TargetTypeBehavior
{
	public float speed; //Field offset: 0x38
	public float turningSpeed; //Field offset: 0x3C
	public float minDistanceToTargetBeforeFlyover; //Field offset: 0x40
	public float minDistanceOfFlyover; //Field offset: 0x44
	public float bankAngleMax; //Field offset: 0x48
	public float bankSmoothness; //Field offset: 0x4C
	public float updateDelay; //Field offset: 0x50
	public float maximumAdjacentTargetAngle; //Field offset: 0x54
	public float overshootDistance; //Field offset: 0x58
	public bool dontUseGrouping; //Field offset: 0x5C

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 421
	}

	public WingmonkeyPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

