namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct double2 : IEquatable<double2>, IFormattable
{
	public sealed class DebuggerProxy
	{

	}

	public static readonly double2 zero; //Field offset: 0x0
	public double x; //Field offset: 0x0
	public double y; //Field offset: 0x8

	public double2(double x, double y) { }

	public double2(float2 v) { }

	public override bool Equals(double2 rhs) { }

	public virtual bool Equals(object o) { }

	public virtual int GetHashCode() { }

	public static double2 op_Implicit(float2 v) { }

	public static double2 op_Subtraction(double2 lhs, double2 rhs) { }

	public virtual string ToString() { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

