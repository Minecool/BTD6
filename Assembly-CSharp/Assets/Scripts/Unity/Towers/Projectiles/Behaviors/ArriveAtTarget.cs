namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ArriveAtTarget : ProjectileBehavior
{
	public ArriveAtTarget parent; //Field offset: 0x88
	public float timeToTake; //Field offset: 0x90
	public string expTimeToTake; //Field offset: 0x98
	public float altSpeed; //Field offset: 0xA0
	public string expAltSpeed; //Field offset: 0xA8
	public bool filterCollisionWhileMoving; //Field offset: 0xB0
	public string expFilterCollisionWhileMoving; //Field offset: 0xB8
	public bool expireOnArrival; //Field offset: 0xC0
	public string expExpireOnArrival; //Field offset: 0xC8
	public int numSamples; //Field offset: 0xD0
	public string expNumSamples; //Field offset: 0xD8
	public AnimCurve arrivalCurve; //Field offset: 0xE0
	public AnimCurve expArrivalCurve; //Field offset: 0xE8
	public bool stopOnTargetReached; //Field offset: 0xF0
	public string expStopOnTargetReached; //Field offset: 0xF8
	public bool keepUpdatingTargetPos; //Field offset: 0x100
	public string expKeepUpdatingTargetPos; //Field offset: 0x108
	public bool rotateToTarget; //Field offset: 0x110
	public string expRotateToTarget; //Field offset: 0x118
	public float maxTurnAngle; //Field offset: 0x120
	public string expMaxTurnAngle; //Field offset: 0x128
	public bool positionAboveMoabTypes; //Field offset: 0x130
	public string expPositionAboveMoabTypes; //Field offset: 0x138

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 583
	}

	public ArriveAtTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

