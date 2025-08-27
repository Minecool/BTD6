namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterWithTags), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterWithTagsModel : FilterModel
{
	public String[] tags; //Field offset: 0x30
	public bool inclusive; //Field offset: 0x38

	public FilterWithTagsModel(string name, String[] tags, bool inclusive) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

