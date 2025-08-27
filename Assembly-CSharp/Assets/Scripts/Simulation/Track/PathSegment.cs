namespace Assets.Scripts.Simulation.Track;

public class PathSegment
{
	public List<BloonTargetProxy> bloons; //Field offset: 0x10
	public Path path; //Field offset: 0x18
	public readonly float min; //Field offset: 0x20
	public readonly float max; //Field offset: 0x24
	public readonly float centre; //Field offset: 0x28
	public Vector2 point; //Field offset: 0x2C
	public float pointHeight; //Field offset: 0x34
	public readonly float distanceUntilLeak; //Field offset: 0x38
	public bool bloonsInvulnerable; //Field offset: 0x3C
	public bool moabsInvulnerable; //Field offset: 0x3D

	public float Rotation
	{
		 get { } //Length: 38
	}

	public PathSegment(Path path, float min, float max) { }

	public float DistanceSqrdFrom(Vector2 of) { }

	public void GatherPathInfoData() { }

	public float get_Rotation() { }

	public bool IsInRange(Vector2 of, float range) { }

	public Vector3 MaxPoint() { }

	public Vector3 MinPoint() { }

	public Vector3 ToVector3() { }

}

