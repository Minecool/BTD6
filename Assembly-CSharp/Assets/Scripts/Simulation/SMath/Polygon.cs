namespace Assets.Scripts.Simulation.SMath;

public class Polygon
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Circle> <>9__23_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <FillPolygon>b__23_0(Circle a, Circle b) { }

	}

	public readonly Vector2[] points; //Field offset: 0x10
	private Vector2 boundsMin; //Field offset: 0x18
	private Vector2 boundsMax; //Field offset: 0x20

	public Polygon(List<Vector2> points) { }

	public Polygon(Vector2[] points) { }

	private bool BoundsTest(float x, float y) { }

	private void CalculateBounds() { }

	public Polygon Clone() { }

	public static Circle[] FillPolygon(Polygon poly, float minRadius = 2) { }

	public Vector2 FindClosestPointOnEdge(Vector2 point) { }

	public void FindIntersections(AABB aabb, List<Vector2> list) { }

	public void FindIntersections(float x, float y, float radius, List<Vector2> list) { }

	public void FindIntersections(float aX, float aY, float bX, float bY, List<Vector2> list) { }

	public AABB GetBounds() { }

	public Vector3[] GetPointsUnity(float useHeight, bool flipZ = false) { }

	public bool Intersects(float aX, float aY, float bX, float bY) { }

	public bool Intersects(float x, float y, float radius) { }

	public bool Intersects(AABB aabb) { }

	public bool Intersects(float aX, float aY, float bX, float bY, ref Vector2 p0, ref Vector2 p1, ref Vector2 ip) { }

	public bool IntersectsClosest(float aX, float aY, float bX, float bY, ref Vector2 ip) { }

	public bool IsConvex() { }

	public bool IsPointInside(Vector2 p) { }

	public void Move(Vector2 moveBy) { }

	public void Rotate(Vector2 pivotPoint, float angleRads) { }

	public void Scale(Vector2 pivotPoint, float scale) { }

}

