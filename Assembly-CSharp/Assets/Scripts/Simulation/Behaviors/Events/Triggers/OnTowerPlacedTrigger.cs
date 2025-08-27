namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerPlacedTrigger : EntityTrigger
{
	public OnTowerPlacedTriggerModel onTowerPlacedTriggerModel; //Field offset: 0x70

	public OnTowerPlacedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

