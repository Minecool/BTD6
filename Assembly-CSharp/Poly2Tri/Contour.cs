namespace Poly2Tri;

[DefaultMember("Item")]
public class Contour : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
{
	private List<Contour> mHoles; //Field offset: 0x30
	private ITriangulatable mParent; //Field offset: 0x38
	private string mName; //Field offset: 0x40

	public override Rect2D Bounds
	{
		 get { } //Length: 5
	}

	public override bool DisplayFlipX
	{
		 get { } //Length: 73
		 set { } //Length: 3
	}

	public override bool DisplayFlipY
	{
		 get { } //Length: 73
		 set { } //Length: 3
	}

	public override float DisplayRotate
	{
		 get { } //Length: 189
		 set { } //Length: 3
	}

	public override string FileName
	{
		 get { } //Length: 189
		 set { } //Length: 3
	}

	public override TriangulationPoint Item
	{
		 get { } //Length: 183
		 set { } //Length: 97
	}

	public override double MaxX
	{
		 get { } //Length: 28
	}

	public override double MaxY
	{
		 get { } //Length: 28
	}

	public override double MinX
	{
		 get { } //Length: 28
	}

	public override double MinY
	{
		 get { } //Length: 28
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public override double Precision
	{
		 get { } //Length: 189
		 set { } //Length: 3
	}

	public private override IList<DelaunayTriangle> Triangles
	{
		 get { } //Length: 78
		private set { } //Length: 3
	}

	public override TriangulationMode TriangulationMode
	{
		 get { } //Length: 73
	}

	public Contour(ITriangulatable parent) { }

	public Contour(ITriangulatable parent, IList<TriangulationPoint> points, WindingOrderType windingOrder) { }

	protected virtual void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon) { }

	public override void Add(TriangulationPoint p) { }

	protected void AddHole(Contour c) { }

	public virtual void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder) { }

	public void AddRange(IList<TriangulationPoint> points, WindingOrderType windingOrder) { }

	public override void AddTriangle(DelaunayTriangle t) { }

	public override void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	public override void ClearTriangles() { }

	public override bool Contains(TriangulationPoint p) { }

	public override void CopyTo(TriangulationPoint[] array, int arrayIndex) { }

	public Point2D FindPointInContour() { }

	public override Rect2D get_Bounds() { }

	public override bool get_DisplayFlipX() { }

	public override bool get_DisplayFlipY() { }

	public override float get_DisplayRotate() { }

	public override string get_FileName() { }

	public override TriangulationPoint get_Item(int index) { }

	public override double get_MaxX() { }

	public override double get_MaxY() { }

	public override double get_MinX() { }

	public override double get_MinY() { }

	public string get_Name() { }

	public override double get_Precision() { }

	public override IList<DelaunayTriangle> get_Triangles() { }

	public override TriangulationMode get_TriangulationMode() { }

	public void GetActualHoles(bool parentIsHole, ref List<Contour>& holes) { }

	public Contour GetHole(int idx) { }

	public Enumerator<Contour> GetHoleEnumerator() { }

	public int GetNumHoles() { }

	public int GetNumHoles(bool parentIsHole) { }

	public override int IndexOf(TriangulationPoint p) { }

	public static void InitializeHoles(List<Contour> holes, ITriangulatable parent, ConstrainedPointSet cps) { }

	public void InitializeHoles(ConstrainedPointSet cps) { }

	public override void Insert(int idx, TriangulationPoint p) { }

	public bool IsPointInsideContour(Point2D p) { }

	public override void Prepare(TriangulationContext tcx) { }

	public override bool Remove(TriangulationPoint p) { }

	public override void set_DisplayFlipX(bool value) { }

	public override void set_DisplayFlipY(bool value) { }

	public override void set_DisplayRotate(float value) { }

	public override void set_FileName(string value) { }

	public override void set_Item(int index, TriangulationPoint value) { }

	public void set_Name(string value) { }

	public override void set_Precision(double value) { }

	private void set_Triangles(IList<DelaunayTriangle> value) { }

	private override IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator() { }

	public virtual string ToString() { }

}

