namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct int2 : IEquatable<int2>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public static readonly int2 zero; //Field offset: 0x0
	public int x; //Field offset: 0x0
	public int y; //Field offset: 0x4

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public int4 xyxy
	{
		 get { } //Length: 25
	}

	public int2(int x, int y) { }

	public int2(int v) { }

	public override bool Equals(int2 rhs) { }

	public virtual bool Equals(object o) { }

	public int4 get_xyxy() { }

	public virtual int GetHashCode() { }

	public static int2 op_Addition(int2 lhs, int2 rhs) { }

	public static int2 op_Addition(int2 lhs, int rhs) { }

	public static int2 op_BitwiseOr(int2 lhs, int2 rhs) { }

	public static int2 op_Division(int2 lhs, int rhs) { }

	public static int2 op_Implicit(int v) { }

	public static bool2 op_LessThan(int2 lhs, int2 rhs) { }

	public static int2 op_RightShift(int2 x, int n) { }

	public static int2 op_Subtraction(int2 lhs, int rhs) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

