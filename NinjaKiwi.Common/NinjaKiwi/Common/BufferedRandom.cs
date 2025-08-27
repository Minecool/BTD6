namespace NinjaKiwi.Common;

public class BufferedRandom
{
	private const double inverse = 4.656612875245797E-10; //Field offset: 0x0
	private Random rng; //Field offset: 0x10
	private int next; //Field offset: 0x18

	public BufferedRandom(int seed) { }

	public int Next() { }

	public override int Next(int maxValue) { }

	public override int Next(int minValue, int maxValue) { }

	public double NextDouble() { }

	public int PeekNext() { }

	public double PeekNextDouble() { }

}

