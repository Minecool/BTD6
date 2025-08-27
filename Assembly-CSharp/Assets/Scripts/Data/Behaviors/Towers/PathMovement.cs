namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PathMovement", menuName = "BTD6/Behaviors/Towers/PathMovement")]
public class PathMovement : TowerBehavior
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

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 418
	}

	public PathMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

