namespace Assets.Scripts.Simulation.Map.Triggers;

public class StartRoundTrigger : MapTrigger
{
	private StartRoundTriggerModel modl; //Field offset: 0x80

	public StartRoundTrigger() { }

	public virtual void CheckIfTriggered() { }

	public virtual void DeInit() { }

	private int GetTriggerCount() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnRoundSet(bool fromSave) { }

	private void OnRoundStart(int roundSpawned) { }

	private bool TriggerCond() { }

}

