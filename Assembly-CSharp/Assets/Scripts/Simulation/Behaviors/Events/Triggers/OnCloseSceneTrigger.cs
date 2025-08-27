namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnCloseSceneTrigger : EntityTrigger
{
	public OnCloseSceneTriggerModel behaviorModel; //Field offset: 0x70

	public OnCloseSceneTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTriggerHit(string sceneName) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

