namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class DestroyProjectilesAction : EntityAction
{
	public DestroyProjectilesActionModel destroyProjectilesActionModel; //Field offset: 0x68

	public DestroyProjectilesAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

