namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnPropDestroyedTrigger : EntityTrigger
{
	public OnPropDestroyedTriggerModel onPropDestroyedTriggerModel; //Field offset: 0x70

	public OnPropDestroyedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnPropDestroyed(PropToSimulation bridgeProp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

