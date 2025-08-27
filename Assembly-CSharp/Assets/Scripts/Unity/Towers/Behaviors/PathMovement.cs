namespace Assets.Scripts.Unity.Towers.Behaviors;

public class PathMovement : TowerBehavior
{
	public PathMovement parent; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8
	public float rotation; //Field offset: 0xB0
	public string expRotation; //Field offset: 0xB8
	public float bankRotation; //Field offset: 0xC0
	public string expBankRotation; //Field offset: 0xC8
	public float bankRotationMul; //Field offset: 0xD0
	public string expBankRotationMul; //Field offset: 0xD8
	public bool ignoreTargetType; //Field offset: 0xE0
	public string expIgnoreTargetType; //Field offset: 0xE8
	public float catchUpSpeed; //Field offset: 0xF0
	public string expCatchUpSpeed; //Field offset: 0xF8
	public float takeOffTime; //Field offset: 0x100
	public string expTakeOffTime; //Field offset: 0x108
	public float takeOffExponent; //Field offset: 0x110
	public string expTakeOffExponent; //Field offset: 0x118
	public float takeOffAnimTime; //Field offset: 0x120
	public string expTakeOffAnimTime; //Field offset: 0x128
	public float takeOffScale; //Field offset: 0x130
	public string expTakeOffScale; //Field offset: 0x138
	public float takeOffScaleExponent; //Field offset: 0x140
	public string expTakeOffScaleExponent; //Field offset: 0x148
	public float takeOffPitch; //Field offset: 0x150
	public string expTakeOffPitch; //Field offset: 0x158
	public float takeOffPitchExponent; //Field offset: 0x160
	public string expTakeOffPitchExponent; //Field offset: 0x168
	public string fixedPathSupplierId; //Field offset: 0x170
	public string expFixedPathSupplierId; //Field offset: 0x178

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 460
	}

	public PathMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

