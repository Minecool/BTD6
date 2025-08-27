namespace Poly2Tri;

public class TriangulationPointEnumerator : IEnumerator<TriangulationPoint>, IEnumerator, IDisposable
{
	protected IList<Point2D> mPoints; //Field offset: 0x10
	protected int position; //Field offset: 0x18

	public override TriangulationPoint Current
	{
		 get { } //Length: 248
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 248
	}

	public TriangulationPointEnumerator(IList<Point2D> points) { }

	public override TriangulationPoint get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

	private override void System.IDisposable.Dispose() { }

}

