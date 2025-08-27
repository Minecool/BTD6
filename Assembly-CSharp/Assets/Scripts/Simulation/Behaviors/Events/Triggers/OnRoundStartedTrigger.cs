namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnRoundStartedTrigger : EntityTrigger
{
	public OnRoundStartedTriggerModel onRoundStartedTriggerModel; //Field offset: 0x70

	public OnRoundStartedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundStart(int roundIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

