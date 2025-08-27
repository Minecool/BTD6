namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(MonkeyopolisUpgradeCost), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyopolisUpgradeCostModel : TowerBehaviorModel
{
	public int costPerFarm; //Field offset: 0x30
	public int path; //Field offset: 0x34
	public string towerFilter; //Field offset: 0x38

	public MonkeyopolisUpgradeCostModel(string name, int costPerFarm, int path, string towerFilter) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

