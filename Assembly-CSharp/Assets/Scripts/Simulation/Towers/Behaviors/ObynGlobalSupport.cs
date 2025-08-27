namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ObynGlobalSupport : TowerBehavior
{
	public ObynGlobalSupportModel obynGlobalSupportModel; //Field offset: 0x68

	public ObynGlobalSupport() { }

	private void CheckTower(Tower towerToCheck) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerUpgraded(Tower upgradedTower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void RemoveMutators() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateSupport() { }

}

