namespace Poly2Tri;

[DefaultMember("Item")]
public class Point2DList : IEnumerable<Point2D>, IEnumerable, IList<Point2D>, ICollection<Point2D>
{
	[Flags]
	internal enum PolygonError
	{
		None = 0,
		NotEnoughVertices = 1,
		NotConvex = 2,
		NotSimple = 4,
		AreaTooSmall = 8,
		SidesTooCloseToParallel = 16,
		TooThin = 32,
		Degenerate = 64,
		Unknown = 1073741824,
	}

	internal enum WindingOrderType
	{
		CW = 0,
		CCW = 1,
		Unknown = 2,
		Default = 1,
	}

	public static readonly int kMaxPolygonVertices; //Field offset: 0x0
	public static readonly double kLinearSlop; //Field offset: 0x8
	public static readonly double kAngularSlop; //Field offset: 0x10
	protected List<Point2D> mPoints; //Field offset: 0x10
	protected Rect2D mBoundingBox; //Field offset: 0x18
	protected WindingOrderType mWindingOrder; //Field offset: 0x20
	protected double mEpsilon; //Field offset: 0x28

	public Rect2D BoundingBox
	{
		 get { } //Length: 5
	}

	public override int Count
	{
		 get { } //Length: 60
	}

	public double Epsilon
	{
		 get { } //Length: 6
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override Point2D Item
	{
		 get { } //Length: 81
		 set { } //Length: 97
	}

	public WindingOrderType WindingOrder
	{
		 get { } //Length: 4
		 set { } //Length: 127
	}

	private static Point2DList() { }

	public Point2DList() { }

	public Point2DList(int capacity) { }

	public Point2DList(IList<Point2D> l) { }

	public Point2DList(Point2DList l) { }

	protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon) { }

	public override void Add(Point2D p) { }

	public override void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder) { }

	public override void AddRange(Point2DList l) { }

	public void CalculateBounds() { }

	public double CalculateEpsilon() { }

	public WindingOrderType CalculateWindingOrder() { }

	public PolygonError CheckPolygon() { }

	public override void Clear() { }

	public override bool Contains(Point2D p) { }

	public override void CopyTo(Point2D[] array, int arrayIndex) { }

	public Rect2D get_BoundingBox() { }

	public override int get_Count() { }

	public double get_Epsilon() { }

	public override bool get_IsReadOnly() { }

	public override Point2D get_Item(int index) { }

	public WindingOrderType get_WindingOrder() { }

	public double GetArea() { }

	public Point2D GetCentroid() { }

	public static string GetErrorString(PolygonError error) { }

	public double GetSignedArea() { }

	public override int IndexOf(Point2D p) { }

	public override void Insert(int idx, Point2D item) { }

	public bool IsConvex() { }

	public bool IsDegenerate() { }

	public bool IsSimple() { }

	public void MergeParallelEdges(double tolerance) { }

	public int NextIndex(int index) { }

	public int PreviousIndex(int index) { }

	public void ProjectToAxis(Point2D axis, out double min, out double max) { }

	public override bool Remove(Point2D p) { }

	public override void RemoveAt(int idx) { }

	public void RemoveDuplicateNeighborPoints() { }

	public override void RemoveRange(int idxStart, int count) { }

	public void Rotate(double radians) { }

	public void Scale(Point2D value) { }

	public override void set_Item(int index, Point2D value) { }

	public void set_WindingOrder(WindingOrderType value) { }

	public void Simplify() { }

	public void Simplify(double bias) { }

	private override IEnumerator<Point2D> System.Collections.Generic.IEnumerable<Poly2Tri.Point2D>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public void Translate(Point2D vector) { }

}

