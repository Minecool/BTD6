namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class CreatePlacementCircleAction : EntityAction
{
	public CreatePlacementCircleActionModel behaviorModel; //Field offset: 0x68

	public CreatePlacementCircleAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

