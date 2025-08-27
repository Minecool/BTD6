namespace NinjaKiwi.GUTS.Models.Sweepstakes;

[Nullable(0)]
[NullableContext(2)]
public class SweepstakesTaskSettings
{
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Int32[] <StepRewards>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Int32[] <StepTargets>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private SweepstakesTaskStepConditions[] <StepConditions>k__BackingField; //Field offset: 0x28

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public SweepstakesTaskStepConditions[] StepConditions
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Int32[] StepRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Int32[] StepTargets
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SweepstakesTaskSettings() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public SweepstakesTaskStepConditions[] get_StepConditions() { }

	[CompilerGenerated]
	public Int32[] get_StepRewards() { }

	[CompilerGenerated]
	public Int32[] get_StepTargets() { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_StepConditions(SweepstakesTaskStepConditions[] value) { }

	[CompilerGenerated]
	public void set_StepRewards(Int32[] value) { }

	[CompilerGenerated]
	public void set_StepTargets(Int32[] value) { }

	public ValueTuple<Boolean, String> Validate() { }

}

