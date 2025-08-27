namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerCreateParagonTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerCreateParagonTowerModel : TowerBehaviorModel
{
	public TowerModel[] towerModels; //Field offset: 0x30
	public bool isAirBasedTower; //Field offset: 0x38

	public TowerCreateParagonTowerModel(string name, TowerModel[] towerModels, bool isAirBasedTower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

