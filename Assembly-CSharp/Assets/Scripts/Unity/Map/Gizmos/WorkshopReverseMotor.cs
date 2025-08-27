namespace Assets.Scripts.Unity.Map.Gizmos;

public class WorkshopReverseMotor : MapGizmoBehavior
{
	public float duration; //Field offset: 0x28
	public int firstUseCost; //Field offset: 0x2C
	public int roundCost; //Field offset: 0x30
	public int roundsPerCostTier; //Field offset: 0x34
	public int costPerTimesUsed; //Field offset: 0x38
	public float globalMapSpeedSet; //Field offset: 0x3C
	private WorkshopReverseMotorModel def; //Field offset: 0x40

	public virtual MapGizmoBehaviorModel Def
	{
		 get { } //Length: 463
	}

	public WorkshopReverseMotor() { }

	public virtual MapGizmoBehaviorModel get_Def() { }

}

