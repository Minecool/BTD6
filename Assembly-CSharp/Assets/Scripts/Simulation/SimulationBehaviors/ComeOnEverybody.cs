namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class ComeOnEverybody : SimulationBehavior
{
	public ComeOnEverybodyModel comeOnEverybodyModel; //Field offset: 0x58
	private readonly HashSet<Int32> needsUpdateForOwners; //Field offset: 0x60

	public ComeOnEverybody() { }

	private void AddDiscountBuff(Tower addTo) { }

	private void AddRateBuff(Tower addTo) { }

	private void CheckBuffs(Tower towerToCheck, TowerSet towerSet, int owner, bool removed) { }

	public float GetDiscount(Tower towerToCheck, int path, int tier) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower destroyedTower) { }

	private void OnTowerUpgraded(Tower upgradedTower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void Process(int elapsed) { }

	private void RemoveDiscountBuff(Tower removeFrom) { }

	private void RemoveRateBuff(Tower removeFrom) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

