namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterAllExceptTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterAllExceptTargetModel : FilterModel
{
	public bool cantbePaused; //Field offset: 0x30

	public FilterAllExceptTargetModel(string name, bool cantBePaused) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

