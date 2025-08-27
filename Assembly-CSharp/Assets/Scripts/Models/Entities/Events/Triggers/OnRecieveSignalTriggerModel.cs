namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnRecieveSignalTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnRecieveSignalTriggerModel : EntityTriggerModel
{
	public String[] signalIds; //Field offset: 0x38
	public bool requireAllSignals; //Field offset: 0x40
	public int resetWaitAfterSeconds; //Field offset: 0x44
	public bool allowDuplicateFrameTriggers; //Field offset: 0x48
	[CompilerGenerated]
	private int <WaitDurationFramesTotal>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <ShouldScheduleReset>k__BackingField; //Field offset: 0x50

	public private bool ShouldScheduleReset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int WaitDurationFramesTotal
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public OnRecieveSignalTriggerModel(string name, String[] signalIds, bool requireAllSignals, int resetWaitAfterSeconds, bool allowDuplicateFrameTriggers) { }

	public virtual Model Clone() { }

	[CompilerGenerated]
	public bool get_ShouldScheduleReset() { }

	[CompilerGenerated]
	public int get_WaitDurationFramesTotal() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	[CompilerGenerated]
	private void set_ShouldScheduleReset(bool value) { }

	[CompilerGenerated]
	private void set_WaitDurationFramesTotal(int value) { }

}

