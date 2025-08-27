namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(HeliMovement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeliMovementModel : TowerBehaviorModel
{
	public float maxSpeed; //Field offset: 0x30
	public float rotationSpeed; //Field offset: 0x34
	public float strafeDistance; //Field offset: 0x38
	public float strafeDistanceSquared; //Field offset: 0x3C
	public float otherHeliRepulsionRange; //Field offset: 0x40
	public float otherHeliRepulsionRangeSquared; //Field offset: 0x44
	public float movementForceStart; //Field offset: 0x48
	public float movementForceEnd; //Field offset: 0x4C
	public float movementForceEndSquared; //Field offset: 0x50
	public float brakeForce; //Field offset: 0x54
	public float otherHeliRepulsonForce; //Field offset: 0x58
	public float slowdownRadiusMax; //Field offset: 0x5C
	public float slowdownRadiusMaxSquared; //Field offset: 0x60
	public float slowdownRadiusMin; //Field offset: 0x64
	public float slowdownRadiusMinSquared; //Field offset: 0x68
	public float minVelocityCapScale; //Field offset: 0x6C
	public float destinationYOffset; //Field offset: 0x70
	public float tiltAngle; //Field offset: 0x74
	public float patrolPursuitRadius; //Field offset: 0x78

	public HeliMovementModel(string name, float maxSpeed, float rotationSpeed, float strafeDistance, float otherHeliRepulsionRange, float movementForceStart, float movementForceEnd, float brakeForce, float otherHeliRepulsonForce, float slowdownRadiusMax, float slowdownRadiusMin, float minVelocityCapScale, float destinationYOffset, float tiltAngle, float patrolPursuitRadius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

