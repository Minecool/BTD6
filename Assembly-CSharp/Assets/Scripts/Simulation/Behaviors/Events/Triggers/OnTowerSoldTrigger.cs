namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerSoldTrigger : EntityTrigger
{
	public OnTowerSoldTriggerModel onTowerSoldTriggerModel; //Field offset: 0x70

	public OnTowerSoldTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerSold(Tower tower, float sellWorth, double cashBefore, double cashAfter) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

