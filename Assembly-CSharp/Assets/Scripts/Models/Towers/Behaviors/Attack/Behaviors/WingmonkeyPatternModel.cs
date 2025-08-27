namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(WingmonkeyPattern), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WingmonkeyPatternModel : TargetSupplierModel
{
	public float maxSpeed; //Field offset: 0x38
	public float turningSpeed; //Field offset: 0x3C
	public float minDistanceToTargetBeforeFlyover; //Field offset: 0x40
	public float distanceOfFlyover; //Field offset: 0x44
	public float bankAngleMax; //Field offset: 0x48
	public float bankSmoothness; //Field offset: 0x4C
	public float updateDelay; //Field offset: 0x50
	public float maximumAdjacentTargetAngle; //Field offset: 0x54
	public float overshootDistance; //Field offset: 0x58
	public bool useGrouping; //Field offset: 0x5C

	public WingmonkeyPatternModel(string name, float maxSpeed, float turningSpeed, float minDistanceToTargetBeforeFlyover, float distanceOfFlyover, float bankAngleMax, float bankSmoothness, float updateDelay, float maximumAdjacentTargetAngle, float overshootDistance, bool useGrouping) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

