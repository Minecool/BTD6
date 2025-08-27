namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TowerCreateParagonTower", menuName = "BTD6/Behaviors/Towers/TowerCreateParagonTower")]
public class TowerCreateParagonTower : TowerBehavior
{
	public Tower towerV1; //Field offset: 0x30
	public Tower towerV2; //Field offset: 0x38
	public Tower towerV3; //Field offset: 0x40
	public Tower towerV4; //Field offset: 0x48
	public Tower towerV5; //Field offset: 0x50
	public bool isAirBasedTower; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 813
	}

	public TowerCreateParagonTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

