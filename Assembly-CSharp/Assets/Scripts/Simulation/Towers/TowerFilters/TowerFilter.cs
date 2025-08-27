namespace Assets.Scripts.Simulation.Towers.TowerFilters;

public abstract class TowerFilter : RootBehavior
{

	protected TowerFilter() { }

	public override bool FilterTower(Tower tower) { }

	public override bool FilterTowerModel(TowerModel towerModel) { }

}

