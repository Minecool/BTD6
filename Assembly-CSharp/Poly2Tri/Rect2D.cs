namespace Poly2Tri;

public class Rect2D
{
	private double mMinX; //Field offset: 0x10
	private double mMaxX; //Field offset: 0x18
	private double mMinY; //Field offset: 0x20
	private double mMaxY; //Field offset: 0x28

	public double Bottom
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool Empty
	{
		 get { } //Length: 34
	}

	public double Height
	{
		 get { } //Length: 11
	}

	public double Left
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public double MaxX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public double MaxY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public double MinX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public double MinY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public double Right
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public double Top
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public double Width
	{
		 get { } //Length: 11
	}

	public Rect2D() { }

	public void AddPoint(Point2D p) { }

	public void Clear() { }

	public bool Contains(double x, double y) { }

	public bool Contains(Rect2D r) { }

	public bool Contains(Point2D p) { }

	public bool ContainsInclusive(double x, double y) { }

	public bool ContainsInclusive(Rect2D r, double epsilon) { }

	public bool ContainsInclusive(Rect2D r) { }

	public bool ContainsInclusive(Point2D p, double epsilon) { }

	public bool ContainsInclusive(Point2D p) { }

	public bool ContainsInclusive(double x, double y, double epsilon) { }

	public bool Equals(Rect2D r) { }

	public bool Equals(Rect2D r, double epsilon) { }

	public virtual bool Equals(object obj) { }

	public double get_Bottom() { }

	public bool get_Empty() { }

	public double get_Height() { }

	public double get_Left() { }

	public double get_MaxX() { }

	public double get_MaxY() { }

	public double get_MinX() { }

	public double get_MinY() { }

	public double get_Right() { }

	public double get_Top() { }

	public double get_Width() { }

	public Point2D GetCenter() { }

	public virtual int GetHashCode() { }

	public void Inflate(double left, double top, double right, double bottom) { }

	public void Inflate(double w, double h) { }

	public bool Intersection(Rect2D r1, Rect2D r2) { }

	public bool Intersects(Rect2D r) { }

	public bool IsNormalized() { }

	public void Normalize() { }

	public void Offset(double w, double h) { }

	public void Set(Rect2D b) { }

	public void Set(double xmin, double xmax, double ymin, double ymax) { }

	public void set_Bottom(double value) { }

	public void set_Left(double value) { }

	public void set_MaxX(double value) { }

	public void set_MaxY(double value) { }

	public void set_MinX(double value) { }

	public void set_MinY(double value) { }

	public void set_Right(double value) { }

	public void set_Top(double value) { }

	public void SetPosition(double x, double y) { }

	public void SetSize(double w, double h) { }

	public void Union(Rect2D r1, Rect2D r2) { }

}

