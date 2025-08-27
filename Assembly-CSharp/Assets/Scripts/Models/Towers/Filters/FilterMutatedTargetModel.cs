namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterMutatedTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterMutatedTargetModel : FilterModel
{
	public string mutationId; //Field offset: 0x30
	public String[] mutationIds; //Field offset: 0x38
	public bool inverse; //Field offset: 0x40

	public FilterMutatedTargetModel(string name, string mutationId, bool inverse) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

