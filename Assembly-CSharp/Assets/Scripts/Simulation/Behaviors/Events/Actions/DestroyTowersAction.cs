namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class DestroyTowersAction : EntityAction
{
	public DestroyTowersActionModel destroyTowersActionModel; //Field offset: 0x68

	public DestroyTowersAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

