namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnBossSpawnedTrigger : EntityTrigger
{
	public OnBossSpawnedTriggerModel behaviorModel; //Field offset: 0x70

	public OnBossSpawnedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

