namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RangeUpFromUpgrade : TowerBehavior
{
	public class Mutator : BehaviorMutator
	{
		private readonly float rangeIncrease; //Field offset: 0x70

		public Mutator(string id, float rangeIncrease) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public RangeUpFromUpgradeModel rangeUpFromUpgradeModel; //Field offset: 0x68
	private Mutator mutator; //Field offset: 0x70
	private int upgradeCount; //Field offset: 0x78

	public RangeUpFromUpgrade() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void TestTower(Tower testTower, TowerModel def, float cost, int pathUpgraded) { }

	private void TowerCreated(Tower testTower, TowerModel def, float cost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void TowerDestroyed(Tower testTower) { }

	private void TowerUpgraded(Tower testTower, TowerModel def, float cost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

