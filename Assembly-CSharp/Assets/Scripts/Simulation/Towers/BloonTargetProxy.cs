namespace Assets.Scripts.Simulation.Towers;

public struct BloonTargetProxy
{
	public Bloon bloon; //Field offset: 0x0
	public PathSegment segment; //Field offset: 0x8

	public float distance
	{
		 get { } //Length: 30
	}

	public BloonTargetProxy(Bloon bloon) { }

	public BloonTargetProxy(Bloon bloon, PathSegment middleSegment) { }

	public float get_distance() { }

}

