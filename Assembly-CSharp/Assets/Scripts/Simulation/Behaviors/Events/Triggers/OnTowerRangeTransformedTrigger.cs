namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerRangeTransformedTrigger : EntityTrigger
{
	public OnTowerRangeTransformedTriggerModel behaviorModel; //Field offset: 0x70

	public OnTowerRangeTransformedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(Tower tower) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

