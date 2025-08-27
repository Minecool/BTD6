namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class DestroyBloonsAction : EntityAction
{
	public DestroyBloonsActionModel destroyBloonsActionModel; //Field offset: 0x68

	public DestroyBloonsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

