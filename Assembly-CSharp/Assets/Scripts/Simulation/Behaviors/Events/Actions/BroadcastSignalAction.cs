namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class BroadcastSignalAction : EntityAction
{
	public BroadcastSignalActionModel behaviorModel; //Field offset: 0x68
	public bool repeatingSignal; //Field offset: 0x70
	public int numIterations; //Field offset: 0x74
	public int elapsedStartTime; //Field offset: 0x78
	public int elapsedSinceLastAction; //Field offset: 0x7C
	public int elapsedTotalTime; //Field offset: 0x80

	public BroadcastSignalAction() { }

	private void CheckRepeatingSignal(int elapsed) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public void Process(int elapsed) { }

	private void Reset() { }

	private void StartRepeating() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

