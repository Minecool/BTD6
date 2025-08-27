namespace GestureSystem;

public class PinchDetector : IGestureDetector
{
	private const float sameTimeThreshold = 0.2; //Field offset: 0x0
	private Gesture g1; //Field offset: 0x10
	private Gesture g2; //Field offset: 0x18
	private bool active; //Field offset: 0x20
	private float initialDistance; //Field offset: 0x24
	private float distance; //Field offset: 0x28
	private Vector2 initialCenterPoint; //Field offset: 0x2C
	[CompilerGenerated]
	private float <Delta>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private float <Pinch>k__BackingField; //Field offset: 0x38
	public Vector2 centerPoint; //Field offset: 0x3C
	public Action<Single, Single, Vector2> OnPinchChangedEvent; //Field offset: 0x48

	public Vector2 CenterPoint
	{
		 get { } //Length: 19
	}

	public private float Delta
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public Vector2 DragOffset
	{
		 get { } //Length: 29
	}

	public private float Pinch
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public PinchDetector() { }

	public override void Detect(Gesture[] gestures) { }

	private void EndPinch() { }

	public override void GestureEnd(Gesture gesture) { }

	public Vector2 get_CenterPoint() { }

	[CompilerGenerated]
	public float get_Delta() { }

	public Vector2 get_DragOffset() { }

	[CompilerGenerated]
	public float get_Pinch() { }

	[CompilerGenerated]
	private void set_Delta(float value) { }

	[CompilerGenerated]
	private void set_Pinch(float value) { }

	private void StartPinch(Gesture gesture, Gesture otherGesture) { }

	private void Update() { }

}

