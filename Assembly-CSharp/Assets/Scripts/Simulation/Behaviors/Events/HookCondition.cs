namespace Assets.Scripts.Simulation.Behaviors.Events;

public class HookCondition : EntityEvent
{
	public HookConditionModel behaviorModel; //Field offset: 0x78
	private Action<HookCondition, Object> OnTriggeredCallback; //Field offset: 0x80

	public HookCondition() { }

	public void CancelTriggers() { }

	public virtual void ExecuteActions() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTriggerHit(EntityTrigger entityTrigger) { }

	public virtual bool ReachedActivationLimit() { }

	public void ResetTriggersOnEndRound() { }

	public void SetupHook(Action<HookCondition, Object> onTriggeredCallback) { }

	public void ToggleTriggers(bool isPaused) { }

	public virtual void UpdateActions() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public virtual void UpdateTriggers() { }

}

