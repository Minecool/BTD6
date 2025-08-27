namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RosaliaMovement", menuName = "BTD6/Behaviors/Towers/RosaliaMovement")]
public class RosaliaMovement : TowerBehavior
{
	public float maxSpeed; //Field offset: 0x30
	public float rotationSpeed; //Field offset: 0x34
	public float movementForceStart; //Field offset: 0x38
	public float movementForceEnd; //Field offset: 0x3C
	public float brakeForce; //Field offset: 0x40
	public float slowdownRadiusMax; //Field offset: 0x44
	public float slowdownRadiusMin; //Field offset: 0x48
	public float minVelocityCapScale; //Field offset: 0x4C
	public float destinationYOffset; //Field offset: 0x50
	public float tiltAngle; //Field offset: 0x54
	public float pursuitDistance; //Field offset: 0x58
	public float groupingOffset; //Field offset: 0x5C
	public float jumpUpTime; //Field offset: 0x60
	public float jumpDownTime; //Field offset: 0x64
	public int jumpUpAnimationState; //Field offset: 0x68
	public int jumpRelocateAnimationState; //Field offset: 0x6C
	public int jumpDownAnimationState; //Field offset: 0x70
	public float jumpBlockerRadius; //Field offset: 0x74
	public float jumpSpeedScale; //Field offset: 0x78
	public PrefabReference idleLaserPrefab; //Field offset: 0x80
	public PrefabReference idleGrenadePrefab; //Field offset: 0x88
	public PrefabReference jumpingLaserPrefab; //Field offset: 0x90
	public PrefabReference jumpingGrenadePrefab; //Field offset: 0x98
	public PrefabReference hoveringLaserPrefab; //Field offset: 0xA0
	public PrefabReference hoveringGrenadePrefab; //Field offset: 0xA8
	public PrefabReference flightBoostLaserPrefab; //Field offset: 0xB0
	public PrefabReference flightBoostGrenadePrefab; //Field offset: 0xB8
	public float noTargetSlowdownDistance; //Field offset: 0xC0
	public float noTargetVelocityScale; //Field offset: 0xC4
	public Sound jumpSound1; //Field offset: 0xC8
	public Sound jumpSound2; //Field offset: 0xD0
	public Sound jumpVoice1; //Field offset: 0xD8
	public Sound jumpVoice2; //Field offset: 0xE0
	public Sound jumpVoice3; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1183
	}

	public RosaliaMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

