namespace Poly2Tri;

public class PolygonOperationContext
{
	public PolyOperation mOperations; //Field offset: 0x10
	public Point2DList mOriginalPolygon1; //Field offset: 0x18
	public Point2DList mOriginalPolygon2; //Field offset: 0x20
	public Point2DList mPoly1; //Field offset: 0x28
	public Point2DList mPoly2; //Field offset: 0x30
	public List<EdgeIntersectInfo> mIntersections; //Field offset: 0x38
	public int mStartingIndex; //Field offset: 0x40
	public PolyUnionError mError; //Field offset: 0x44
	public List<Int32> mPoly1VectorAngles; //Field offset: 0x48
	public List<Int32> mPoly2VectorAngles; //Field offset: 0x50
	public Dictionary<UInt32, Point2DList> mOutput; //Field offset: 0x58

	public Point2DList Intersect
	{
		 get { } //Length: 190
	}

	public Point2DList Subtract
	{
		 get { } //Length: 190
	}

	public Point2DList Union
	{
		 get { } //Length: 190
	}

	public PolygonOperationContext() { }

	public void Clear() { }

	public Point2DList get_Intersect() { }

	public Point2DList get_Subtract() { }

	public Point2DList get_Union() { }

	public bool Init(PolyOperation operations, Point2DList polygon1, Point2DList polygon2) { }

	public bool PointInPolygonAngle(Point2D point, Point2DList polygon) { }

	public double VectorAngle(Point2D p1, Point2D p2) { }

	private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo>& intersections) { }

}

