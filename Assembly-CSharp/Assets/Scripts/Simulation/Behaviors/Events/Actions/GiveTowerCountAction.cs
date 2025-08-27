namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class GiveTowerCountAction : EntityAction
{
	public GiveTowerCountActionModel giveTowerCountActionModel; //Field offset: 0x68

	public GiveTowerCountAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

