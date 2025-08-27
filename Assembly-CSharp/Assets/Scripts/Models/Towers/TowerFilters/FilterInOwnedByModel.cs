namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterInOwnedBy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterInOwnedByModel : TowerFilterModel
{

	public FilterInOwnedByModel(string name) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

