namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class RemovePlacementCircleAction : EntityAction
{
	public RemovePlacementCircleActionModel behaviorModel; //Field offset: 0x68

	public RemovePlacementCircleAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

