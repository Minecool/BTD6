namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float2 : IEquatable<float2>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public static readonly float2 zero; //Field offset: 0x0
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float2 yx
	{
		 get { } //Length: 18
	}

	public float2(float x, float y) { }

	public float2(float v) { }

	public float2(int v) { }

	public float2(int2 v) { }

	public float2(uint2 v) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(float2 rhs) { }

	public float2 get_yx() { }

	public virtual int GetHashCode() { }

	public static float2 op_Addition(float2 lhs, float rhs) { }

	public static float2 op_Addition(float2 lhs, float2 rhs) { }

	public static float2 op_Addition(float lhs, float2 rhs) { }

	public static float2 op_Division(float2 lhs, float2 rhs) { }

	public static float2 op_Division(float2 lhs, float rhs) { }

	public static float2 op_Division(float lhs, float2 rhs) { }

	public static Vector2 op_Implicit(float2 v) { }

	public static float2 op_Implicit(uint2 v) { }

	public static float2 op_Implicit(int2 v) { }

	public static float2 op_Implicit(int v) { }

	public static float2 op_Implicit(Vector2 v) { }

	public static float2 op_Multiply(float2 lhs, float rhs) { }

	public static float2 op_Multiply(float2 lhs, float2 rhs) { }

	public static float2 op_Multiply(float lhs, float2 rhs) { }

	public static float2 op_Subtraction(float2 lhs, float2 rhs) { }

	public static float2 op_UnaryNegation(float2 val) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

