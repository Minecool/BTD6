namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterOutBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterOutBloonModel : FilterModel
{
	public string bloonId; //Field offset: 0x30

	public FilterOutBloonModel(string name, string bloonId) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

