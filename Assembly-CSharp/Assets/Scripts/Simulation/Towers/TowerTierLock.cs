namespace Assets.Scripts.Simulation.Towers;

public interface TowerTierLock
{

	public bool isTierLocked(int path, int tier) { }

	public bool OverrideMaxTierLimit(int path, int tier) { }

}

