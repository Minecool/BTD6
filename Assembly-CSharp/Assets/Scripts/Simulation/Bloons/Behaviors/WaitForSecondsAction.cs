namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class WaitForSecondsAction : BloonBehaviorAction
{
	public WaitForSecondsActionModel waitForSecondsActionModel; //Field offset: 0x78
	private float delayTime; //Field offset: 0x80
	private bool isTimerOn; //Field offset: 0x84
	private int startingTime; //Field offset: 0x88

	public WaitForSecondsAction() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void TriggerActions() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

