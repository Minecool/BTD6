namespace Assets.Scripts.Simulation.SMath;

public struct Vector2
{
	public static readonly Vector2 zero; //Field offset: 0x0
	public static readonly Vector2 forward; //Field offset: 0x8
	public float x; //Field offset: 0x0
	public float y; //Field offset: 0x4

	[JsonIgnore]
	public float Magnitude
	{
		 get { } //Length: 91
	}

	[JsonIgnore]
	public float MagnitudeSquared
	{
		 get { } //Length: 22
	}

	[JsonIgnore]
	public float Rotation
	{
		 get { } //Length: 50
	}

	private static Vector2() { }

	public Vector2(Vector2 vector) { }

	public Vector2(float x = 0, float y = 0) { }

	public Vector2(Vector2 vector) { }

	public void AdjustHeightInCameraSpace(float heightIncr) { }

	public float AngleBetween(Vector2 other) { }

	public static Vector2 DegreeToVector2(float degree) { }

	public float Distance(Vector2 b) { }

	public float DistanceSquared(Vector2 b) { }

	public float Dot(Vector2 with) { }

	public virtual bool Equals(object obj) { }

	public float get_Magnitude() { }

	public float get_MagnitudeSquared() { }

	public float get_Rotation() { }

	public virtual int GetHashCode() { }

	public static Vector2 Lerp(Vector2 p0, Vector2 p1, float t) { }

	public static Vector2 LerpUnclamped(Vector2 p0, Vector2 p1, float t) { }

	public void Normalize() { }

	public Vector2 Normalized() { }

	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	public static bool op_Equality(Vector2 a, Vector2 b) { }

	public static bool op_Inequality(Vector2 a, Vector2 b) { }

	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	public static Vector2 op_Multiply(Vector2 a, float value) { }

	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	public Vector2 Perpendicular() { }

	public static Vector2 QuadraticBezier(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t) { }

	public static Vector2 RadianToVector2(float radian) { }

	public void Rotate(float degrees) { }

	public static Vector2 RotateAroundPoint(Vector2 pointToRotate, Vector2 pivotPoint, float angleRads) { }

	public Vector2 ToUnity() { }

	public Vector3 ToVector3() { }

	public void Truncate(float value) { }

}

