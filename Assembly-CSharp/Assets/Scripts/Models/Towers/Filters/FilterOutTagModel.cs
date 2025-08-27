namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterOutTag), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterOutTagModel : FilterModel
{
	public string tag; //Field offset: 0x30
	public String[] disableWhenSupportMutatorIDs; //Field offset: 0x38

	public FilterOutTagModel(string name, string tag, String[] disableWhenSupportMutatorIDs) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public static bool RemoveFilterOnAddBehaviorIfMutatorExists(Model model, string mutatorId) { }

}

