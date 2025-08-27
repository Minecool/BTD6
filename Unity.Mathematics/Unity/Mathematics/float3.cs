namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float3 : IEquatable<float3>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public static readonly float3 zero; //Field offset: 0x0
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 xxxx
	{
		 get { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float2 xy
	{
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float3 xyz
	{
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float2 xz
	{
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 yxxy
	{
		 get { } //Length: 32
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 yyyy
	{
		 get { } //Length: 16
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float2 yz
	{
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float3 yzx
	{
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 zzyz
	{
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 zzzz
	{
		 get { } //Length: 16
	}

	public float3(float x, float y, float z) { }

	public float3(float x, float2 yz) { }

	public float3(float2 xy, float z) { }

	public float3(float v) { }

	public float3(int v) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(float3 rhs) { }

	public float4 get_xxxx() { }

	public float2 get_xy() { }

	public float3 get_xyz() { }

	public float2 get_xz() { }

	public float4 get_yxxy() { }

	public float4 get_yyyy() { }

	public float2 get_yz() { }

	public float3 get_yzx() { }

	public float4 get_zzyz() { }

	public float4 get_zzzz() { }

	public virtual int GetHashCode() { }

	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	public static float3 op_Division(float3 lhs, float3 rhs) { }

	public static float3 op_Division(float3 lhs, float rhs) { }

	public static float3 op_Implicit(float v) { }

	public static float3 op_Implicit(int v) { }

	public static float3 op_Implicit(Vector3 v) { }

	public static Vector3 op_Implicit(float3 v) { }

	public static float3 op_Multiply(float lhs, float3 rhs) { }

	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	public static float3 op_Multiply(float3 lhs, float rhs) { }

	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	public static float3 op_UnaryNegation(float3 val) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

