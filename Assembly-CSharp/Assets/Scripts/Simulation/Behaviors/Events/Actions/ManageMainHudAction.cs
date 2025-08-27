namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class ManageMainHudAction : EntityAction
{
	public ManageMainHudActionModel behaviorModel; //Field offset: 0x68

	public ManageMainHudAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

