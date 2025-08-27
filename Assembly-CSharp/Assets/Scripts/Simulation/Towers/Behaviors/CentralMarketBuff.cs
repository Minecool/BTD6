namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CentralMarketBuff : TowerBehaviorBuff
{
	public class CentralMarketMutator : BehaviorMutator
	{
		private readonly CentralMarketBuffModel centralMarketBuffModel; //Field offset: 0x70

		public CentralMarketMutator(CentralMarketBuffModel centralMarketBuffModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public CentralMarketBuffModel centralMarketBuffModel; //Field offset: 0x70
	private CentralMarketMutator mutator; //Field offset: 0x78

	public CentralMarketBuff() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual BuffQuery TestPlacementTowerBuff(TowerModel placementModel, Vector3 placementPosition, int owner) { }

	private void TestTower(Tower testTower, TowerModel def, float cost, int pathUpgraded) { }

	private void TowerCreated(Tower testTower, TowerModel def, float cost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void TowerSuspendedStateChanged() { }

	private void TowerUpgraded(Tower testTower, TowerModel def, float cost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

