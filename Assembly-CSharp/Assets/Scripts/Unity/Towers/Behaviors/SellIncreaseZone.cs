namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SellIncreaseZone : TowerBehaviorBuff
{
	public SellIncreaseZone parent; //Field offset: 0xB8
	public float sellMultiplier; //Field offset: 0xC0
	public string expSellMultiplier; //Field offset: 0xC8
	public string towerBaseIds; //Field offset: 0xD0
	public string expTowerBaseIds; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 247
	}

	public SellIncreaseZone() { }

	public TowerFilterModel[] GatherFilters() { }

	public virtual TowerBehaviorModel get_Def() { }

}

