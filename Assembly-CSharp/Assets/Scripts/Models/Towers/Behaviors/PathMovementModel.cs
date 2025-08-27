namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PathMovement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PathMovementModel : TowerBehaviorModel
{
	public float speed; //Field offset: 0x30
	public float rotation; //Field offset: 0x34
	public float bankRotation; //Field offset: 0x38
	public float bankRotationMul; //Field offset: 0x3C
	public bool ignoreTargetType; //Field offset: 0x40
	public float catchUpSpeed; //Field offset: 0x44
	public float takeOffTime; //Field offset: 0x48
	public float takeOffExponent; //Field offset: 0x4C
	public float takeOffAnimTime; //Field offset: 0x50
	public float takeOffScale; //Field offset: 0x54
	public float takeOffScaleExponent; //Field offset: 0x58
	public float takeOffPitch; //Field offset: 0x5C
	public float takeOffPitchExponent; //Field offset: 0x60
	public string fixedPathSupplierId; //Field offset: 0x68

	public PathMovementModel(string name, float speed, float rotation, float bankRotation, float bankRotationMul, bool ignoreTargetType, float catchUpSpeed, float takeOffTime, float takeOffExponent, float takeOffAnimTime, float takeOffScale, float takeOffScaleExponent, float takeOffPitch, float takeOffPitchExponent, string fixedPathSupplierId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

