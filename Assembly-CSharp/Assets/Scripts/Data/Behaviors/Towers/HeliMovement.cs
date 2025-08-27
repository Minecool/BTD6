namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "HeliMovement", menuName = "BTD6/Behaviors/Towers/HeliMovement")]
public class HeliMovement : TowerBehavior
{
	public float maxSpeed; //Field offset: 0x30
	public float rotationSpeed; //Field offset: 0x34
	public float strafeDistance; //Field offset: 0x38
	public float otherHeliRepulsionRange; //Field offset: 0x3C
	public float movementForceStart; //Field offset: 0x40
	public float movementForceEnd; //Field offset: 0x44
	public float brakeForce; //Field offset: 0x48
	public float otherHeliRepulsonForce; //Field offset: 0x4C
	public float slowdownRadiusMax; //Field offset: 0x50
	public float slowdownRadiusMin; //Field offset: 0x54
	public float minVelocityCapScale; //Field offset: 0x58
	public float destinationYOffset; //Field offset: 0x5C
	public float tiltAngle; //Field offset: 0x60
	public float patrolPursuitRadius; //Field offset: 0x64

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 451
	}

	public HeliMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

