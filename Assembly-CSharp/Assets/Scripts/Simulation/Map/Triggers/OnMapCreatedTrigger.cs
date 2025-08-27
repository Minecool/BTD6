namespace Assets.Scripts.Simulation.Map.Triggers;

public class OnMapCreatedTrigger : MapTrigger
{
	private OnMapCreatedTriggerModel afterLoadTriggerModel; //Field offset: 0x80

	public OnMapCreatedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnMapCreated() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

