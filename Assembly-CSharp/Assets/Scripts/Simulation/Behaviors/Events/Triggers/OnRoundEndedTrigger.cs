namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnRoundEndedTrigger : EntityTrigger
{
	public OnRoundEndedTriggerModel onRoundEndedTriggerModel; //Field offset: 0x70

	public OnRoundEndedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnRoundEnd(int roundIndex) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

