namespace Assets.Scripts.Unity.Map.Gizmos;

public class WorkshopPowerCore : MapGizmoBehavior
{
	public float duration; //Field offset: 0x28
	public int firstUseCost; //Field offset: 0x2C
	public int roundCost; //Field offset: 0x30
	public int roundsPerCostTier; //Field offset: 0x34
	public int costPerTimesUsed; //Field offset: 0x38
	public Path[] normalPaths; //Field offset: 0x40
	public Path[] extendedPaths; //Field offset: 0x48
	private WorkshopPowerCoreModel def; //Field offset: 0x50

	public virtual MapGizmoBehaviorModel Def
	{
		 get { } //Length: 670
	}

	public WorkshopPowerCore() { }

	public virtual MapGizmoBehaviorModel get_Def() { }

}

