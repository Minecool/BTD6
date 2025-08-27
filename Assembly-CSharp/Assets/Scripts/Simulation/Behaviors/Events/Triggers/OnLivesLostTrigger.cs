namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnLivesLostTrigger : EntityTrigger
{
	public OnLivesLostTriggerModel onLivesLostTriggerModel; //Field offset: 0x70

	public OnLivesLostTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnLivesLost(int amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

