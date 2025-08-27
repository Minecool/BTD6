namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "TowerCreateTower", menuName = "BTD6/Behaviors/Towers/TowerCreateTower")]
public class TowerCreateTower : TowerBehavior
{
	public Tower tower; //Field offset: 0x30
	public bool isAirBasedTower; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 161
	}

	public TowerCreateTower() { }

	public virtual TowerBehaviorModel get_Def() { }

}

