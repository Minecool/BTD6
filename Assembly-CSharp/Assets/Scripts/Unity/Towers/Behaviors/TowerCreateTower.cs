namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerCreateTower : TowerBehavior
{
	public TowerCreateTower parent; //Field offset: 0x98
	public Tower tower; //Field offset: 0xA0
	public Tower expTower; //Field offset: 0xA8
	public bool isAirBasedTower; //Field offset: 0xB0
	public string expIsAirBasedTower; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public TowerCreateTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

