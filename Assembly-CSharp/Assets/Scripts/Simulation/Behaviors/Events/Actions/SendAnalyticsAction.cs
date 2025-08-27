namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class SendAnalyticsAction : EntityAction
{
	public SendAnalyticsActionModel behaviorModel; //Field offset: 0x68

	public SendAnalyticsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

