namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MonkeyopolisUpgradeCost : TowerBehavior
{
	public int costPerFarm; //Field offset: 0x98
	public string expCostPerFarm; //Field offset: 0xA0
	public int path; //Field offset: 0xA8
	public string expPath; //Field offset: 0xB0
	public string filterTower; //Field offset: 0xB8
	public string expFilterTower; //Field offset: 0xC0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 199
	}

	public MonkeyopolisUpgradeCost() { }

	public virtual TowerBehaviorModel get_Def() { }

}

