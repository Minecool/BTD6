namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float4x4 : IEquatable<float4x4>, IFormattable
{
	public static readonly float4x4 identity; //Field offset: 0x0
	public static readonly float4x4 zero; //Field offset: 0x40
	public float4 c0; //Field offset: 0x0
	public float4 c1; //Field offset: 0x10
	public float4 c2; //Field offset: 0x20
	public float4 c3; //Field offset: 0x30

	public float4 Item
	{
		 get { } //Length: 11
	}

	private static float4x4() { }

	public float4x4(float4 c0, float4 c1, float4 c2, float4 c3) { }

	public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) { }

	public float4x4(quaternion rotation, float3 translation) { }

	public override bool Equals(float4x4 rhs) { }

	public virtual bool Equals(object o) { }

	public float4 get_Item(int index) { }

	public virtual int GetHashCode() { }

	public static float4x4 op_Implicit(Matrix4x4 m) { }

	public static Matrix4x4 op_Implicit(float4x4 m) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

	public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) { }

}

