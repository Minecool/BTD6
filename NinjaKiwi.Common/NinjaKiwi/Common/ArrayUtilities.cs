namespace NinjaKiwi.Common;

[Extension]
public static class ArrayUtilities
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Func<T, T, Boolean> comparer; //Field offset: 0x0
		public T element; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		internal bool <RemoveAll>b__0(T a1element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Func<T, T, Boolean> comparer; //Field offset: 0x0

		public <>c__DisplayClass7_0`1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public T a2element; //Field offset: 0x0
		public <>c__DisplayClass7_0<T> CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass7_1`1() { }

		internal bool <Union>b__0(T a1element) { }

	}

	internal sealed class StabilizingComparer : IComparer<KeyValuePair`2<Int32, T>>
	{
		private readonly Comparison<T> _comparison; //Field offset: 0x0

		public StabilizingComparer`1(Comparison<T> comparison) { }

		public override int Compare(KeyValuePair<Int32, T> x, KeyValuePair<Int32, T> y) { }

	}


	[Extension]
	public static bool AtIndex(T[] l, int index, out T value) { }

	public static void Concat(ref T[] array1, T[] array2) { }

	public static void CopyToArray(ref T[] arr, ICollection<T> c) { }

	public static void Insert(ref T[] array, int index, T element) { }

	public static void Insert(ref T[] array, T element) { }

	[Extension]
	public static void InsertionSort(T[] values, int count, IComparer<T> comparer) { }

	public static bool Remove(ref T[] array, T element) { }

	public static bool RemoveAll(ref T[] array, T element, Func<T, T, Boolean> comparer) { }

	public static bool RemoveAll(ref T[] array, Predicate<T> match) { }

	public static bool RemoveAt(ref T[] array, int index) { }

	[Extension]
	public static void StableSort(T[] values, Comparison<T> comparison) { }

	public static void Union(ref T[] array1, T[] array2, Func<T, T, Boolean> comparer) { }

}

