namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MonkeyBanker : TowerBehaviorBuff
{
	public MonkeyBankerModel monkeyBankerModel; //Field offset: 0x70
	private Zoned<Tower> zone; //Field offset: 0x78
	private readonly Dictionary<Tower, Single> loansToAdd; //Field offset: 0x80

	public MonkeyBanker() { }

	private bool CheckTowerModel(TowerModel towerModel) { }

	private void Deposit(Tower bananaFarm) { }

	private bool Filter(RootBehavior behavior) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower createdTower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerEnter(Tower towerInZone) { }

	private void OnTowerExit(Tower towerInZone) { }

	private void OnTowerUpgraded(Tower upgradedTower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void Process(int elapsed) { }

	private float Range() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

