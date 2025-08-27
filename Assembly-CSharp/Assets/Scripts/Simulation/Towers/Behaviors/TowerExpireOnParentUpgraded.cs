namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerExpireOnParentUpgraded : TowerBehavior
{
	public TowerExpireOnParentUpgradedModel towerExpireOnParentUpgradedModel; //Field offset: 0x68
	private Tower parentTower; //Field offset: 0x70
	private bool getParentTower; //Field offset: 0x78

	public TowerExpireOnParentUpgraded() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void Process(int elapsed) { }

	private void TowerUpgraded(Tower upgradedTower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

