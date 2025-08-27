namespace Assets.Scripts.Simulation.Behaviors.Events;

public abstract class EntityAction : RootBehavior
{
	public EntityActionModel entityActionModel; //Field offset: 0x58
	protected EntityEvent entityEvent; //Field offset: 0x60

	public Vector3 Position
	{
		 get { } //Length: 224
	}

	public Vector2 Position2D
	{
		 get { } //Length: 142
	}

	protected EntityAction() { }

	public Vector3 get_Position() { }

	public Vector2 get_Position2D() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void PerformAction() { }

	public void SetEntityEvent(EntityEvent entityEvent) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

