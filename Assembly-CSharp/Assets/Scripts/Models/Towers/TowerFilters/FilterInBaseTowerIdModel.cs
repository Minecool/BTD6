namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterInBaseTowerId), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterInBaseTowerIdModel : TowerFilterModel
{
	public String[] baseIds; //Field offset: 0x30

	public FilterInBaseTowerIdModel(string name, String[] baseIds) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

