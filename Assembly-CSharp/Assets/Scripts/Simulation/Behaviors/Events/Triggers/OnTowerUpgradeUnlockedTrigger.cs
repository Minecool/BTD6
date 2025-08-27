namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerUpgradeUnlockedTrigger : EntityTrigger
{
	public OnTowerUpgradeUnlockedTriggerModel behaviorModel; //Field offset: 0x70

	public OnTowerUpgradeUnlockedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(TowerModel towerModel, UpgradeModel upgradeModel) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

