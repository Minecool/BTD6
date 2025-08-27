namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnMatchReadyTrigger : EntityTrigger
{
	public OnMatchReadyTriggerModel behaviorModel; //Field offset: 0x70

	public OnMatchReadyTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(bool loadedSave) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

