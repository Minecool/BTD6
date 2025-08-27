namespace Geom;

public struct IntPoint : IEquatable<IntPoint>
{
	public static readonly IntPoint zero; //Field offset: 0x0
	public int x; //Field offset: 0x0
	public int y; //Field offset: 0x4

	[JsonIgnore]
	public int SqrLength
	{
		 get { } //Length: 14
	}

	private static IntPoint() { }

	public IntPoint(Vector2 point) { }

	public IntPoint(IntPoint point) { }

	public IntPoint(int x, int y) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(IntPoint k) { }

	public int get_SqrLength() { }

	public virtual int GetHashCode() { }

	public static IntPoint op_Addition(IntPoint p1, IntPoint p2) { }

	public static IntPoint op_Division(IntPoint p1, int scale) { }

	public static bool op_Equality(IntPoint a, IntPoint b) { }

	public static bool op_Inequality(IntPoint a, IntPoint b) { }

	public static IntPoint op_Multiply(IntPoint p1, int scale) { }

	public static IntPoint op_Subtraction(IntPoint p1, IntPoint p2) { }

	public static IntPoint op_UnaryNegation(IntPoint p) { }

	public void Set(int x, int y) { }

	public virtual string ToString() { }

	public Vector2 ToVector2() { }

}

