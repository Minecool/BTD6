namespace Assets.Scripts.Simulation.Map.Triggers;

public class SimTimeElapsedTrigger : MapTrigger
{
	private SimTimeElapsedTriggerModel simTimeElapsedTriggerModel; //Field offset: 0x80
	private int startedCountingAt; //Field offset: 0x88
	private int timeFrames; //Field offset: 0x8C
	private int startCountingAtFromSave; //Field offset: 0x90

	public SimTimeElapsedTrigger() { }

	public virtual void CheckIfTriggered() { }

	public virtual void DeInit() { }

	public void ForceCooldown() { }

	private int GetFramesSinceStart() { }

	public virtual MapEventTriggerSaveData GetSaveData() { }

	public virtual void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsCurrentDurationOver() { }

	private void Process(int elapsed) { }

	public void ReduceTime(int framesToReduce) { }

	public virtual void SetSaveData(MapEventTriggerSaveData saveData) { }

}

