namespace Assets.Scripts.Simulation.Track;

public interface IPath
{

	public float Length
	{
		 get { } //Length: 0
	}

	public Vector3 DistanceToPoint(float distance) { }

	public Vector3 DistanceToTrajectory(float distance) { }

	public void FindDistanceSegmentsInCircle(float x, float y, float radius, List<DistanceBracket> list) { }

	public void FindIntersections(float aX, float aY, float bX, float bY, List<Vector2> list) { }

	public float FindPathMax() { }

	public float get_Length() { }

	public bool IsPointInside(float x, float y) { }

}

