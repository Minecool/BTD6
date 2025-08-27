namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class RemoveAllPlacementCirclesAction : EntityAction
{
	public RemoveAllPlacementCirclesActionModel behaviorModel; //Field offset: 0x68

	public RemoveAllPlacementCirclesAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

