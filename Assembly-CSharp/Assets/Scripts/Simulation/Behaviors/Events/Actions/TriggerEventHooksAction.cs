namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class TriggerEventHooksAction : EntityAction
{
	public TriggerEventHooksActionModel behaviorModel; //Field offset: 0x68

	public TriggerEventHooksAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

