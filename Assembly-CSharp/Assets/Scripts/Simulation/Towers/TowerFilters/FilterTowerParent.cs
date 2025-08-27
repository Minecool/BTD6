namespace Assets.Scripts.Simulation.Towers.TowerFilters;

public class FilterTowerParent : TowerFilter
{
	public FilterTowerParentModel filterTowerParentModel; //Field offset: 0x58
	private Tower attachedTower; //Field offset: 0x60

	public FilterTowerParent() { }

	public virtual bool FilterTower(Tower tower) { }

	public virtual bool FilterTowerModel(TowerModel towerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

