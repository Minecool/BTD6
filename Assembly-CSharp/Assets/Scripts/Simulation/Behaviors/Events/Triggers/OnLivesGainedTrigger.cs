namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnLivesGainedTrigger : EntityTrigger
{
	public OnLivesGainedTriggerModel onLivesGainedTriggerModel; //Field offset: 0x70

	public OnLivesGainedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnLivesGained(int amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

