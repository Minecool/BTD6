namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public abstract class TapTowerAbilityBehavior : AbilityBehavior
{
	protected static readonly String[] towerBanList; //Field offset: 0x0
	protected Tower selectedTower; //Field offset: 0x68

	private static TapTowerAbilityBehavior() { }

	protected TapTowerAbilityBehavior() { }

	public virtual bool CanTechBotActivate() { }

	public virtual bool CanUseAbility() { }

	public virtual string GetCustomInputClass(bool onAbilityActived = true) { }

	public virtual object GetCustomInputData() { }

	protected abstract PrefabReference GetSelectionObjectPath() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected override bool IsBanned(Tower tower) { }

	protected override bool IsParagonMode() { }

	protected virtual void OnDestroy() { }

	private void OnTowerDestroyed(Tower tower) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

}

