namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SilasIceMonkeyUpgradeLock : TowerBehavior, TowerTierLock
{
	private const int TowerTier = 5; //Field offset: 0x0
	public SilasIceMonkeyUpgradeLockModel silasIceMonkeyUpgradeLockModel; //Field offset: 0x68

	public SilasIceMonkeyUpgradeLock() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool isTierLocked(int path, int tier) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public override bool OverrideMaxTierLimit(int path, int tier) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

