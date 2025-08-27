namespace Poly2Tri;

public class TriangulationPoint : Point2D
{
	public static readonly double kVertexCodeDefaultPrecision; //Field offset: 0x0
	protected uint mVertexCode; //Field offset: 0x20
	[CompilerGenerated]
	private List<DTSweepConstraint> <Edges>k__BackingField; //Field offset: 0x28

	public private List<DTSweepConstraint> Edges
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool HasEdges
	{
		 get { } //Length: 9
	}

	public uint VertexCode
	{
		 get { } //Length: 4
	}

	public virtual double X
	{
		 get { } //Length: 6
		 set { } //Length: 144
	}

	public virtual double Y
	{
		 get { } //Length: 6
		 set { } //Length: 144
	}

	private static TriangulationPoint() { }

	public TriangulationPoint(double x, double y) { }

	public TriangulationPoint(double x, double y, double precision) { }

	public void AddEdge(DTSweepConstraint e) { }

	public static uint CreateVertexCode(double x, double y, double precision) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public List<DTSweepConstraint> get_Edges() { }

	public bool get_HasEdges() { }

	public uint get_VertexCode() { }

	public virtual double get_X() { }

	public virtual double get_Y() { }

	public bool GetEdge(TriangulationPoint p, out DTSweepConstraint edge) { }

	public virtual int GetHashCode() { }

	public bool HasEdge(TriangulationPoint p) { }

	public virtual void Set(double x, double y) { }

	[CompilerGenerated]
	private void set_Edges(List<DTSweepConstraint> value) { }

	public virtual void set_X(double value) { }

	public virtual void set_Y(double value) { }

	public static Point2D ToPoint2D(TriangulationPoint p) { }

	public virtual string ToString() { }

}

