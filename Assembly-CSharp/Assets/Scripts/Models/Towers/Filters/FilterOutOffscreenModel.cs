namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterOutOffscreen), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterOutOffscreenModel : FilterModel
{
	public bool includeBloonRadius; //Field offset: 0x30

	public FilterOutOffscreenModel(string name, bool includeBloonRadius) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

