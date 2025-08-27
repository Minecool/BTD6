namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct int4 : IEquatable<int4>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public static readonly int4 zero; //Field offset: 0x0
	public int x; //Field offset: 0x0
	public int y; //Field offset: 0x4
	public int z; //Field offset: 0x8
	public int w; //Field offset: 0xC

	public int Item
	{
		 get { } //Length: 7
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public int2 xw
	{
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public int2 xy
	{
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public int2 zw
	{
		 get { } //Length: 20
	}

	public int4(int x, int y, int z, int w) { }

	public int4(float4 v) { }

	public override bool Equals(int4 rhs) { }

	public virtual bool Equals(object o) { }

	public int get_Item(int index) { }

	public int2 get_xw() { }

	public int2 get_xy() { }

	public int2 get_zw() { }

	public virtual int GetHashCode() { }

	public static int4 op_Explicit(float4 v) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

