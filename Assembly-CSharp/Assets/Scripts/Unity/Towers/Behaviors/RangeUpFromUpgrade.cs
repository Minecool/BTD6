namespace Assets.Scripts.Unity.Towers.Behaviors;

public class RangeUpFromUpgrade : TowerBehavior
{
	public RangeUpFromUpgrade parent; //Field offset: 0x98
	public float rangePerUpgrade; //Field offset: 0xA0
	public string expRangePerUpgrade; //Field offset: 0xA8
	public float upgradeTier; //Field offset: 0xB0
	public string expUpgradeTier; //Field offset: 0xB8
	public float upgradePath; //Field offset: 0xC0
	public string expUpgradePath; //Field offset: 0xC8
	public string towerBaseId; //Field offset: 0xD0
	public string expTowerBaseId; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 199
	}

	public RangeUpFromUpgrade() { }

	public virtual TowerBehaviorModel get_Def() { }

}

