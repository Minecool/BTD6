namespace Assets.Scripts.Simulation.Behaviors.Events;

public abstract class EntityAction : RootBehavior
{
	public EntityActionModel entityActionModel; //Field offset: 0x58
	protected EntityEvent entityEvent; //Field offset: 0x60

	protected EntityAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void PerformAction() { }

	public void SetEntityEvent(EntityEvent entityEvent) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

