namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterGlueLevel), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterGlueLevelModel : FilterModel
{
	public int glueLevel; //Field offset: 0x30

	public FilterGlueLevelModel(string name, int glueLevel) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

