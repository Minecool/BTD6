namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterFrozenBloons), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterFrozenBloonsModel : FilterModel
{

	public FilterFrozenBloonsModel(string name) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

