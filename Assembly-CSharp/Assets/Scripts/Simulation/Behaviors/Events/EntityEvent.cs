namespace Assets.Scripts.Simulation.Behaviors.Events;

public class EntityEvent : RootBehavior
{
	public EntityEventModel entityEventModel; //Field offset: 0x58
	protected readonly List<EntityTrigger> triggers; //Field offset: 0x60
	protected readonly List<EntityAction> actions; //Field offset: 0x68
	protected int timesActivated; //Field offset: 0x70

	public List<EntityAction> Actions
	{
		 get { } //Length: 5
	}

	public List<EntityTrigger> Triggers
	{
		 get { } //Length: 5
	}

	public EntityEvent() { }

	public override void ExecuteActions() { }

	public List<EntityAction> get_Actions() { }

	public List<EntityTrigger> get_Triggers() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public override void OnTriggerHit(EntityTrigger entityTrigger) { }

	public override bool ReachedActivationLimit() { }

	public override void UpdateActions() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public override void UpdateTriggers() { }

}

