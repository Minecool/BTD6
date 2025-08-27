namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnTimePassedTrigger : EntityTrigger
{
	public OnTimePassedTriggerModel onTimePassedTriggerModel; //Field offset: 0x70
	private int countFrom; //Field offset: 0x78

	public OnTimePassedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundStart(int round) { }

	private void Process(int elapsed) { }

	private void PullTrigger() { }

	public virtual void ResetTrigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

