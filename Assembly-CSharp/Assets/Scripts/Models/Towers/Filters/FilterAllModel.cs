namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterAll), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterAllModel : FilterModel
{

	public FilterAllModel(string name) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

