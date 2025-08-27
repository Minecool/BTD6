namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint3 : IEquatable<uint3>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public uint x; //Field offset: 0x0
	public uint y; //Field offset: 0x4
	public uint z; //Field offset: 0x8

	public uint3(uint x, uint y, uint z) { }

	public override bool Equals(uint3 rhs) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public static uint3 op_Addition(uint3 lhs, uint3 rhs) { }

	public static uint3 op_ExclusiveOr(uint3 lhs, uint3 rhs) { }

	public static uint3 op_Multiply(uint3 lhs, uint3 rhs) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

