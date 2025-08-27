namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterParagon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterParagonModel : TowerFilterModel
{
	public bool inclusive; //Field offset: 0x30

	public FilterParagonModel(string name, bool inclusive) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

