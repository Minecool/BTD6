namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterOveridingMutatedTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterOveridingMutatedTargetModel : FilterModel
{
	public string mutationId; //Field offset: 0x30
	public String[] mutationOverideOrder; //Field offset: 0x38
	public string highestPriorityMutationId; //Field offset: 0x40
	public string defaultMutationId; //Field offset: 0x48

	public FilterOveridingMutatedTargetModel(string name, String[] mutationOverideOrder, string highestPriorityMutationId, string defaultMutationId) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

