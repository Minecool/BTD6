namespace Assets.Scripts.Simulation.Track;

public class PathImpl : IPath
{
	internal struct PointAndDistance
	{
		public Vector3 point; //Field offset: 0x0
		public float distance; //Field offset: 0xC

	}

	private readonly List<Vector2> pathImplPoints; //Field offset: 0x10
	private readonly List<PointAndDistance> points; //Field offset: 0x18
	private int lastIndex; //Field offset: 0x20
	private float lastDistance; //Field offset: 0x24

	public override float Length
	{
		 get { } //Length: 103
	}

	public PathImpl(List<Vector3> points) { }

	public override Vector3 DistanceToPoint(float distance) { }

	public override Vector3 DistanceToTrajectory(float distance) { }

	public override void FindDistanceSegmentsInCircle(float x, float y, float radius, List<DistanceBracket> list) { }

	public override void FindIntersections(float aX, float aY, float bX, float bY, List<Vector2> list) { }

	public override float FindPathMax() { }

	public Vector3 FlatPointTo3DPoint(Vector3 from, Vector3 to, Vector3 intersect) { }

	public override float get_Length() { }

	public Vector2 GetClosestPoint(Vector2 a) { }

	public override bool IsPointInside(float x, float y) { }

}

