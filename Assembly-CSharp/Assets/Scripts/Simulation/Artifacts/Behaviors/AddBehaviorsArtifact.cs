namespace Assets.Scripts.Simulation.Artifacts.Behaviors;

public class AddBehaviorsArtifact : ItemArtifactBehavior
{
	public AddBehaviorArtifactBaseModel addProjectileBehaviorsArtifactModel; //Field offset: 0x78

	public AddBehaviorsArtifact() { }

	private void CheckTower(Tower tower) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerSetChanged(Tower tower) { }

	private void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

