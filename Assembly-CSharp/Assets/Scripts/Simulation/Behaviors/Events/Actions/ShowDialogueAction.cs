namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class ShowDialogueAction : EntityAction
{
	public ShowDialogueActionModel behaviorModel; //Field offset: 0x68

	public ShowDialogueAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

