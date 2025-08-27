namespace Poly2Tri;

public class Edge
{
	protected Point2D mP; //Field offset: 0x10
	protected Point2D mQ; //Field offset: 0x18

	public Point2D EdgeEnd
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public Point2D EdgeStart
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public Edge() { }

	public Edge(Point2D edgeStart, Point2D edgeEnd) { }

	public Point2D get_EdgeEnd() { }

	public Point2D get_EdgeStart() { }

	public void set_EdgeEnd(Point2D value) { }

	public void set_EdgeStart(Point2D value) { }

}

