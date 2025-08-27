namespace Assets.Scripts.Unity.UI_New.WorldInteractables;

public class WorldGestures
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ControllerEventDelegate <>9__18_0; //Field offset: 0x8
		public static ControllerEventDelegate <>9__18_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <MakeCursor>b__18_0() { }

		internal void <MakeCursor>b__18_1() { }

	}

	public static readonly float TapGestureDurationThreshold; //Field offset: 0x0
	private GestureManager gestureManager; //Field offset: 0x10
	private DragGestureDetector dragDetector; //Field offset: 0x18
	private ScreenPushDetector screenPushDetector; //Field offset: 0x20
	private WorldCameraController cameraController; //Field offset: 0x28
	public Action<TouchableObject> TouchedTouchableEvent; //Field offset: 0x30
	private bool gameIsFocused; //Field offset: 0x38

	private ICursor InstalledCursor
	{
		private get { } //Length: 27
		private set { } //Length: 27
	}

	private static WorldGestures() { }

	public WorldGestures(Transform uiCanvas) { }

	public void Destroy() { }

	internal void FocusChanged(bool focused) { }

	private ICursor get_InstalledCursor() { }

	public void Init(BoxCollider groundCollider, WorldCameraController cameraController) { }

	private ICursor MakeCursor(Transform container) { }

	private void OnDragEnd(Gesture gesture) { }

	private void OnDragStart(Gesture gesture) { }

	private void OnTouchedTouchableObject(TouchableObject o) { }

	private void set_InstalledCursor(ICursor value) { }

	public void Update() { }

}

