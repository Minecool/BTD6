namespace Assets.Scripts.Simulation.SMath;

public class CubicSpline
{
	private Single[] a; //Field offset: 0x10
	private Single[] b; //Field offset: 0x18
	private Single[] xOrig; //Field offset: 0x20
	private Single[] yOrig; //Field offset: 0x28
	private int _lastIndex; //Field offset: 0x30

	public CubicSpline() { }

	public CubicSpline(Single[] x, Single[] y, float startSlope = NaN, float endSlope = NaN) { }

	private void CheckAlreadyFitted() { }

	public static Single[] Compute(Single[] x, Single[] y, Single[] xs, float startSlope = NaN, float endSlope = NaN) { }

	public Single[] Eval(Single[] x) { }

	public Single[] EvalSlope(Single[] x) { }

	private float EvalSpline(float x, int j) { }

	public void Fit(Single[] x, Single[] y, float startSlope = NaN, float endSlope = NaN) { }

	public Single[] FitAndEval(Single[] x, Single[] y, Single[] xs, float startSlope = NaN, float endSlope = NaN) { }

	public static void FitParametric(Single[] x, Single[] y, int nOutputPoints, out Single[] xs, out Single[] ys, float firstDx = NaN, float firstDy = NaN, float lastDx = NaN, float lastDy = NaN) { }

	private int GetNextXIndex(float x) { }

	private static void NormalizeVector(ref float dx, ref float dy) { }

}

