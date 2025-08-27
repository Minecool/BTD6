namespace Assets.Scripts.Simulation.Map.Triggers;

public class StartMapTrigger : MapTrigger
{
	private bool mapStarted; //Field offset: 0x80

	public StartMapTrigger() { }

	public virtual void CheckIfTriggered() { }

	public virtual void DeInit() { }

	public virtual MapEventTriggerSaveData GetSaveData() { }

	public virtual void Init() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveData(MapEventTriggerSaveData saveData) { }

}

