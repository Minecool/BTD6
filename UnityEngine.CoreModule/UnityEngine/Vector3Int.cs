namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[UsedByNativeCode]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable
{
	private static readonly Vector3Int s_Zero; //Field offset: 0x0
	private static readonly Vector3Int s_One; //Field offset: 0xC
	private static readonly Vector3Int s_Up; //Field offset: 0x18
	private static readonly Vector3Int s_Down; //Field offset: 0x24
	private static readonly Vector3Int s_Left; //Field offset: 0x30
	private static readonly Vector3Int s_Right; //Field offset: 0x3C
	private static readonly Vector3Int s_Forward; //Field offset: 0x48
	private static readonly Vector3Int s_Back; //Field offset: 0x54
	private int m_X; //Field offset: 0x0
	private int m_Y; //Field offset: 0x4
	private int m_Z; //Field offset: 0x8

	public static Vector3Int one
	{
		 get { } //Length: 75
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

	public int z
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public static Vector3Int zero
	{
		 get { } //Length: 74
	}

	private static Vector3Int() { }

	public Vector3Int(int x, int y, int z) { }

	public override bool Equals(Vector3Int other) { }

	public virtual bool Equals(object other) { }

	public static Vector3Int get_one() { }

	public int get_x() { }

	public int get_y() { }

	public int get_z() { }

	public static Vector3Int get_zero() { }

	public virtual int GetHashCode() { }

	public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs) { }

	public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs) { }

	public static Vector3Int op_Addition(Vector3Int a, Vector3Int b) { }

	public static Vector3Int op_Division(Vector3Int a, int b) { }

	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	public static Vector3 op_Implicit(Vector3Int v) { }

	public static bool op_Inequality(Vector3Int lhs, Vector3Int rhs) { }

	public static Vector3Int op_Multiply(Vector3Int a, int b) { }

	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	public void set_x(int value) { }

	public void set_y(int value) { }

	public void set_z(int value) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

