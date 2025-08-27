namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(PyrotechnicsSupportFilter), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PyrotechnicsSupportFilterModel : TowerFilterModel
{

	public PyrotechnicsSupportFilterModel(string name) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

