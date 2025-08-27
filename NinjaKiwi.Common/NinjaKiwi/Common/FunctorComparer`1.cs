namespace NinjaKiwi.Common;

public class FunctorComparer : IComparer<T>
{
	private Comparison<T> comparison; //Field offset: 0x0

	public FunctorComparer`1(Comparison<T> comparison) { }

	public override int Compare(T x, T y) { }

}

