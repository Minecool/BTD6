namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SellIncreaseZone : TowerBehavior
{
	public SellIncreaseZone parent; //Field offset: 0x98
	public float sellMultiplier; //Field offset: 0xA0
	public string expSellMultiplier; //Field offset: 0xA8
	public string stackName; //Field offset: 0xB0
	public string expStackName; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 223
	}

	public SellIncreaseZone() { }

	public TowerFilterModel[] GatherFilters() { }

	public virtual TowerBehaviorModel get_Def() { }

}

