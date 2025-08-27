namespace Assets.Scripts.Simulation.Towers;

public interface TowerUpgradeLock
{

	public int GetMaxTierForPath(int path) { }

	public string GetUpgradeBlockId(int path, int tier) { }

	public float GetUpgradeCost(float baseCost, int path, int tier) { }

	public bool IsUpgradeBlocked(int path, int tier) { }

}

