namespace Geom;

[Extension]
public static class GeomExtensions
{

	[Extension]
	public static Vector2 Rotate(Vector2 v, float degrees) { }

	[Extension]
	public static Vector2 RotateRadians(Vector2 v, float radians) { }

	[Extension]
	public static IntPoint ToGroundIntPoint(Vector3 p) { }

	[Extension]
	public static Vector2 ToGroundVector2(Vector3 p) { }

	[Extension]
	public static Vector3 ToWorldVector3(IntPoint p) { }

	[Extension]
	public static Vector3 ToWorldVector3(Vector2 p) { }

}

