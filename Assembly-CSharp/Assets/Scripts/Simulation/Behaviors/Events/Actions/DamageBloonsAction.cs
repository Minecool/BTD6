namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class DamageBloonsAction : EntityAction
{
	public DamageBloonsActionModel damageBloonsActionModel; //Field offset: 0x68

	public DamageBloonsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

