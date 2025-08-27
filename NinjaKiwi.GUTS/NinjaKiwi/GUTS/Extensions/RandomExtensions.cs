namespace NinjaKiwi.GUTS.Extensions;

[Extension]
public static class RandomExtensions
{
	[CompilerGenerated]
	private sealed class <>c__1
	{
		public static readonly <>c__1<T> <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<T, Single>, Boolean> <>9__1_0; //Field offset: 0x0
		public static Func<KeyValuePair`2<T, Single>, Single> <>9__1_1; //Field offset: 0x0

		private static <>c__1`1() { }

		public <>c__1`1() { }

		internal bool <GetRandomItem>b__1_0(KeyValuePair<T, Single> kvp) { }

		internal float <GetRandomItem>b__1_1(KeyValuePair<T, Single> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__3
	{
		public static readonly <>c__3<T> <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<T, Single>, Boolean> <>9__3_0; //Field offset: 0x0
		public static Func<KeyValuePair`2<T, Single>, Boolean> <>9__3_1; //Field offset: 0x0
		public static Func<KeyValuePair`2<T, Single>, Single> <>9__3_2; //Field offset: 0x0

		private static <>c__3`1() { }

		public <>c__3`1() { }

		internal bool <GetRandomItem>b__3_0(KeyValuePair<T, Single> x) { }

		internal bool <GetRandomItem>b__3_1(KeyValuePair<T, Single> kvp) { }

		internal float <GetRandomItem>b__3_2(KeyValuePair<T, Single> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Dictionary<T, Single> selectionChances; //Field offset: 0x0

		public <>c__DisplayClass0_0`1() { }

		internal KeyValuePair<T, Single> <GetRandomItem>b__0(T item) { }

	}


	[Extension]
	public static T GetRandomItem(Random random, IEnumerable<T> items, Dictionary<T, Single> selectionChances) { }

	[Extension]
	public static T GetRandomItem(Random random, IEnumerable<KeyValuePair`2<T, Single>> itemChances) { }

	[Extension]
	public static T GetRandomItem(Random random, IList<T> items) { }

	[Extension]
	internal static T GetRandomItem(Random random, IEnumerable<KeyValuePair`2<T, Single>> itemChances, double totalProbability) { }

}

