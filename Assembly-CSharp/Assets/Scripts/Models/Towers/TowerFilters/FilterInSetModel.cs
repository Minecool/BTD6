namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterSet), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterInSetModel : TowerFilterModel
{
	public TowerSet[] towerSets; //Field offset: 0x30
	public TowerSet towerSet; //Field offset: 0x38

	public FilterInSetModel(string name, TowerSet[] towerSets) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

