namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTowerSelectedTrigger : EntityTrigger
{
	public OnTowerSelectedTriggerModel behaviorModel; //Field offset: 0x70

	public OnTowerSelectedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(ISelectable selected) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

