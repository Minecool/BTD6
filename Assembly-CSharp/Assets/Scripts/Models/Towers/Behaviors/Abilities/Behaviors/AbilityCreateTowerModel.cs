namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(AbilityCreateTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AbilityCreateTowerModel : AbilityBehaviorModel
{
	public TowerModel towerModel; //Field offset: 0x30
	public bool isAirBasedTower; //Field offset: 0x38
	public bool trackCirclePosition; //Field offset: 0x39

	public AbilityCreateTowerModel(string name, TowerModel towerModel, bool isAirBasedTower, bool trackCirclePosition) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

