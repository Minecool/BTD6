namespace NinjaKiwi.Common;

[AttributeUsage(AttributeTargets::Field (256))]
public class EnumAsCommaDelimitedString : PropertyAttribute
{
	[CompilerGenerated]
	private sealed class <>c__3
	{
		public static readonly <>c__3<T> <>9; //Field offset: 0x0
		public static Func<Int32, String, Int32> <>9__3_0; //Field offset: 0x0

		private static <>c__3`1() { }

		public <>c__3`1() { }

		internal int <ToMask>b__3_0(int result, string type) { }

	}

	[CompilerGenerated]
	private sealed class <>c__4
	{
		public static readonly <>c__4<T> <>9; //Field offset: 0x0
		public static Func<Int64, String, Int64> <>9__4_0; //Field offset: 0x0

		private static <>c__4`1() { }

		public <>c__4`1() { }

		internal long <ToLongMask>b__4_0(long result, string type) { }

	}

	[CompilerGenerated]
	private sealed class <>c__5
	{
		public static readonly <>c__5<T> <>9; //Field offset: 0x0
		public static Func<String, T> <>9__5_0; //Field offset: 0x0

		private static <>c__5`1() { }

		public <>c__5`1() { }

		internal T <ToArray>b__5_0(string s) { }

	}

	public Type enumType; //Field offset: 0x18
	public bool representEverythingAsEmptyString; //Field offset: 0x20

	public EnumAsCommaDelimitedString(Type enumType, bool representEverythingAsEmptyString) { }

	public static T[] ToArray(string flags) { }

	public static long ToLongMask(string flags) { }

	public static int ToMask(string flags) { }

}

