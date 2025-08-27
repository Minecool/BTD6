namespace NinjaKiwi.Common;

[Extension]
public static class RandomExtensions
{
	private class RandomAdapter_Buf : IRandomAdapter
	{
		private BufferedRandom rand; //Field offset: 0x10

		public RandomAdapter_Buf(BufferedRandom rand) { }

		public override int Next() { }

		public override int Next(int maxValue) { }

		public override int Next(int minValue, int maxValue) { }

		public override double NextDouble() { }

	}

	private class RandomAdapter_NK : IRandomAdapter
	{
		private Random rand; //Field offset: 0x10

		public RandomAdapter_NK(Random rand) { }

		public override int Next() { }

		public override int Next(int maxValue) { }

		public override int Next(int minValue, int maxValue) { }

		public override double NextDouble() { }

	}

	private class RandomAdapter_Seeded : IRandomAdapter
	{
		private SeededRandom rand; //Field offset: 0x10

		public RandomAdapter_Seeded(SeededRandom rand) { }

		public override int Next() { }

		public override int Next(int maxValue) { }

		public override int Next(int minValue, int maxValue) { }

		public override double NextDouble() { }

	}

	private class RandomAdapter_Sys : IRandomAdapter
	{
		private Random rand; //Field offset: 0x10

		public RandomAdapter_Sys(Random rand) { }

		public override int Next() { }

		public override int Next(int maxValue) { }

		public override int Next(int minValue, int maxValue) { }

		public override double NextDouble() { }

	}

	internal struct RandomAdapter_Unity : IRandomAdapter
	{

		public override int Next() { }

		public override int Next(int maxValue) { }

		public override int Next(int minValue, int maxValue) { }

		public override double NextDouble() { }

	}


	[Extension]
	public static IRandomAdapter Adapter(Random rand) { }

	[Extension]
	public static IRandomAdapter Adapter(Random rand) { }

	[Extension]
	public static IRandomAdapter Adapter(BufferedRandom rand) { }

	[Extension]
	public static IRandomAdapter Adapter(SeededRandom rand) { }

	[Extension]
	public static bool Bool(Random rand) { }

	[Extension]
	public static bool Bool(Random rand) { }

	[Extension]
	public static float NextFloat(Random rnd) { }

	[Extension]
	public static float NextFloat(Random rnd) { }

	[Extension]
	public static float Range(Random rnd, float min, float max) { }

	[Extension]
	public static int Range(Random rnd, int min, int max) { }

	[Extension]
	public static float Range(Random rnd, float min, float max) { }

	[Extension]
	public static int Range(Random rnd, int min, int max) { }

}

