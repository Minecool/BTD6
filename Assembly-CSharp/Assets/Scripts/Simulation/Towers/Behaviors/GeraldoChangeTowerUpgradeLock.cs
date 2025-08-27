namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class GeraldoChangeTowerUpgradeLock : TowerBehavior, TowerUpgradeLock
{
	public GeraldoChangeTowerUpgradeLockModel geraldoChangeTowerUpgradeLockModel; //Field offset: 0x68

	public GeraldoChangeTowerUpgradeLock() { }

	public override int GetMaxTierForPath(int path) { }

	public override string GetUpgradeBlockId(int path, int tier) { }

	public override float GetUpgradeCost(float baseCost, int path, int tier) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsUpgradeBlocked(int path, int tier) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

