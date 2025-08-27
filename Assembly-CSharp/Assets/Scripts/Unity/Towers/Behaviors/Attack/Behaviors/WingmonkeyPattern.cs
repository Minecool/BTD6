namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class WingmonkeyPattern : TargetTypeBehavior
{
	public WingmonkeyPattern parent; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8
	public float turningSpeed; //Field offset: 0xB0
	public string expTurningSpeed; //Field offset: 0xB8
	public float minDistanceToTargetBeforeFlyover; //Field offset: 0xC0
	public string expMinDistanceToTargetBeforeFlyover; //Field offset: 0xC8
	public float minDistanceOfFlyover; //Field offset: 0xD0
	public string expMinDistanceOfFlyover; //Field offset: 0xD8
	public float bankAngleMax; //Field offset: 0xE0
	public string expBankAngleMax; //Field offset: 0xE8
	public float bankSmoothness; //Field offset: 0xF0
	public string expBankSmoothness; //Field offset: 0xF8
	public float updateDelay; //Field offset: 0x100
	public string expUpdateDelay; //Field offset: 0x108
	public float maximumAdjacentTargetAngle; //Field offset: 0x110
	public string expMaximumAdjacentTargetAngle; //Field offset: 0x118
	public float overshootDistance; //Field offset: 0x120
	public string expOvershootDistance; //Field offset: 0x128
	public bool dontUseGrouping; //Field offset: 0x130
	public string expDontUseGrouping; //Field offset: 0x138

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 543
	}

	public WingmonkeyPattern() { }

	public virtual AttackBehaviorModel get_Def() { }

}

