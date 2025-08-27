namespace Assets.Scripts.Models.Towers.TowerFilters;

public abstract class TowerFilterModel : Model
{

	protected TowerFilterModel(string name) { }

	public abstract TowerFilter Create(FactoryFactory factory) { }

}

