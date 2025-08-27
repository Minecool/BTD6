namespace Assets.Scripts.Models.Towers.Filters;

[Implementation(typeof(FilterIfAttackHasTarget), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterIfAttackHasTargetModel : FilterModel
{
	public string attackName; //Field offset: 0x30

	public FilterIfAttackHasTargetModel(string name, string attackName) { }

	public virtual Model Clone() { }

	public virtual Filter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

