namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "ArriveAtTarget", menuName = "BTD6/Behaviors/Projectiles/ArriveAtTarget")]
public class ArriveAtTarget : ProjectileBehavior
{
	public float timeToTake; //Field offset: 0x30
	public float altSpeed; //Field offset: 0x34
	public bool filterCollisionWhileMoving; //Field offset: 0x38
	public bool expireOnArrival; //Field offset: 0x39
	public int numSamples; //Field offset: 0x3C
	public AnimCurve arrivalCurve; //Field offset: 0x40
	public bool stopOnTargetReached; //Field offset: 0x48
	public bool keepUpdatingTargetPos; //Field offset: 0x49
	public bool rotateToTarget; //Field offset: 0x4A
	public float maxTurnAngle; //Field offset: 0x4C
	public bool positionAboveMoabTypes; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 519
	}

	public ArriveAtTarget() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

