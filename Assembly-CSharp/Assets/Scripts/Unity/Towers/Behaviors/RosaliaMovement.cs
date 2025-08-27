namespace Assets.Scripts.Unity.Towers.Behaviors;

public class RosaliaMovement : TowerBehavior
{
	public RosaliaMovement parent; //Field offset: 0x98
	public float maxSpeed; //Field offset: 0xA0
	public string expMaxSpeed; //Field offset: 0xA8
	public float rotationSpeed; //Field offset: 0xB0
	public string expRotationSpeed; //Field offset: 0xB8
	public float movementForceStart; //Field offset: 0xC0
	public string expMovementForceStart; //Field offset: 0xC8
	public float movementForceEnd; //Field offset: 0xD0
	public string expMovementForceEnd; //Field offset: 0xD8
	public float brakeForce; //Field offset: 0xE0
	public string expBrakeForce; //Field offset: 0xE8
	public float slowdownRadiusMax; //Field offset: 0xF0
	public string expSlowdownRadiusMax; //Field offset: 0xF8
	public float slowdownRadiusMin; //Field offset: 0x100
	public string expSlowdownRadiusMin; //Field offset: 0x108
	public float minVelocityCapScale; //Field offset: 0x110
	public string expMinVelocityCapScale; //Field offset: 0x118
	public float destinationYOffset; //Field offset: 0x120
	public string expDestinationYOffset; //Field offset: 0x128
	public float tiltAngle; //Field offset: 0x130
	public string expTiltAngle; //Field offset: 0x138
	public float pursuitDistance; //Field offset: 0x140
	public string expPursuitDistance; //Field offset: 0x148
	public float groupingOffset; //Field offset: 0x150
	public string expGroupingOffset; //Field offset: 0x158
	public float jumpUpTime; //Field offset: 0x160
	public string expJumpUpTime; //Field offset: 0x168
	public float jumpDownTime; //Field offset: 0x170
	public string expJumpDownTime; //Field offset: 0x178
	public int jumpUpAnimationState; //Field offset: 0x180
	public string expJumpUpAnimationState; //Field offset: 0x188
	public int jumpRelocateAnimationState; //Field offset: 0x190
	public string expJumpRelocateAnimationState; //Field offset: 0x198
	public int jumpDownAnimationState; //Field offset: 0x1A0
	public string expJumpDownAnimationState; //Field offset: 0x1A8
	public float jumpBlockerRadius; //Field offset: 0x1B0
	public string expJumpBlockerRadius; //Field offset: 0x1B8
	public float jumpSpeedScale; //Field offset: 0x1C0
	public string expJumpSpeedScale; //Field offset: 0x1C8
	public GameObject idleLaserPrefab; //Field offset: 0x1D0
	public GameObject expIdleLaserPrefab; //Field offset: 0x1D8
	public GameObject idleGrenadePrefab; //Field offset: 0x1E0
	public GameObject expIdleGrenadePrefab; //Field offset: 0x1E8
	public GameObject jumpingLaserPrefab; //Field offset: 0x1F0
	public GameObject expJumpingLaserPrefab; //Field offset: 0x1F8
	public GameObject jumpingGrenadePrefab; //Field offset: 0x200
	public GameObject expJumpingGrenadePrefab; //Field offset: 0x208
	public GameObject hoveringLaserPrefab; //Field offset: 0x210
	public GameObject expHoveringLaserPrefab; //Field offset: 0x218
	public GameObject hoveringGrenadePrefab; //Field offset: 0x220
	public GameObject expHoveringGrenadePrefab; //Field offset: 0x228
	public GameObject flightBoostLaserPrefab; //Field offset: 0x230
	public GameObject expFlightBoostLaserPrefab; //Field offset: 0x238
	public GameObject flightBoostGrenadePrefab; //Field offset: 0x240
	public GameObject expFlightBoostGrenadePrefab; //Field offset: 0x248
	public float noTargetSlowdownDistance; //Field offset: 0x250
	public string expNoTargetSlowdownDistance; //Field offset: 0x258
	public float noTargetVelocityScale; //Field offset: 0x260
	public string expNoTargetVelocityScale; //Field offset: 0x268
	public AudioClip jumpSound1; //Field offset: 0x270
	public AudioClip expJumpSound1; //Field offset: 0x278
	public AudioClip jumpSound2; //Field offset: 0x280
	public AudioClip expJumpSound2; //Field offset: 0x288
	public AudioClip jumpVoice1; //Field offset: 0x290
	public AudioClip expJumpVoice1; //Field offset: 0x298
	public AudioClip jumpVoice2; //Field offset: 0x2A0
	public AudioClip expJumpVoice2; //Field offset: 0x2A8
	public AudioClip jumpVoice3; //Field offset: 0x2B0
	public AudioClip expJumpVoice3; //Field offset: 0x2B8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 2070
	}

	public RosaliaMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

