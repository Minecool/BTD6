namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnPropAddedTrigger : EntityTrigger
{
	public OnPropAddedTriggerModel onPropAddedTriggerModel; //Field offset: 0x70

	public OnPropAddedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnPropPlaced(PropToSimulation bridgeProp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

