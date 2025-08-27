namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(BroadcastSignalAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BroadcastSignalActionModel : EntityActionModel
{
	public String[] singalIds; //Field offset: 0x38
	public bool isRepeating; //Field offset: 0x40
	public int iterations; //Field offset: 0x44
	public int durationSeconds; //Field offset: 0x48
	[CompilerGenerated]
	private int <DurationFramesTotal>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private int <DurationFramesPerIteration>k__BackingField; //Field offset: 0x50

	public private int DurationFramesPerIteration
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int DurationFramesTotal
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BroadcastSignalActionModel(string name, String[] singalIds, bool isRepeating, int durationSeconds, int iterations) { }

	public virtual Model Clone() { }

	[CompilerGenerated]
	public int get_DurationFramesPerIteration() { }

	[CompilerGenerated]
	public int get_DurationFramesTotal() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	[CompilerGenerated]
	private void set_DurationFramesPerIteration(int value) { }

	[CompilerGenerated]
	private void set_DurationFramesTotal(int value) { }

}

