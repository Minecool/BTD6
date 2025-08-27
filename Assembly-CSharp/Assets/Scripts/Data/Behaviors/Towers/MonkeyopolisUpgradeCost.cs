namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MonkeyopolisUpgradeCost", menuName = "BTD6/Behaviors/Towers/MonkeyopolisUpgradeCost")]
public class MonkeyopolisUpgradeCost : TowerBehavior
{
	public int costPerFarm; //Field offset: 0x30
	public int path; //Field offset: 0x34
	public string filterTower; //Field offset: 0x38

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 190
	}

	public MonkeyopolisUpgradeCost() { }

	public virtual TowerBehaviorModel get_Def() { }

}

