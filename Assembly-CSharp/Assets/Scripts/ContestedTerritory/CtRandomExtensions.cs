namespace Assets.Scripts.ContestedTerritory;

[Extension]
public static class CtRandomExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public IReadOnlyDictionary<T2, Single> selectionChances; //Field offset: 0x0
		public Func<T, T2> keySelector; //Field offset: 0x0

		public <>c__DisplayClass4_0`2() { }

		internal double <_GetRandomItem>b__1(T item) { }

		internal float <_GetRandomItem>g__GetItemChance|0(T item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IReadOnlyDictionary<T, Single> selectionChances; //Field offset: 0x0

		public <>c__DisplayClass7_0`1() { }

		internal double <_GetRandomItem>b__1(T item) { }

		internal float <_GetRandomItem>g__GetItemChance|0(T item) { }

	}


	[Extension]
	private static T _GetRandomItem(Random random, IEnumerable<T> items, IReadOnlyDictionary<T2, Single> selectionChances, Func<T, T2> keySelector) { }

	[Extension]
	private static T _GetRandomItem(Random random, IEnumerable<T> items, IReadOnlyDictionary<T, Single> selectionChances) { }

	[Extension]
	public static int GetRandomFloatIndex(Random random, Single[] floatList) { }

	[Extension]
	public static T GetRandomItem(Random random, IEnumerable<T> items, Dictionary<T2, Single> selectionChances, Func<T, T2> keySelector) { }

	[Extension]
	public static T GetRandomItem(Random random, IEnumerable<T> items, IReadOnlyDictionary<T2, Single> selectionChances, Func<T, T2> keySelector) { }

	[Extension]
	public static T GetRandomItem(Random random, Dictionary<T, Single> itemChances) { }

	[Extension]
	public static T GetRandomItem(Random random, IEnumerable<T> items, IReadOnlyDictionary<T, Single> selectionChances) { }

	[Extension]
	public static int GetRandomRangeValue(Random random, CTGameSettingRangeLimit range) { }

	[Extension]
	public static T GetRandomValue(Random random, IEnumerable<T> values, Func<T, Double> probabilitySelector, double totalProbability) { }

}

