namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class AbilityStackingBehavior : ItemArtifactBehavior
{
	public AbilityStackingBehaviorModel abilityStackingBehaviorModel; //Field offset: 0x78

	public AbilityStackingBehavior() { }

	private void CheckTower(Tower towerToCheck) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

