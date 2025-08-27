namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class ParagonOfPower : SimulationBehavior
{
	public ParagonOfPowerModel paragonOfPowerModel; //Field offset: 0x58
	private readonly List<Tower> paragonTowersOfType; //Field offset: 0x60
	private readonly Dictionary<Int32, List`1<String>> needsUpdateForOwners; //Field offset: 0x68

	public ParagonOfPower() { }

	private void AddBuff(Tower addTo) { }

	private void CheckBuffs(Tower towerToCheck, string towerBaseId, int owner, bool isTowerDestroyed) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower destroyedTower) { }

	private void OnTowerUpgraded(Tower upgradedTower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void Process(int elapsed) { }

	private void RemoveBuff(Tower removeFrom) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

