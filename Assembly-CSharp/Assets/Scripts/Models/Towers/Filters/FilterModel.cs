namespace Assets.Scripts.Models.Towers.Filters;

public abstract class FilterModel : Model
{

	protected FilterModel(string name) { }

	public abstract Filter Create(FactoryFactory factory) { }

}

