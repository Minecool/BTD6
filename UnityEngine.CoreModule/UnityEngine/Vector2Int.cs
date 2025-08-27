namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeType("Runtime/Math/Vector2Int.h")]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
{
	private static readonly Vector2Int s_Zero; //Field offset: 0x0
	private static readonly Vector2Int s_One; //Field offset: 0x8
	private static readonly Vector2Int s_Up; //Field offset: 0x10
	private static readonly Vector2Int s_Down; //Field offset: 0x18
	private static readonly Vector2Int s_Left; //Field offset: 0x20
	private static readonly Vector2Int s_Right; //Field offset: 0x28
	private int m_X; //Field offset: 0x0
	private int m_Y; //Field offset: 0x4

	public float magnitude
	{
		 get { } //Length: 46
	}

	public static Vector2Int one
	{
		 get { } //Length: 55
	}

	public int x
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public int y
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public static Vector2Int zero
	{
		 get { } //Length: 54
	}

	private static Vector2Int() { }

	public Vector2Int(int x, int y) { }

	public override bool Equals(Vector2Int other) { }

	public virtual bool Equals(object other) { }

	public static Vector2Int FloorToInt(Vector2 v) { }

	public float get_magnitude() { }

	public static Vector2Int get_one() { }

	public int get_x() { }

	public int get_y() { }

	public static Vector2Int get_zero() { }

	public virtual int GetHashCode() { }

	public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs) { }

	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	public static Vector2 op_Implicit(Vector2Int v) { }

	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	public void set_x(int value) { }

	public void set_y(int value) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

