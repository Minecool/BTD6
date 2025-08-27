namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SetTargetPriorityOnUpgrade : TowerBehavior
{
	public SetTargetPriorityOnUpgradeModel setTargetPriorityOnUpgradeModel; //Field offset: 0x68

	public SetTargetPriorityOnUpgrade() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnTowerUpgraded(Tower tower, TowerModel def, float cost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

