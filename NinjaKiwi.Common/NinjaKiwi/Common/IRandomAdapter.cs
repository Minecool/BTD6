namespace NinjaKiwi.Common;

public interface IRandomAdapter
{

	public int Next() { }

	public int Next(int maxValue) { }

	public int Next(int minValue, int maxValue) { }

	public double NextDouble() { }

}

