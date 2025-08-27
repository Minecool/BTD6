namespace Assets.Scripts.Simulation.Behaviors.Events;

public abstract class EntityTrigger : RootBehavior
{
	public EntityTriggerModel entityTriggerModel; //Field offset: 0x58
	private bool isTriggered; //Field offset: 0x60
	protected EntityEvent entityEvent; //Field offset: 0x68

	public bool IsTriggered
	{
		 get { } //Length: 5
	}

	public Vector2 Position
	{
		 get { } //Length: 142
	}

	protected EntityTrigger() { }

	public bool get_IsTriggered() { }

	public Vector2 get_Position() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public override void ResetTrigger() { }

	public void SetEntityEvent(EntityEvent entityEvent) { }

	public void Trigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

