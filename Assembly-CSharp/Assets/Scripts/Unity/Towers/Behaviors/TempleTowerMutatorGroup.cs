namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TempleTowerMutatorGroup : TowerMutatorGroup
{
	public int cost; //Field offset: 0xA0
	public string expCost; //Field offset: 0xA8
	public string towerSet; //Field offset: 0xB0
	public string expTowerSet; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 215
	}

	public TempleTowerMutatorGroup() { }

	public virtual TowerBehaviorModel get_Def() { }

}

