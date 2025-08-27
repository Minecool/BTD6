namespace NinjaKiwi.GUTS.Models.Endpoints;

public struct SubmittedScore
{
	[CompilerGenerated]
	private ulong <Damage>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private byte <Stage>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <DaysSinceEventStart>k__BackingField; //Field offset: 0xC

	public ulong Damage
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int DaysSinceEventStart
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public byte Stage
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[CompilerGenerated]
	[IsReadOnly]
	public ulong get_Damage() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_DaysSinceEventStart() { }

	[CompilerGenerated]
	[IsReadOnly]
	public byte get_Stage() { }

	[CompilerGenerated]
	public void set_Damage(ulong value) { }

	[CompilerGenerated]
	public void set_DaysSinceEventStart(int value) { }

	[CompilerGenerated]
	public void set_Stage(byte value) { }

}

