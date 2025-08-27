namespace Assets.Scripts.Unity.Towers.Behaviors;

public class FighterMovement : TowerBehavior
{
	public FighterMovement parent; //Field offset: 0x98
	public float speed; //Field offset: 0xA0
	public string expSpeed; //Field offset: 0xA8
	public float turningSpeed; //Field offset: 0xB0
	public string expTurningSpeed; //Field offset: 0xB8
	public float minDistanceToTargetBeforeFlyover; //Field offset: 0xC0
	public string expMinDistanceToTargetBeforeFlyover; //Field offset: 0xC8
	public float minDistanceOfFlyover; //Field offset: 0xD0
	public string expMinDistanceOfFlyover; //Field offset: 0xD8
	public float bankAngleMax; //Field offset: 0xE0
	public string expBankAngleMax; //Field offset: 0xE8
	public float rollTotalTime; //Field offset: 0xF0
	public string expRollTotalTime; //Field offset: 0xF8
	public float rollRunUpDistance; //Field offset: 0x100
	public string expRollRunUpDistance; //Field offset: 0x108
	public float rollTimeBeforeNext; //Field offset: 0x110
	public string expRollTimeBeforeNext; //Field offset: 0x118
	public float rollChancePerSecondPassed; //Field offset: 0x120
	public string expRollChancePerSecondPassed; //Field offset: 0x128
	public float loopTotalTime; //Field offset: 0x130
	public string expLoopTotalTime; //Field offset: 0x138
	public float loopTimeBeforeNext; //Field offset: 0x140
	public string expLoopTimeBeforeNext; //Field offset: 0x148
	public float loopChancePerSecondPassed; //Field offset: 0x150
	public string expLoopChancePerSecondPassed; //Field offset: 0x158
	public float loopRadius; //Field offset: 0x160
	public string expLoopRadius; //Field offset: 0x168
	public float loopModelScale; //Field offset: 0x170
	public string expLoopModelScale; //Field offset: 0x178

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 527
	}

	public FighterMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

