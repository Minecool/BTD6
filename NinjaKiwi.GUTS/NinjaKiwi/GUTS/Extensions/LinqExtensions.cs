namespace NinjaKiwi.GUTS.Extensions;

[Extension]
public static class LinqExtensions
{

	[Extension]
	public static TSource CustomMaxBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Extension]
	public static TSource CustomMinBy(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

}

