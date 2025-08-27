namespace NinjaKiwi.Common;

public class FunctionalComparer : IComparer<T>
{
	private Func<T, T, Int32> comparer; //Field offset: 0x0

	public FunctionalComparer`1(Func<T, T, Int32> comparer) { }

	public override int Compare(T x, T y) { }

}

