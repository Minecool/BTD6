namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBloonSpawnedTrigger : EntityTrigger
{
	public OnBloonSpawnedTriggerModel behaviorModel; //Field offset: 0x70

	public OnBloonSpawnedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnBloonDegrade(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

