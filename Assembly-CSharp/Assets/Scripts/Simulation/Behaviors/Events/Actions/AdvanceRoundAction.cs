namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class AdvanceRoundAction : EntityAction
{
	public AdvanceRoundActionModel advanceRoundActionModel; //Field offset: 0x68

	public AdvanceRoundAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

