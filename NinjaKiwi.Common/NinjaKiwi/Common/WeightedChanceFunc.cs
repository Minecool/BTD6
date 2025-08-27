namespace NinjaKiwi.Common;

public struct WeightedChanceFunc : IWeightedChance
{
	[CompilerGenerated]
	private readonly Action <Func>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly double <Ratio>k__BackingField; //Field offset: 0x8

	public Action Func
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public override double Ratio
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
	}

	public WeightedChanceFunc(double ratio, Action func) { }

	[CompilerGenerated]
	[IsReadOnly]
	public Action get_Func() { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_Ratio() { }

}

