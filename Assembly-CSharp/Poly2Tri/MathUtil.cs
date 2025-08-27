namespace Poly2Tri;

public class MathUtil
{
	public static double EPSILON; //Field offset: 0x0

	private static MathUtil() { }

	public MathUtil() { }

	public static bool AreValuesEqual(double val1, double val2) { }

	public static bool AreValuesEqual(double val1, double val2, double tolerance) { }

	public static double Clamp(double a, double low, double high) { }

	public static bool IsValueBetween(double val, double min, double max, double tolerance) { }

	public static uint Jenkins32Hash(Byte[] data, uint nInitialValue) { }

	public static double RoundWithPrecision(double f, double precision) { }

	public static void Swap(ref T a, ref T b) { }

}

