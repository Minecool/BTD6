namespace NinjaKiwi.GUTS.Models.Sweepstakes;

public class SweepstakesTaskStepConditions
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private String[] <Ids>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Nullable<Int32> <Count>k__BackingField; //Field offset: 0x18

	public Nullable<Int32> Count
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public String[] Ids
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SweepstakesTaskStepConditions() { }

	[CompilerGenerated]
	public Nullable<Int32> get_Count() { }

	[CompilerGenerated]
	public String[] get_Ids() { }

	[CompilerGenerated]
	public void set_Count(Nullable<Int32> value) { }

	[CompilerGenerated]
	public void set_Ids(String[] value) { }

	[NullableContext(1)]
	public ValueTuple<Boolean, String> Validate(string parentTaskId) { }

}

