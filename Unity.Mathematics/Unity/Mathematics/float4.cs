namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float4 : IEquatable<float4>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public static readonly float4 zero; //Field offset: 0x0
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4
	public float z; //Field offset: 0x8
	public float w; //Field offset: 0xC

	public float Item
	{
		 get { } //Length: 9
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 wwww
	{
		 get { } //Length: 16
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 wwwx
	{
		 get { } //Length: 28
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float3 wzy
	{
		 get { } //Length: 21
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
	public float4 xyzx
	{
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float3 yxw
	{
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 yzxy
	{
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 yzxz
	{
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float2 zw
	{
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float3 zwx
	{
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 zxyy
	{
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public float4 zxyz
	{
		 get { } //Length: 29
	}

	public float4(float x, float y, float z, float w) { }

	public float4(float2 xy, float z, float w) { }

	public float4(float2 xy, float2 zw) { }

	public float4(float3 xyz, float w) { }

	public float4(int4 v) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(float4 rhs) { }

	public float get_Item(int index) { }

	public float4 get_wwww() { }

	public float4 get_wwwx() { }

	public float3 get_wzy() { }

	public float2 get_xy() { }

	public float3 get_xyz() { }

	public float4 get_xyzx() { }

	public float3 get_yxw() { }

	public float4 get_yzxy() { }

	public float4 get_yzxz() { }

	public float2 get_zw() { }

	public float3 get_zwx() { }

	public float4 get_zxyy() { }

	public float4 get_zxyz() { }

	public virtual int GetHashCode() { }

	public static float4 op_Addition(float4 lhs, float4 rhs) { }

	public static float4 op_Division(float4 lhs, float rhs) { }

	public static float4 op_Implicit(int4 v) { }

	public static float4 op_Implicit(Vector4 v) { }

	public static Vector4 op_Implicit(float4 v) { }

	public static bool4 op_LessThan(float4 lhs, float4 rhs) { }

	public static float4 op_Multiply(float4 lhs, float rhs) { }

	public static float4 op_Multiply(float4 lhs, float4 rhs) { }

	public static float4 op_Subtraction(float4 lhs, float4 rhs) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

