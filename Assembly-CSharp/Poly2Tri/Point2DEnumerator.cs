namespace Poly2Tri;

public class Point2DEnumerator : IEnumerator<Point2D>, IEnumerator, IDisposable
{
	protected IList<Point2D> mPoints; //Field offset: 0x10
	protected int position; //Field offset: 0x18

	public override Point2D Current
	{
		 get { } //Length: 145
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 145
	}

	public Point2DEnumerator(IList<Point2D> points) { }

	public override Point2D get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override void System.IDisposable.Dispose() { }

}

