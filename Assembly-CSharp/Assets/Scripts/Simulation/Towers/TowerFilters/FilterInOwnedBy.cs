namespace Assets.Scripts.Simulation.Towers.TowerFilters;

public class FilterInOwnedBy : TowerFilter
{
	public FilterInOwnedByModel filterInOwnedByModel; //Field offset: 0x58

	public FilterInOwnedBy() { }

	public virtual bool FilterTower(Tower tower) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

