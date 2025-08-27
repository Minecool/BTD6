namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerUpgradeBlocker : TowerBehavior, TowerUpgradeLock
{
	public TowerUpgradeBlockerModel behaviorModel; //Field offset: 0x68

	public TowerUpgradeBlocker() { }

	public override int GetMaxTierForPath(int path) { }

	public override string GetUpgradeBlockId(int path, int tier) { }

	public override float GetUpgradeCost(float baseCost, int path, int tier) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsUpgradeBlocked(int path, int tier) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

