namespace GestureSystem;

public class PinchGestureDetector
{
	private const int MaxGestures = 2; //Field offset: 0x0
	private List<Gesture> gestures; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Active>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Started>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	private Vector2 <MidPoint>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Vector2 <PinchStartMidPoint>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private float <Change>k__BackingField; //Field offset: 0x2C
	private float PinchStartDistance; //Field offset: 0x30

	public private bool Active
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float Change
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public Gesture Gesture1
	{
		 get { } //Length: 70
	}

	public Gesture Gesture2
	{
		 get { } //Length: 73
	}

	public private Vector2 MidPoint
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Vector2 PinchStartMidPoint
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool Started
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public PinchGestureDetector() { }

	[CompilerGenerated]
	public bool get_Active() { }

	[CompilerGenerated]
	public float get_Change() { }

	public Gesture get_Gesture1() { }

	public Gesture get_Gesture2() { }

	[CompilerGenerated]
	public Vector2 get_MidPoint() { }

	[CompilerGenerated]
	public Vector2 get_PinchStartMidPoint() { }

	[CompilerGenerated]
	public bool get_Started() { }

	private void Init() { }

	[CompilerGenerated]
	private void set_Active(bool value) { }

	[CompilerGenerated]
	private void set_Change(float value) { }

	[CompilerGenerated]
	private void set_MidPoint(Vector2 value) { }

	[CompilerGenerated]
	private void set_PinchStartMidPoint(Vector2 value) { }

	[CompilerGenerated]
	private void set_Started(bool value) { }

	private void StartPinch() { }

	public void Update() { }

	protected void UpdateGestures() { }

	private void UpdatePinch() { }

}

