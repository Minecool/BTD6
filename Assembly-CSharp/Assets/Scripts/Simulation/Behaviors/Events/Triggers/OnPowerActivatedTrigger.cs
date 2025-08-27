namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnPowerActivatedTrigger : EntityTrigger
{
	public OnPowerActivatedTriggerModel onPowerActivatedTriggerModel; //Field offset: 0x70

	public OnPowerActivatedTrigger() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnPowerActivated(PowerModel def, float locationx, float locationy, int inputid) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

