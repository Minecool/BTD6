namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnPlacementCircleInteraction : EntityTrigger
{
	public OnPlacementCircleInteractionModel behaviorModel; //Field offset: 0x70

	public OnPlacementCircleInteraction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnEvent(Dictionary<String, Boolean> placementData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

