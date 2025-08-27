namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SellStackedTowers : TowerBehavior
{
	public SellStackedTowers parent; //Field offset: 0x98
	private SellStackedTowersModel def; //Field offset: 0xA0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 138
	}

	public SellStackedTowers() { }

	public virtual TowerBehaviorModel get_Def() { }

}

