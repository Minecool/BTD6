namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack;

public struct PathSegmentInRange : IEquatable<PathSegmentInRange>
{
	public PathSegment segment; //Field offset: 0x0
	public bool inRange; //Field offset: 0x8
	public bool canSeeCamo; //Field offset: 0x9
	public bool lineOfSight; //Field offset: 0xA

	public override bool Equals(PathSegmentInRange other) { }

}

