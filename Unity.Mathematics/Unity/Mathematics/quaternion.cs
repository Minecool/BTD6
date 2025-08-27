namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
public struct quaternion : IEquatable<quaternion>, IFormattable
{
	public static readonly quaternion identity; //Field offset: 0x0
	public float4 value; //Field offset: 0x0

	private static quaternion() { }

	public quaternion(float x, float y, float z, float w) { }

	public quaternion(float4 value) { }

	public override bool Equals(quaternion x) { }

	public virtual bool Equals(object x) { }

	public static quaternion EulerXYZ(float3 xyz) { }

	public static quaternion EulerXYZ(float x, float y, float z) { }

	public virtual int GetHashCode() { }

	public static quaternion op_Implicit(Quaternion q) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

