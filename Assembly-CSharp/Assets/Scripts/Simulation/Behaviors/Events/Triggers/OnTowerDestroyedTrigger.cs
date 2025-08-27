namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerDestroyedTrigger : EntityTrigger
{
	public OnTowerDestroyedTriggerModel onTowerDestroyedTriggerModel; //Field offset: 0x70

	public OnTowerDestroyedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerDestroyed(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

