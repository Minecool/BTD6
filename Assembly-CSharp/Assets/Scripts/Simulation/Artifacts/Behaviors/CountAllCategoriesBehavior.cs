namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class CountAllCategoriesBehavior : ItemArtifactBehavior
{
	public CountAllCategoriesBehaviorModel countAllCategoriesBehaviorModel; //Field offset: 0x78

	public CountAllCategoriesBehavior() { }

	private void CheckTower(Tower towerToCheck) { }

	private bool CheckTowerModel(TowerModel towerModelToCheck) { }

	public bool CheckTowerSet(TowerSet towerSet) { }

	public virtual void GetPreModifiedPlacementModel(ref TowerModel clonedTowerModel) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsChangingPlacementModel(TowerModel towerModel) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

