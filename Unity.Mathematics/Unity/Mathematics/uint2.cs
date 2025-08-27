namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint2 : IEquatable<uint2>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public uint x; //Field offset: 0x0
	public uint y; //Field offset: 0x4

	public uint2(uint x, uint y) { }

	public override bool Equals(uint2 rhs) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public static uint2 op_Addition(uint2 lhs, uint2 rhs) { }

	public static uint2 op_Multiply(uint2 lhs, uint2 rhs) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

