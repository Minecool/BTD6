namespace Poly2Tri;

[DefaultMember("Item")]
public class PointSet : Point2DList, ITriangulatable, IEnumerable<TriangulationPoint>, IEnumerable, IList<TriangulationPoint>, ICollection<TriangulationPoint>
{
	protected Dictionary<UInt32, TriangulationPoint> mPointMap; //Field offset: 0x30
	[CompilerGenerated]
	private IList<DelaunayTriangle> <Triangles>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <FileName>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <DisplayFlipX>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <DisplayFlipY>k__BackingField; //Field offset: 0x49
	[CompilerGenerated]
	private float <DisplayRotate>k__BackingField; //Field offset: 0x4C
	protected double mPrecision; //Field offset: 0x50

	public override Rect2D Bounds
	{
		 get { } //Length: 5
	}

	public override bool DisplayFlipX
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override bool DisplayFlipY
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override float DisplayRotate
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override string FileName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override TriangulationPoint Item
	{
		 get { } //Length: 187
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

	public private IList<TriangulationPoint> Points
	{
		 get { } //Length: 4
		private set { } //Length: 3
	}

	public override double Precision
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public private override IList<DelaunayTriangle> Triangles
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public override TriangulationMode TriangulationMode
	{
		 get { } //Length: 3
	}

	public PointSet(List<TriangulationPoint> bounds) { }

	protected virtual void Add(Point2D p, int idx, bool constrainToBounds) { }

	protected bool Add(TriangulationPoint p, int idx, bool constrainToBounds) { }

	public override void Add(TriangulationPoint p) { }

	public virtual void Add(Point2D p) { }

	public virtual void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder) { }

	public override bool AddRange(List<TriangulationPoint> points) { }

	public override void AddTriangle(DelaunayTriangle t) { }

	public override void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	public override void ClearTriangles() { }

	protected bool ConstrainPointToBounds(TriangulationPoint p) { }

	protected bool ConstrainPointToBounds(Point2D p) { }

	public override bool Contains(TriangulationPoint p) { }

	public override void CopyTo(TriangulationPoint[] array, int arrayIndex) { }

	public override Rect2D get_Bounds() { }

	[CompilerGenerated]
	public override bool get_DisplayFlipX() { }

	[CompilerGenerated]
	public override bool get_DisplayFlipY() { }

	[CompilerGenerated]
	public override float get_DisplayRotate() { }

	[CompilerGenerated]
	public override string get_FileName() { }

	public override TriangulationPoint get_Item(int index) { }

	public override double get_MaxX() { }

	public override double get_MaxY() { }

	public override double get_MinX() { }

	public override double get_MinY() { }

	public IList<TriangulationPoint> get_Points() { }

	public override double get_Precision() { }

	[CompilerGenerated]
	public override IList<DelaunayTriangle> get_Triangles() { }

	public override TriangulationMode get_TriangulationMode() { }

	public override int IndexOf(TriangulationPoint p) { }

	public override bool Initialize() { }

	public override void Insert(int idx, TriangulationPoint item) { }

	public override void Prepare(TriangulationContext tcx) { }

	public virtual bool Remove(Point2D p) { }

	public override bool Remove(TriangulationPoint p) { }

	public virtual void RemoveAt(int idx) { }

	[CompilerGenerated]
	public override void set_DisplayFlipX(bool value) { }

	[CompilerGenerated]
	public override void set_DisplayFlipY(bool value) { }

	[CompilerGenerated]
	public override void set_DisplayRotate(float value) { }

	[CompilerGenerated]
	public override void set_FileName(string value) { }

	public override void set_Item(int index, TriangulationPoint value) { }

	private void set_Points(IList<TriangulationPoint> value) { }

	public override void set_Precision(double value) { }

	[CompilerGenerated]
	private void set_Triangles(IList<DelaunayTriangle> value) { }

	private override IEnumerator<TriangulationPoint> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPoint>.GetEnumerator() { }

	public bool TryGetPoint(double x, double y, out TriangulationPoint p) { }

}

