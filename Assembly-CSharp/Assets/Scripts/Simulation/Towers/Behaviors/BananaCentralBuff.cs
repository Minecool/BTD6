namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BananaCentralBuff : TowerBehaviorBuff
{
	public class Mutator : BehaviorMutator
	{
		private readonly BananaCentralBuff parent; //Field offset: 0x70

		public Mutator(BananaCentralBuff parent) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public BananaCentralBuffModel bananaCentralBuffModel; //Field offset: 0x70
	private Mutator mutator; //Field offset: 0x78

	public BananaCentralBuff() { }

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

