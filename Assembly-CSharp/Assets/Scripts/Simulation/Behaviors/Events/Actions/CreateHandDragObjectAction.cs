namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class CreateHandDragObjectAction : EntityAction
{
	public CreateHandDragObjectActionModel behaviorModel; //Field offset: 0x68

	public CreateHandDragObjectAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

