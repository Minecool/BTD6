namespace Assets.Scripts.Simulation.Towers.TowerFilters;

public class FilterInTowerTiers : TowerFilter
{
	public FilterInTowerTiersModel filterInTowerTiersModel; //Field offset: 0x58

	public FilterInTowerTiers() { }

	public virtual bool FilterTower(Tower tower) { }

	public virtual bool FilterTowerModel(TowerModel towerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

