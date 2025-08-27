namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ScaleHeroXpWithTowerCount", menuName = "BTD6/Behaviors/Towers/ScaleHeroXpWithTowerCount")]
public class ScaleHeroXpWithTowerCount : TowerBehavior
{
	public string towerIds; //Field offset: 0x30
	public int tier; //Field offset: 0x38
	public int percentPerTower; //Field offset: 0x3C
	public int maxPercent; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 149
	}

	public ScaleHeroXpWithTowerCount() { }

	public virtual TowerBehaviorModel get_Def() { }

}

