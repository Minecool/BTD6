namespace Assets.Scripts.Simulation.Behaviors.Events;

public class EntityEvent : RootBehavior
{
	public EntityEventModel entityEventModel; //Field offset: 0x58
	private readonly List<EntityTrigger> triggers; //Field offset: 0x60
	private readonly List<EntityAction> actions; //Field offset: 0x68
	private int timesActivated; //Field offset: 0x70

	public List<EntityAction> Actions
	{
		 get { } //Length: 5
	}

	public List<EntityTrigger> Triggers
	{
		 get { } //Length: 5
	}

	public EntityEvent() { }

	public void ExecuteActions() { }

	public List<EntityAction> get_Actions() { }

	public List<EntityTrigger> get_Triggers() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnTriggerHit(EntityTrigger entityTrigger) { }

	public bool ReachedActivationLimit() { }

	public void UpdateActions() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateTriggers() { }

}

