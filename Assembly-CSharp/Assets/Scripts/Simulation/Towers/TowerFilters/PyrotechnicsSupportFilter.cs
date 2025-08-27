namespace Assets.Scripts.Simulation.Towers.TowerFilters;

public class PyrotechnicsSupportFilter : TowerFilter
{
	public PyrotechnicsSupportFilterModel pyrotechnicsSupportFilterModel; //Field offset: 0x58

	public PyrotechnicsSupportFilter() { }

	public virtual bool FilterTower(Tower tower) { }

	public virtual bool FilterTowerModel(TowerModel towerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

