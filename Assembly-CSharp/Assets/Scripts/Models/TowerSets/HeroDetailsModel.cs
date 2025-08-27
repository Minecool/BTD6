namespace Assets.Scripts.Models.TowerSets;

public class HeroDetailsModel : TowerDetailsModel
{
	public int upgradeMax; //Field offset: 0x40
	public int visiblePlayerLevel; //Field offset: 0x44
	public int monkeyMoneyCost; //Field offset: 0x48
	public bool newestHero; //Field offset: 0x4C

	public HeroDetailsModel(string towerId, int towerIndex, int upgradeMax, int towerCount, int visiblePlayerLevel, int monkeyMoneyCost, bool newestHero) { }

	public virtual Model Clone() { }

}

