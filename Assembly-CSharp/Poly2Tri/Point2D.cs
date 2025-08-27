namespace Poly2Tri;

public class Point2D : IComparable<Point2D>
{
	protected double mX; //Field offset: 0x10
	protected double mY; //Field offset: 0x18

	public override double X
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Xf
	{
		 get { } //Length: 32
	}

	public override double Y
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Yf
	{
		 get { } //Length: 32
	}

	public Point2D(Point2D p) { }

	public Point2D(double x, double y) { }

	public Point2D() { }

	public static Point2D Abs(Point2D a) { }

	public void Abs() { }

	public void Add(double scalar) { }

	public void Add(Point2D p) { }

	public void Clamp(Point2D low, Point2D high) { }

	public static Point2D Clamp(Point2D a, Point2D low, Point2D high) { }

	public override int CompareTo(Point2D other) { }

	public static double Cross(Point2D lhs, Point2D rhs) { }

	public double Cross(Point2D p) { }

	public void Divide(double scalar) { }

	public void Divide(Point2D p) { }

	public double Dot(Point2D p) { }

	public static double Dot(Point2D lhs, Point2D rhs) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(Point2D p) { }

	public bool Equals(Point2D p, double epsilon) { }

	public override double get_X() { }

	public float get_Xf() { }

	public override double get_Y() { }

	public float get_Yf() { }

	public virtual int GetHashCode() { }

	public double Magnitude() { }

	public double MagnitudeReciprocal() { }

	public double MagnitudeSquared() { }

	public static Point2D Max(Point2D a, Point2D b) { }

	public static Point2D Min(Point2D a, Point2D b) { }

	public void Multiply(double scalar) { }

	public void Multiply(Point2D p) { }

	public void Negate() { }

	public void Normalize() { }

	public static Point2D op_Addition(Point2D lhs, double scalar) { }

	public static Point2D op_Addition(Point2D lhs, Point2D rhs) { }

	public static Point2D op_Division(Point2D lhs, double scalar) { }

	public static Point2D op_Division(Point2D lhs, Point2D rhs) { }

	public static bool op_GreaterThan(Point2D lhs, Point2D rhs) { }

	public static bool op_GreaterThanOrEqual(Point2D lhs, Point2D rhs) { }

	public static bool op_LessThan(Point2D lhs, Point2D rhs) { }

	public static bool op_LessThanOrEqual(Point2D lhs, Point2D rhs) { }

	public static Point2D op_Multiply(double scalar, Point2D lhs) { }

	public static Point2D op_Multiply(Point2D lhs, double scalar) { }

	public static Point2D op_Multiply(Point2D lhs, Point2D rhs) { }

	public static Point2D op_Subtraction(Point2D lhs, double scalar) { }

	public static Point2D op_Subtraction(Point2D lhs, Point2D rhs) { }

	public static Point2D op_UnaryNegation(Point2D p) { }

	public static Point2D Perpendicular(Point2D lhs, double scalar) { }

	public static Point2D Perpendicular(double scalar, Point2D rhs) { }

	public void Reciprocal() { }

	public static Point2D Reciprocal(Point2D a) { }

	public void Rotate(double radians) { }

	public void RotateDegrees(double degrees) { }

	public void Scale(double x, double y) { }

	public void Scale(Point2D vector) { }

	public void Scale(double scalar) { }

	public override void Set(double x, double y) { }

	public override void Set(Point2D p) { }

	public override void set_X(double value) { }

	public override void set_Y(double value) { }

	public void Subtract(Point2D p) { }

	public void Subtract(double scalar) { }

	public virtual string ToString() { }

	public void Translate(Point2D vector) { }

	public void Translate(double x, double y) { }

}

