namespace NinjaKiwi.Common;

public class SeededRandom
{
	private const int Multiplier = 16807; //Field offset: 0x0
	private const int Modulus = 2147483647; //Field offset: 0x0
	private const float twopi = 6.2831855; //Field offset: 0x0
	private long currentSeed; //Field offset: 0x10

	public long CurrentSeed
	{
		 get { } //Length: 5
	}

	public SeededRandom(long seed = 1) { }

	public SeededRandom(int seed = 1) { }

	public long get_CurrentSeed() { }

	public int Next() { }

	public double NextDouble() { }

	public float NextFloat() { }

	public float NextNormal() { }

	public float NormalRange(float min, float max) { }

	public int NormalRange(int min, int max) { }

	public Vector2 point() { }

	public int Range(int min, int max) { }

	public float Range(float min, float max) { }

	public void SetSeed(uint seed) { }

	public void SetSeed(long seed) { }

	public int sign() { }

}

