namespace Assets.Scripts.Unity.Towers.Behaviors;

public class HeliMovement : TowerBehavior
{
	public HeliMovement parent; //Field offset: 0x98
	public float maxSpeed; //Field offset: 0xA0
	public string expMaxSpeed; //Field offset: 0xA8
	public float rotationSpeed; //Field offset: 0xB0
	public string expRotationSpeed; //Field offset: 0xB8
	public float strafeDistance; //Field offset: 0xC0
	public string expStrafeDistance; //Field offset: 0xC8
	public float otherHeliRepulsionRange; //Field offset: 0xD0
	public string expOtherHeliRepulsionRange; //Field offset: 0xD8
	public float movementForceStart; //Field offset: 0xE0
	public string expMovementForceStart; //Field offset: 0xE8
	public float movementForceEnd; //Field offset: 0xF0
	public string expMovementForceEnd; //Field offset: 0xF8
	public float brakeForce; //Field offset: 0x100
	public string expBrakeForce; //Field offset: 0x108
	public float otherHeliRepulsonForce; //Field offset: 0x110
	public string expOtherHeliRepulsonForce; //Field offset: 0x118
	public float slowdownRadiusMax; //Field offset: 0x120
	public string expSlowdownRadiusMax; //Field offset: 0x128
	public float slowdownRadiusMin; //Field offset: 0x130
	public string expSlowdownRadiusMin; //Field offset: 0x138
	public float minVelocityCapScale; //Field offset: 0x140
	public string expMinVelocityCapScale; //Field offset: 0x148
	public float destinationYOffset; //Field offset: 0x150
	public string expDestinationYOffset; //Field offset: 0x158
	public float tiltAngle; //Field offset: 0x160
	public string expTiltAngle; //Field offset: 0x168
	public float patrolPursuitRadius; //Field offset: 0x170
	public string expPatrolPursuitRadius; //Field offset: 0x178

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 493
	}

	public HeliMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

