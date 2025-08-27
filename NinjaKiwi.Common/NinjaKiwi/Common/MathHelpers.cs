namespace NinjaKiwi.Common;

[Extension]
public static class MathHelpers
{
	private enum ELineSide
	{
		Left = 0,
		On = 1,
		Right = 2,
	}

	public const float TauF32 = 6.2831855; //Field offset: 0x0

	public static bool Approximately(double a, double b, double tolerance = 1E-09) { }

	public static Vector3 CalculateBezierPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t) { }

	[Extension]
	public static T Clamp(T val, T min, T max) { }

	public static Rect Clamp(Rect a, Rect r) { }

	[Extension]
	public static Vector2 ClampMagnitudeAndRemapOnOne(Vector2 v, float maxMagnitude, out float magnitude) { }

	public static float Cross(Vector2 a, Vector2 b) { }

	public static Vector3 CubicHermite(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t) { }

	private static ELineSide GetSideOfLine(in Vector3 lineStart, in Vector3 lineEnd, in Vector3 point) { }

	public static bool IsPointInTriangle2D(in Vector3 point, in Vector3 v1, in Vector3 v2, in Vector3 v3) { }

	public static bool IsPointOnMesh2D(in Vector3 point, in Vector3[] vertices) { }

	public static bool LineLineIntersect(Vector2 a, Vector2 b, Vector2 c, Vector2 d, ref Vector2 intersect_p) { }

	public static bool LineRectIntersect(Vector2 a, Vector2 b, Rect r, ref Vector2 intersection) { }

	public static Vector3[] MakeBezierPoints(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, int division) { }

	public static float PerpDotProduct(Vector2 a, Vector2 b) { }

	public static float Reciprocal(float value) { }

	public static float RemapRange(float value, float inMin, float inMax, float outMin, float outMax) { }

	public static float RemapRange01(float value, float inMin, float inMax) { }

	public static float RemapRangeUnclamped(float value, float inMin, float inMax, float outMin, float outMax) { }

	[Extension]
	public static Vector2 Rotate(Vector2 v, float degrees) { }

	public static float SafeReciprocalOrZero(float numer, float denom) { }

	[Extension]
	public static Rect ScaleAroundPivot(Rect r, Vector2 pivot, Vector2 scale) { }

	[Extension]
	public static Rect ScaleAroundPivot(Rect r, Vector2 pivot, float scale) { }

	public static float SignedAngleRadians(Vector2 a, Vector2 b) { }

	[Extension]
	public static int Wrap(int val, int move, int max) { }

}

