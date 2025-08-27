namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterMoab), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterMoabModel : FilterModel
{
	public bool flip; //Field offset: 0x30

	public FilterMoabModel(string name, bool flip) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

