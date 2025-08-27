namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MonkeyopolisUpgradeCost : TowerBehavior, TowerUpgradeLock
{
	public MonkeyopolisUpgradeCostModel monkeyopolisUpgradeModel; //Field offset: 0x68

	public MonkeyopolisUpgradeCost() { }

	public override int GetMaxTierForPath(int path) { }

	public override string GetUpgradeBlockId(int path, int tier) { }

	public override float GetUpgradeCost(float baseCost, int path, int tier) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsUpgradeBlocked(int path, int tier) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

