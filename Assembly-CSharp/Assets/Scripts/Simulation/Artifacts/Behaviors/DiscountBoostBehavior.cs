namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class DiscountBoostBehavior : BoostArtifactBehavior
{
	public DiscountBoostBehaviorModel discountBoostBehaviorModel; //Field offset: 0x78

	public DiscountBoostBehavior() { }

	public virtual float GetDiscount(Tower tower, int path, int tier) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTowerEnterZone(Tower tower) { }

	public virtual void OnTowerExitZone(Tower tower) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

}

