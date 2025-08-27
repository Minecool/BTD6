namespace Assets.Scripts.Simulation.SMath;

public static class Math
{
	internal enum CircleIntersectionType
	{
		none = 0,
		impale = 1,
		enter = 2,
		exit = 3,
	}

	public const float FullCircle = 360; //Field offset: 0x0
	public const float HalfCircle = 180; //Field offset: 0x0
	public const float QuarterCircle = 90; //Field offset: 0x0
	public const float Epsilon = 1E-45; //Field offset: 0x0
	public const float MAX = 9999; //Field offset: 0x0
	public const float PI = 3.1415927; //Field offset: 0x0
	public const float TWOPI = 6.2831855; //Field offset: 0x0
	private static List<Vector3Boxed> rotationCache; //Field offset: 0x0

	public static float Deg2Rad
	{
		 get { } //Length: 9
	}

	public static float Rad2Deg
	{
		 get { } //Length: 9
	}

	public static float Abs(float value) { }

	public static float Acos(float value) { }

	public static float Angle(Vector3 vec1, Vector3 vec2) { }

	public static float Angle(Vector2 vec1, Vector2 vec2) { }

	public static Vector3Boxed AngleToVector3(float angle) { }

	public static float Asin(float value) { }

	public static float Atan2(float a, float b) { }

	public static Vector3 BezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, float t) { }

	public static float CapAngle(float angle) { }

	public static float CapAngle180(float angle) { }

	public static float CapAngleRad(float angle) { }

	public static float Ceil(float value) { }

	public static int CeilToInt(float value) { }

	public static float CircleCircumference(float radius) { }

	public static float Clamp(float value, float min, float max) { }

	public static float Clamp01(float value) { }

	public static float Cos(float radians) { }

	public static float DeltaAngle(float a, float b) { }

	public static bool FindIntersectionLineAABB(float aX, float aY, float bX, float bY, float pX, float pY, float width, float height, out float outX, out float outY) { }

	public static CircleIntersectionType FindIntersectionLineCircle(float aX, float aY, float bX, float bY, float cX, float cY, float r, out float inX, out float inY, out float outX, out float outY) { }

	public static bool FindIntersectionLineLine(float aX, float aY, float bX, float bY, float cX, float cY, float dX, float dY, out float outX, out float outY) { }

	public static float FindSideOfLineFromPoint(float x, float y, float aX, float aY, float bX, float bY) { }

	public static float Floor(float value) { }

	public static int FloorToInt(float value) { }

	public static float get_Deg2Rad() { }

	public static float get_Rad2Deg() { }

	public static Vector2 GetClosestPointOnLineSegment(float pX, float pY, float aX, float aY, float bX, float bY) { }

	public static Vector2 IntersectScreenBounds(Vector2 origin, Vector2 endPoint, float border = 0) { }

	private static float IsLeft(Vector2 p0, Vector2 p1, Vector2 p2) { }

	public static bool IsPrime(int n) { }

	public static float Lerp(float a, float b, float t) { }

	public static float LerpAngle(float a, float b, float t) { }

	public static float LerpUnclamped(float a, float b, float t) { }

	public static bool LineLineBoundingIntersection(float aX, float aY, float bX, float bY, float cX, float cY, float dX, float dY) { }

	public static Vector3[] MakeBezierPoints(Vector3 startPosition, Vector3 endPosition, Vector3 startTangent, Vector3 endTangent, int division) { }

	public static Vector3[] MakeQuadraticBezierPoints(Vector3 p0, Vector3 p1, Vector3 p2, int division) { }

	public static int Max(int a, int b) { }

	public static float Max(float a, float b) { }

	public static float Min(float a, float b) { }

	public static int Min(int a, int b) { }

	public static float MoveTowardsAngle(float current, float target, float maxDelta) { }

	public static bool NearlyEqual(float a, float b) { }

	public static int PointInPolygonUsingWindingNumber(Vector2 p, Vector2[] polygon) { }

	public static Vector2 PointOnCircleCircumference(float angle, float radius) { }

	public static Vector2 PointOnElipseCircumference(float angle, float width, float height) { }

	public static float Pow(float f, float p) { }

	public static float Pow2(float v) { }

	public static float Round(float value) { }

	public static float RoundAngle(float angle) { }

	public static int RoundToNearestInt(float value, int nearestIntValue) { }

	public static float Sign(float value) { }

	public static float SignedAngle(Vector3 vec1, Vector3 vec2) { }

	public static float Sin(float radians) { }

	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	public static float Sqrt(float value) { }

	public static float Tan(float radians) { }

	public static Vector2 TruncateVector2(Vector2 vector, int decimalPlaces = 2) { }

	public static Vector3 TruncateVector3(Vector3 vector, int decimalPlaces = 2) { }

}

