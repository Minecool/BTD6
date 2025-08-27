namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ScaleHeroXpWithTowerCount : TowerBehavior
{
	public ScaleHeroXpWithTowerCount parent; //Field offset: 0x98
	public string towerIds; //Field offset: 0xA0
	public string expTowerIds; //Field offset: 0xA8
	public int tier; //Field offset: 0xB0
	public string expTier; //Field offset: 0xB8
	public int percentPerTower; //Field offset: 0xC0
	public string expPercentPerTower; //Field offset: 0xC8
	public int maxPercent; //Field offset: 0xD0
	public string expMaxPercent; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public ScaleHeroXpWithTowerCount() { }

	public virtual TowerBehaviorModel get_Def() { }

}

