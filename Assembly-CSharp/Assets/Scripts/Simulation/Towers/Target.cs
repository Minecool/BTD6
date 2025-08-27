namespace Assets.Scripts.Simulation.Towers;

public struct Target
{
	private Bloon _bloon; //Field offset: 0x0
	public PathSegment pathSegment; //Field offset: 0x8
	private Nullable<Vector3> position; //Field offset: 0x10
	public Tower tower; //Field offset: 0x20
	private Vector3 bloonTargetOffset; //Field offset: 0x28
	private Vector3 lastBloonPosition; //Field offset: 0x34
	private ObjectId setBloonId; //Field offset: 0x40

	public Bloon bloon
	{
		[IsReadOnly]
		 get { } //Length: 4
		 set { } //Length: 45
	}

	public bool IsValid
	{
		 get { } //Length: 172
	}

	public Vector3 LastPosition
	{
		 get { } //Length: 19
	}

	public Vector3 Position
	{
		 get { } //Length: 78
	}

	public Target(Bloon bloon) { }

	public Target(PathSegment pathSegment) { }

	public Target(Vector3 position) { }

	public Target(Bloon bloon, Vector3 bloonTargetOffset) { }

	public Target(Tower tower) { }

	[IsReadOnly]
	public Bloon get_bloon() { }

	public bool get_IsValid() { }

	public Vector3 get_LastPosition() { }

	public Vector3 get_Position() { }

	public bool GetPosition(out Vector3 pos) { }

	public void set_bloon(Bloon value) { }

}

