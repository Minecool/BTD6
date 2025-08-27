namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct int3 : IEquatable<int3>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public int x; //Field offset: 0x0
	public int y; //Field offset: 0x4
	public int z; //Field offset: 0x8

	public int3(int x, int y, int z) { }

	public override bool Equals(int3 rhs) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

