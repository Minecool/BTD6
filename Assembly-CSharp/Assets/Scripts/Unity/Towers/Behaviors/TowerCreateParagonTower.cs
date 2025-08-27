namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerCreateParagonTower : TowerBehavior
{
	public TowerCreateParagonTower parent; //Field offset: 0x98
	public Tower towerV1; //Field offset: 0xA0
	public Tower expTowerV1; //Field offset: 0xA8
	public Tower towerV2; //Field offset: 0xB0
	public Tower expTowerV2; //Field offset: 0xB8
	public Tower towerV3; //Field offset: 0xC0
	public Tower expTowerV3; //Field offset: 0xC8
	public Tower towerV4; //Field offset: 0xD0
	public Tower expTowerV4; //Field offset: 0xD8
	public Tower towerV5; //Field offset: 0xE0
	public Tower expTowerV5; //Field offset: 0xE8
	public bool isAirBasedTower; //Field offset: 0xF0
	public string expIsAirBasedTower; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 770
	}

	public TowerCreateParagonTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

