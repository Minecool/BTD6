namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class DragGestureDetector : IGestureDetector
{
	public const float MinTouchDuration = 0.01; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsDragging>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Vector2 <DragStart>k__BackingField; //Field offset: 0x14
	private Gesture claimedGesture; //Field offset: 0x20
	[CompilerGenerated]
	private Vector2 <DragOffset>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Action<Gesture> OnDragStart; //Field offset: 0x30
	[CompilerGenerated]
	private Action<Gesture> OnDragEnd; //Field offset: 0x38
	public float MinDragDistance; //Field offset: 0x40
	private TapOnDetector tapOnDetector; //Field offset: 0x48
	private Vector2 cameraMove; //Field offset: 0x50

	public event Action<Gesture> OnDragEnd
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Gesture> OnDragStart
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public private Vector2 DragOffset
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private Vector2 DragStart
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public private bool IsDragging
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public DragGestureDetector(TapOnDetector tapOnDetector) { }

	[CompilerGenerated]
	public void add_OnDragEnd(Action<Gesture> value) { }

	[CompilerGenerated]
	public void add_OnDragStart(Action<Gesture> value) { }

	internal void Cancel() { }

	public override void Detect(Gesture[] gestures) { }

	public override void GestureEnd(Gesture gesture) { }

	[CompilerGenerated]
	public Vector2 get_DragOffset() { }

	[CompilerGenerated]
	public Vector2 get_DragStart() { }

	[CompilerGenerated]
	public bool get_IsDragging() { }

	internal void MoveCameraUnderDrag(Vector2 cameraMove) { }

	[CompilerGenerated]
	public void remove_OnDragEnd(Action<Gesture> value) { }

	[CompilerGenerated]
	public void remove_OnDragStart(Action<Gesture> value) { }

	[CompilerGenerated]
	private void set_DragOffset(Vector2 value) { }

	[CompilerGenerated]
	private void set_DragStart(Vector2 value) { }

	[CompilerGenerated]
	private void set_IsDragging(bool value) { }

	private void StartDrag(Gesture gesture) { }

	private void UpdateDrag(Gesture gesture) { }

}

