namespace Geom;

public class Point
{
	public float x; //Field offset: 0x10
	public float y; //Field offset: 0x14

	public Point() { }

	public Point(Point s) { }

	public Point(float x, float y) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(Point k) { }

	public virtual int GetHashCode() { }

	public static Point op_Addition(Point a, Point b) { }

	public static Point op_Addition(Point a, Vector2 b) { }

	public static bool op_Equality(Point a, Point b) { }

	public static Vector2 op_Implicit(Point point) { }

	public static Point op_Implicit(Vector2 vector) { }

	public static Vector3 op_Implicit(Point point) { }

	public static Point op_Implicit(Vector3 vector) { }

	public static bool op_Inequality(Point a, Point b) { }

	public virtual string ToString() { }

	public Vector3 ToWorldVector3() { }

}

