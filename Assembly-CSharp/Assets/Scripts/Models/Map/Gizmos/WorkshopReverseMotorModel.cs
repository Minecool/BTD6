namespace Assets.Scripts.Models.Map.Gizmos;

[Implementation(typeof(WorkshopReverseMotor), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WorkshopReverseMotorModel : MapGizmoBehaviorModel
{
	public float duration; //Field offset: 0x38
	public int firstUseCost; //Field offset: 0x3C
	public int roundCost; //Field offset: 0x40
	public int roundsPerCostTier; //Field offset: 0x44
	public int costPerTimesUsed; //Field offset: 0x48
	public float globalMapSpeedSet; //Field offset: 0x4C

	public WorkshopReverseMotorModel(string name, float duration, int firstUseCost, int roundCost, int roundsPerCostTier, int costPerTimesUsed, float globalMapSpeedSet) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

