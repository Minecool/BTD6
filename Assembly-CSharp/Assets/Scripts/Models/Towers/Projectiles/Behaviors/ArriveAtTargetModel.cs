namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ArriveAtTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ArriveAtTargetModel : ProjectileBehaviorModel
{
	public float timeToTake; //Field offset: 0x38
	public Single[] curveSamples; //Field offset: 0x40
	public bool filterCollisionWhileMoving; //Field offset: 0x48
	public bool expireOnArrival; //Field offset: 0x49
	public float altSpeed; //Field offset: 0x4C
	public bool stopOnTargetReached; //Field offset: 0x50
	public Curve curve; //Field offset: 0x58
	public bool keepUpdatingTargetPos; //Field offset: 0x60
	public bool rotateToTarget; //Field offset: 0x61
	public float maxTurnAngle; //Field offset: 0x64
	public bool positionAboveMoabTypes; //Field offset: 0x68

	public ArriveAtTargetModel(string name, float timeToTake, Single[] curveSamples, bool filterCollisionWhileMoving, bool expireOnArrival, float altSpeed, bool stopOnTargetReached, bool keepUpdatingTargetPos, bool rotateToTarget, float maxTurnAngle, bool positionAboveMoabTypes) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

