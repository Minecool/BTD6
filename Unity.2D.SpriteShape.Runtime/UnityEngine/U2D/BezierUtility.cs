namespace UnityEngine.U2D;

public static class BezierUtility
{
	private static Vector3[] s_TempPoints; //Field offset: 0x0

	private static BezierUtility() { }

	internal static float BezierLength(NativeArray<ShapeControlPoint> shapePoints, int splineDetail, ref float smallestSegment) { }

	public static Vector3 BezierPoint(Vector3 startRightTangent, Vector3 startPosition, Vector3 endPosition, Vector3 endLeftTangent, float t) { }

	internal static float GetSpritePixelWidth(Sprite sprite) { }

}

