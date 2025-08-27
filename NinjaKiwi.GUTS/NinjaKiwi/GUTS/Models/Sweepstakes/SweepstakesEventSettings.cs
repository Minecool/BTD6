namespace NinjaKiwi.GUTS.Models.Sweepstakes;

public class SweepstakesEventSettings
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private SweepstakesTaskSettings[] <TasksSettings>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <ShareTickets>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <SeeShareTickets>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <OpenReferralTickets>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private TimeSpan <TaskUnlockInterval>k__BackingField; //Field offset: 0x28

	public int OpenReferralTickets
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int SeeShareTickets
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int ShareTickets
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public SweepstakesTaskSettings[] TasksSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TimeSpan TaskUnlockInterval
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SweepstakesEventSettings() { }

	[CompilerGenerated]
	public int get_OpenReferralTickets() { }

	[CompilerGenerated]
	public int get_SeeShareTickets() { }

	[CompilerGenerated]
	public int get_ShareTickets() { }

	[CompilerGenerated]
	public SweepstakesTaskSettings[] get_TasksSettings() { }

	[CompilerGenerated]
	public TimeSpan get_TaskUnlockInterval() { }

	[CompilerGenerated]
	public void set_OpenReferralTickets(int value) { }

	[CompilerGenerated]
	public void set_SeeShareTickets(int value) { }

	[CompilerGenerated]
	public void set_ShareTickets(int value) { }

	[CompilerGenerated]
	public void set_TasksSettings(SweepstakesTaskSettings[] value) { }

	[CompilerGenerated]
	public void set_TaskUnlockInterval(TimeSpan value) { }

	public ValueTuple<Boolean, String> Validate(DateTime eventStartTime, DateTime eventEndTime) { }

}

