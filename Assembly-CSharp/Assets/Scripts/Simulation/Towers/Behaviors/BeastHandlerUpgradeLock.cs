namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BeastHandlerUpgradeLock : TowerBehavior, TowerUpgradeLock
{
	public BeastHandlerUpgradeLockModel beastHandlerUpgradeLockModel; //Field offset: 0x68
	private BeastHandlerLeash thisBeastHandlerLeash; //Field offset: 0x70

	public BeastHandlerUpgradeLock() { }

	public int GetCurrentContributionsForUpgrade(string petBaseId, int tier) { }

	public override int GetMaxTierForPath(int path) { }

	public override string GetUpgradeBlockId(int path, int tier) { }

	public override float GetUpgradeCost(float baseCost, int path, int tier) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool IsUpgradeBlocked(int path, int tier) { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

