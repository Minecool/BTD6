namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct float2x2 : IEquatable<float2x2>, IFormattable
{
	public static readonly float2x2 identity; //Field offset: 0x0
	public float2 c0; //Field offset: 0x0
	public float2 c1; //Field offset: 0x8

	private static float2x2() { }

	public float2x2(float2 c0, float2 c1) { }

	public float2x2(float m00, float m01, float m10, float m11) { }

	public override bool Equals(float2x2 rhs) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

