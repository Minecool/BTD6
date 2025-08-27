namespace NinjaKiwi.Common;

public struct WeightedChanceValue : IWeightedChance
{
	[CompilerGenerated]
	private readonly T <Value>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly double <Ratio>k__BackingField; //Field offset: 0x0

	public override double Ratio
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 6
	}

	public T Value
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
	}

	public WeightedChanceValue`1(double ratio, T value) { }

	[CompilerGenerated]
	[IsReadOnly]
	public override double get_Ratio() { }

	[CompilerGenerated]
	[IsReadOnly]
	public T get_Value() { }

}

