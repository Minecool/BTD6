namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AddGravityToEntity", menuName = "BTD6/Behaviors/Towers/AddGravityToEntity")]
public class AddGravityToEntity : TowerBehavior
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

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 526
	}

	public AddGravityToEntity() { }

	public virtual TowerBehaviorModel get_Def() { }

}

