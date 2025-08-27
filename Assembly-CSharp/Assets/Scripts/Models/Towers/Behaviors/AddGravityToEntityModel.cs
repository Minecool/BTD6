namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AddGravityToEntity), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddGravityToEntityModel : TowerBehaviorModel
{
	public float mass; //Field offset: 0x30
	public float velocityX; //Field offset: 0x34
	public float velocityY; //Field offset: 0x38
	public float velocityZ; //Field offset: 0x3C
	public float accellerationX; //Field offset: 0x40
	public float accellerationY; //Field offset: 0x44
	public float accellerationZ; //Field offset: 0x48
	public float gravityX; //Field offset: 0x4C
	public float gravityY; //Field offset: 0x50
	public float gravityZ; //Field offset: 0x54
	public float impulseX; //Field offset: 0x58
	public float impulseY; //Field offset: 0x5C
	public float impulseZ; //Field offset: 0x60
	public bool impulseOverridesVelocity; //Field offset: 0x64
	public bool canImpulseIfNotGrounded; //Field offset: 0x65
	public bool tiltBasedOnVelocity; //Field offset: 0x66
	public float maxTiltAngle; //Field offset: 0x68
	public float groundPlaneY; //Field offset: 0x6C

	public bool HasGroundPlane
	{
		 get { } //Length: 15
	}

	public AddGravityToEntityModel(string name, float mass, float velocityX, float velocityY, float velocityZ, float accellerationX, float accellerationY, float accellerationZ, float gravityX, float gravityY, float gravityZ, float impulseX, float impulseY, float impulseZ, bool impulseOverridesVelocity, bool canImpulseIfNotGrounded, bool tiltBasedOnVelocity, float maxTiltAngle, float groundPlaneY) { }

	public virtual Model Clone() { }

	public bool get_HasGroundPlane() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

