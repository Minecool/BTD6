namespace Assets.Scripts.Simulation.Towers.TowerFilters;

public class FilterParagon : TowerFilter
{
	public FilterParagonModel filterParagonModel; //Field offset: 0x58

	public FilterParagon() { }

	public virtual bool FilterTower(Tower tower) { }

	public virtual bool FilterTowerModel(TowerModel towerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

