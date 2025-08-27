namespace Assets.Scripts.Simulation.Map.Triggers;

public class RepeatableTrigger : MapTrigger
{
	private RepeatableTriggerModel repeatableTriggerModel; //Field offset: 0x80

	public RepeatableTrigger() { }

	public virtual void DeInit() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

