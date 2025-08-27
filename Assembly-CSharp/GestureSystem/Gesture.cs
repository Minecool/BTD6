namespace GestureSystem;

public class Gesture
{
	[CompilerGenerated]
	private bool <Active>k__BackingField; //Field offset: 0x10
	public IGestureDetector ClaimedByDetector; //Field offset: 0x18
	public TapOnType touchType; //Field offset: 0x20
	public TapOnType hoverType; //Field offset: 0x24
	public TouchableObject touchedObject; //Field offset: 0x28
	public TouchableObject hoveredObject; //Field offset: 0x30
	public bool isController; //Field offset: 0x38
	public Vector2 startPosition; //Field offset: 0x3C
	public Vector2 position; //Field offset: 0x44
	public float startTime; //Field offset: 0x4C
	public TouchPhase phase; //Field offset: 0x50
	public float distance; //Field offset: 0x54
	public float duration; //Field offset: 0x58

	public private bool Active
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool Available
	{
		 get { } //Length: 9
	}

	public Gesture() { }

	private void Begin(Vector2 touchPos) { }

	public void Claim(IGestureDetector detector) { }

	public void End() { }

	[CompilerGenerated]
	public bool get_Active() { }

	public bool get_Available() { }

	private void Precalculate() { }

	[CompilerGenerated]
	private void set_Active(bool value) { }

	public void SimulateWithCursor(ICursor cursor) { }

	public void UpdateTouch(Touch touch) { }

}

