namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class StartRoundAction : EntityAction
{
	public StartRoundActionModel startRoundActionModel; //Field offset: 0x68

	public StartRoundAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

