namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerUpgradedTrigger : EntityTrigger
{
	public OnTowerUpgradedTriggerModel onTowerUpgradedTriggerModel; //Field offset: 0x70

	public OnTowerUpgradedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

