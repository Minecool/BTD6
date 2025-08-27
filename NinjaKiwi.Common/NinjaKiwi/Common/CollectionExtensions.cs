namespace NinjaKiwi.Common;

[Extension]
public static class CollectionExtensions
{

	[Extension]
	public static bool AtIndex(List<T> l, int index, out T value) { }

	[Extension]
	public static void EnsureCapacity(List<T> l, int c) { }

	[Extension]
	public static bool RemoveUnordered(IList<T> l, T item) { }

	[Extension]
	public static void StableSort(List<T> values, Comparison<T> comparison) { }

}

