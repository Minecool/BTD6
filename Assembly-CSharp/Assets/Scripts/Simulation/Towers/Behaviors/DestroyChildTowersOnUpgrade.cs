namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DestroyChildTowersOnUpgrade : TowerBehavior
{
	public DestroyChildTowersOnUpgradeModel destroyChildTowersOnUpgradeModel; //Field offset: 0x68

	public DestroyChildTowersOnUpgrade() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void TowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

