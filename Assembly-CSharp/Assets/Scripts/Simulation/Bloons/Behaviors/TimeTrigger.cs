namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class TimeTrigger : BloonBehaviorTrigger
{
	public TimeTriggerModel timeTriggerModel; //Field offset: 0x70
	private List<BloonBehaviorAction> actions; //Field offset: 0x78
	private int lastActivatedAt; //Field offset: 0x80
	private int timeTriggerPauseCount; //Field offset: 0x84
	private int simElapsedLast; //Field offset: 0x88

	public bool IsTimeTriggerPaused
	{
		 get { } //Length: 11
	}

	public int LastActivatedAt
	{
		 get { } //Length: 7
	}

	public TimeTrigger() { }

	public virtual void Attatched() { }

	public bool get_IsTimeTriggerPaused() { }

	public int get_LastActivatedAt() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public void SetPause(bool isPaused) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void Trigger() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

