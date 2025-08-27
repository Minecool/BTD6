namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerTransformedTrigger : EntityTrigger
{
	public OnTowerTransformedTriggerModel behaviorModel; //Field offset: 0x70

	public OnTowerTransformedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

