namespace Assets.Scripts.Simulation.Map.Triggers;

public class TowerInAreaTrigger : MapTrigger
{
	private TowerInAreaTriggerModel towerInAreaTriggerModel; //Field offset: 0x80

	public TowerInAreaTrigger() { }

	private void CheckTower(Tower tower) { }

	public virtual void DeInit() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerMutated(Tower tower, BehaviorMutator mutator) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

}

