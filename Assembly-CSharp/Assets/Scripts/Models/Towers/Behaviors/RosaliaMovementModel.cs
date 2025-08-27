namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RosaliaMovement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RosaliaMovementModel : TowerBehaviorModel
{
	public float maxSpeed; //Field offset: 0x30
	public float rotationSpeed; //Field offset: 0x34
	public float movementForceStart; //Field offset: 0x38
	public float movementForceEnd; //Field offset: 0x3C
	public float movementForceEndSquared; //Field offset: 0x40
	public float brakeForce; //Field offset: 0x44
	public float slowdownRadiusMax; //Field offset: 0x48
	public float slowdownRadiusMaxSquared; //Field offset: 0x4C
	public float slowdownRadiusMin; //Field offset: 0x50
	public float slowdownRadiusMinSquared; //Field offset: 0x54
	public float minVelocityCapScale; //Field offset: 0x58
	public float destinationYOffset; //Field offset: 0x5C
	public float tiltAngle; //Field offset: 0x60
	public float pursuitDistance; //Field offset: 0x64
	public float groupingOffset; //Field offset: 0x68
	public float jumpUpTime; //Field offset: 0x6C
	public float jumpUpTimeFrames; //Field offset: 0x70
	public float jumpDownTime; //Field offset: 0x74
	public float jumpDownTimeFrames; //Field offset: 0x78
	public int jumpUpAnimationState; //Field offset: 0x7C
	public int jumpRelocateAnimationState; //Field offset: 0x80
	public int jumpDownAnimationState; //Field offset: 0x84
	public float jumpBlockerRadius; //Field offset: 0x88
	public float jumpSpeedScale; //Field offset: 0x8C
	public PrefabReference idleLaserPrefab; //Field offset: 0x90
	public PrefabReference idleGrenadePrefab; //Field offset: 0x98
	public PrefabReference jumpingLaserPrefab; //Field offset: 0xA0
	public PrefabReference jumpingGrenadePrefab; //Field offset: 0xA8
	public PrefabReference hoveringLaserPrefab; //Field offset: 0xB0
	public PrefabReference hoveringGrenadePrefab; //Field offset: 0xB8
	public PrefabReference flightBoostLaserPrefab; //Field offset: 0xC0
	public PrefabReference flightBoostGrenadePrefab; //Field offset: 0xC8
	public float noTargetSlowdownDistance; //Field offset: 0xD0
	public float noTargetVelocityScale; //Field offset: 0xD4
	public SoundModel jumpSound1; //Field offset: 0xD8
	public SoundModel jumpSound2; //Field offset: 0xE0
	public SoundModel jumpVoice1; //Field offset: 0xE8
	public SoundModel jumpVoice2; //Field offset: 0xF0
	public SoundModel jumpVoice3; //Field offset: 0xF8

	public RosaliaMovementModel(string name, float maxSpeed, float rotationSpeed, float movementForceStart, float movementForceEnd, float brakeForce, float slowdownRadiusMax, float slowdownRadiusMin, float minVelocityCapScale, float destinationYOffset, float tiltAngle, float pursuitDistance, float groupingOffset, float jumpUpTime, float jumpDownTime, int jumpUpAnimationState, int jumpRelocateAnimationState, int jumpDownAnimationState, float jumpBlockerRadius, float jumpSpeedScale, PrefabReference idleLaserPrefab, PrefabReference idleGrenadePrefab, PrefabReference jumpingLaserPrefab, PrefabReference jumpingGrenadePrefab, PrefabReference hoveringLaserPrefab, PrefabReference hoveringGrenadePrefab, PrefabReference flightBoostLaserPrefab, PrefabReference flightBoostGrenadePrefab, float noTargetSlowdownDistance, float noTargetVelocityScale, SoundModel jumpSound1, SoundModel jumpSound2, SoundModel jumpVoice1, SoundModel jumpVoice2, SoundModel jumpVoice3) { }

	public void ApplyCosmetics(SwapPrefab[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

