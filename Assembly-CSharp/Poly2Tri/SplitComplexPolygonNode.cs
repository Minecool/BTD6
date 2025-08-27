namespace Poly2Tri;

[DefaultMember("Item")]
public class SplitComplexPolygonNode
{
	private List<SplitComplexPolygonNode> mConnected; //Field offset: 0x10
	private Point2D mPosition; //Field offset: 0x18

	public SplitComplexPolygonNode Item
	{
		 get { } //Length: 81
	}

	public int NumConnected
	{
		 get { } //Length: 60
	}

	public Point2D Position
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public SplitComplexPolygonNode() { }

	public SplitComplexPolygonNode(Point2D pos) { }

	public void AddConnection(SplitComplexPolygonNode toMe) { }

	public void ClearConnections() { }

	public virtual bool Equals(object obj) { }

	public bool Equals(SplitComplexPolygonNode pn) { }

	public SplitComplexPolygonNode get_Item(int index) { }

	public int get_NumConnected() { }

	public Point2D get_Position() { }

	public virtual int GetHashCode() { }

	public SplitComplexPolygonNode GetRightestConnection(Point2D incomingDir) { }

	public SplitComplexPolygonNode GetRightestConnection(SplitComplexPolygonNode incoming) { }

	private bool IsConnectedTo(SplitComplexPolygonNode me) { }

	private bool IsRighter(double sinA, double cosA, double sinB, double cosB) { }

	public static bool op_Equality(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs) { }

	public static bool op_Inequality(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs) { }

	private int remainder(int x, int modulus) { }

	public void RemoveConnection(SplitComplexPolygonNode fromMe) { }

	private void RemoveConnectionByIndex(int index) { }

	public void set_Position(Point2D value) { }

	public virtual string ToString() { }

}

