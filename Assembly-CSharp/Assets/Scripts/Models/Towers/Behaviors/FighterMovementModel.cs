namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(FighterMovement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FighterMovementModel : TowerBehaviorModel
{
	public float maxSpeed; //Field offset: 0x30
	public float turningSpeed; //Field offset: 0x34
	public float minDistanceToTargetBeforeFlyover; //Field offset: 0x38
	public float distanceOfFlyover; //Field offset: 0x3C
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

	public FighterMovementModel(string name, float maxSpeed, float turningSpeed, float minDistanceToTargetBeforeFlyover, float distanceOfFlyover, float bankAngleMax, float bankSmoothness, float rollTotalTime, float rollRunUpDistance, float rollTimeBeforeNext, float rollChancePerSecondPassed, float loopTotalTime, float loopRunUpDistance, float loopTimeBeforeNext, float loopChancePerSecondPassed, float loopRadius, float loopModelScale) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

