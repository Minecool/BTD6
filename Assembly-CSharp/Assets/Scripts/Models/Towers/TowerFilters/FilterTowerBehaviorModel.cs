namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterTowerBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterTowerBehaviorModel : TowerFilterModel
{
	public String[] towerBehaviors; //Field offset: 0x30
	public bool isInclusive; //Field offset: 0x38
	public bool requiresAllBehaviors; //Field offset: 0x39

	public FilterTowerBehaviorModel(string name, String[] towerBehaviors, bool isInclusive, bool requiresAllBehaviors) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

