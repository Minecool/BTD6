namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class WinGameAction : EntityAction
{
	public WinGameActionModel winGameActionModel; //Field offset: 0x68

	public WinGameAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

