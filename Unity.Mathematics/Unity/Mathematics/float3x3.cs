namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float3x3 : IEquatable<float3x3>, IFormattable
{
	public static readonly float3x3 identity; //Field offset: 0x0
	public float3 c0; //Field offset: 0x0
	public float3 c1; //Field offset: 0xC
	public float3 c2; //Field offset: 0x18

	private static float3x3() { }

	public float3x3(float3 c0, float3 c1, float3 c2) { }

	public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	public float3x3(float4x4 f4x4) { }

	public float3x3(quaternion q) { }

	public override bool Equals(float3x3 rhs) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public static float3x3 op_Explicit(float4x4 f4x4) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

