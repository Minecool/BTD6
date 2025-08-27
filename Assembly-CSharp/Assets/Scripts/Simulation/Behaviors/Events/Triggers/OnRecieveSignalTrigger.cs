namespace Assets.Scripts.Simulation.Behaviors.Events.Triggers;

public class OnRecieveSignalTrigger : EntityTrigger
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string signal; //Field offset: 0x10
		public OnRecieveSignalTrigger <>4__this; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal bool <RecieveSignal>b__0(string x) { }

	}

	public OnRecieveSignalTriggerModel behaviorModel; //Field offset: 0x70
	private readonly HashSet<String> receivedSignals; //Field offset: 0x78
	private bool scheduledReset; //Field offset: 0x80
	private int elapsedStartTime; //Field offset: 0x84
	private int lastFrameTriggerWasRecieved; //Field offset: 0x88

	private bool ShouldScheduleReset
	{
		private get { } //Length: 96
	}

	public OnRecieveSignalTrigger() { }

	private bool CheckIfAllSignalsReceieved() { }

	private bool CheckIfAnySignalsReceieved(String[] signals) { }

	private bool get_ShouldScheduleReset() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public void RecieveSignal(String[] signals) { }

	private void Reset() { }

	private void ScheduleReset() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

