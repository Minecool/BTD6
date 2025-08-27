namespace Assets.Scripts.Unity.UI_New.WorldInteractables;

public class WorldCameraController
{
	[CompilerGenerated]
	private Camera <cam>k__BackingField; //Field offset: 0x10
	private CameraMove cameraMove; //Field offset: 0x18
	private Vector3 dragStartPosition; //Field offset: 0x20
	private Vector3 velocity; //Field offset: 0x2C
	private Vector3 pushVelocity; //Field offset: 0x38
	private Vector3 previousPosition; //Field offset: 0x44
	private Vector3 startPosition; //Field offset: 0x50
	private bool isDragging; //Field offset: 0x5C
	public Action CameraWasMoved; //Field offset: 0x60
	public bool draggingDisable; //Field offset: 0x68
	public WorldConfig config; //Field offset: 0x70

	public private Camera cam
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Vector3 CameraPosition
	{
		 get { } //Length: 210
	}

	public WorldCameraController(WorldConfig config, Camera camera) { }

	internal void EndDrag(Vector2 position) { }

	[CompilerGenerated]
	public Camera get_cam() { }

	public Vector3 get_CameraPosition() { }

	public Bounds GetOrthographicBounds() { }

	public void KeepInsideWorld() { }

	public void LateUpdate() { }

	[CompilerGenerated]
	private void set_cam(Camera value) { }

	public void SetNormalizedPosition(Vector2 normalizedPos) { }

	private void SetSizeFixedWidth() { }

	internal void StartDrag(Vector2 dragStart, Vector2 dragOffset) { }

	public void TweenCameraTo(Vector3 pos, float duration) { }

	internal void UpdateDrag(Vector2 dragStart, Vector2 dragOffset) { }

	internal void UpdatePush(ScreenEdge edge) { }

}

