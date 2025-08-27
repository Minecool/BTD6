namespace NinjaKiwi.Common;

[ComVisible(True)]
public class Random
{
	private const int MBIG = 2147483647; //Field offset: 0x0
	private const int MSEED = 161803398; //Field offset: 0x0
	private const int MZ = 0; //Field offset: 0x0
	private int inext; //Field offset: 0x10
	private int inextp; //Field offset: 0x14
	private Int32[] SeedArray; //Field offset: 0x18

	public Random() { }

	public Random(int Seed) { }

	public Random(RandomState state) { }

	private double GetSampleForLargeRange() { }

	private int InternalSample() { }

	public RandomState MakeState() { }

	public override int Next() { }

	public override int Next(int minValue, int maxValue) { }

	public override int Next(int maxValue) { }

	public override void NextBytes(Byte[] buffer) { }

	public override double NextDouble() { }

	public void RestoreState(RandomState state) { }

	protected override double Sample() { }

}

