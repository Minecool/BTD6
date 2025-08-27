namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class ShowPopupHintAction : EntityAction
{
	public ShowPopupHintActionModel behaviorModel; //Field offset: 0x68

	public ShowPopupHintAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

