namespace Poly2Tri;

public class PolygonPoint : TriangulationPoint
{
	[CompilerGenerated]
	private PolygonPoint <Next>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private PolygonPoint <Previous>k__BackingField; //Field offset: 0x38

	public PolygonPoint Next
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public PolygonPoint Previous
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public PolygonPoint(double x, double y) { }

	[CompilerGenerated]
	public PolygonPoint get_Next() { }

	[CompilerGenerated]
	public PolygonPoint get_Previous() { }

	[CompilerGenerated]
	public void set_Next(PolygonPoint value) { }

	[CompilerGenerated]
	public void set_Previous(PolygonPoint value) { }

	public static Point2D ToBasePoint(PolygonPoint p) { }

	public static TriangulationPoint ToTriangulationPoint(PolygonPoint p) { }

}

