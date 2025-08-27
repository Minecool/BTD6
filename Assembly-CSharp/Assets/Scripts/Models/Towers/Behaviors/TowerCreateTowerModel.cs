namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerCreateTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerCreateTowerModel : TowerBehaviorModel
{
	public TowerModel towerModel; //Field offset: 0x30
	public bool isAirBasedTower; //Field offset: 0x38

	public TowerCreateTowerModel(string name, TowerModel towerModel, bool isAirBasedTower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

