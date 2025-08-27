namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class DestroyPropsAction : EntityAction
{
	public DestroyPropsActionModel destroyPropsActionModel; //Field offset: 0x68

	public DestroyPropsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

