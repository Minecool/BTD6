namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct uint4 : IEquatable<uint4>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public static readonly uint4 zero; //Field offset: 0x0
	public uint x; //Field offset: 0x0
	public uint y; //Field offset: 0x4
	public uint z; //Field offset: 0x8
	public uint w; //Field offset: 0xC

	public int Item
	{
		 set { } //Length: 8
	}

	public uint4(uint x, uint y, uint z, uint w) { }

	public uint4(uint v) { }

	public override bool Equals(uint4 rhs) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public static uint4 op_Addition(uint4 lhs, uint4 rhs) { }

	public static uint4 op_BitwiseAnd(uint4 lhs, uint rhs) { }

	public static bool4 op_GreaterThan(uint4 lhs, uint rhs) { }

	public static uint4 op_Implicit(uint v) { }

	public static uint4 op_Multiply(uint4 lhs, uint4 rhs) { }

	public void set_Item(int index, uint value) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

