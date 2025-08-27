namespace Poly2Tri;

public class ConstrainedPointSet : PointSet
{
	protected Dictionary<UInt32, TriangulationConstraint> mConstraintMap; //Field offset: 0x58
	protected List<Contour> mHoles; //Field offset: 0x60

	public virtual TriangulationMode TriangulationMode
	{
		 get { } //Length: 6
	}

	public ConstrainedPointSet(List<TriangulationPoint> bounds) { }

	public ConstrainedPointSet(List<TriangulationPoint> bounds, List<TriangulationConstraint> constraints) { }

	public ConstrainedPointSet(List<TriangulationPoint> bounds, Int32[] indices) { }

	public virtual void Add(Point2D p) { }

	public virtual void Add(TriangulationPoint p) { }

	protected void AddBoundaryConstraints() { }

	public bool AddConstraint(TriangulationConstraint tc) { }

	public bool AddConstraints(List<TriangulationConstraint> constraints) { }

	public bool AddHole(List<TriangulationPoint> points, string name) { }

	public virtual bool AddRange(List<TriangulationPoint> points) { }

	public virtual void AddTriangle(DelaunayTriangle t) { }

	public virtual TriangulationMode get_TriangulationMode() { }

	public int GetActualHoles(out List<Contour>& holes) { }

	public Enumerator<UInt32, TriangulationConstraint> GetConstraintEnumerator() { }

	public Contour GetHole(int idx) { }

	public int GetNumConstraints() { }

	public int GetNumHoles() { }

	public virtual bool Initialize() { }

	protected void InitializeHoles() { }

	public virtual void Prepare(TriangulationContext tcx) { }

	public bool TryGetConstraint(uint constraintCode, out TriangulationConstraint tc) { }

}

