namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnCashChangedTrigger : EntityTrigger
{
	public OnCashChangedTriggerModel behaviorModel; //Field offset: 0x70

	public OnCashChangedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

