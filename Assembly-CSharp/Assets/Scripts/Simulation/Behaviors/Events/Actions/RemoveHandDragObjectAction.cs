namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class RemoveHandDragObjectAction : EntityAction
{
	public RemoveHandDragObjectActionModel behaviorModel; //Field offset: 0x68

	public RemoveHandDragObjectAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

