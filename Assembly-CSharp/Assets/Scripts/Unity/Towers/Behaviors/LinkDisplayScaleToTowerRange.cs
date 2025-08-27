namespace Assets.Scripts.Unity.Towers.Behaviors;

public class LinkDisplayScaleToTowerRange : TowerBehavior
{
	public LinkDisplayScaleToTowerRange parent; //Field offset: 0x98
	public GameObject display; //Field offset: 0xA0
	public GameObject expDisplay; //Field offset: 0xA8
	public float displayRadius; //Field offset: 0xB0
	public string expDisplayRadius; //Field offset: 0xB8
	public Attack hideIfAttackPaused; //Field offset: 0xC0
	public Attack expHideIfAttackPaused; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 402
	}

	public LinkDisplayScaleToTowerRange() { }

	public virtual TowerBehaviorModel get_Def() { }

}

