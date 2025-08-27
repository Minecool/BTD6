namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "FighterMovement", menuName = "BTD6/Behaviors/Towers/FighterMovement")]
public class FighterMovement : TowerBehavior
{
	public float speed; //Field offset: 0x30
	public float turningSpeed; //Field offset: 0x34
	public float minDistanceToTargetBeforeFlyover; //Field offset: 0x38
	public float minDistanceOfFlyover; //Field offset: 0x3C
	public float bankAngleMax; //Field offset: 0x40
	public float bankSmoothness; //Field offset: 0x44
	public float rollTotalTime; //Field offset: 0x48
	public float rollRunUpDistance; //Field offset: 0x4C
	public float rollTimeBeforeNext; //Field offset: 0x50
	public float rollChancePerSecondPassed; //Field offset: 0x54
	public float loopTotalTime; //Field offset: 0x58
	public float loopRunUpDistance; //Field offset: 0x5C
	public float loopTimeBeforeNext; //Field offset: 0x60
	public float loopChancePerSecondPassed; //Field offset: 0x64
	public float loopRadius; //Field offset: 0x68
	public float loopModelScale; //Field offset: 0x6C

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 515
	}

	public FighterMovement() { }

	public virtual TowerBehaviorModel get_Def() { }

}

