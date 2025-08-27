namespace GestureSystem;

public abstract class RaycastingDetector
{
	private RaycastHit[] raycastResults; //Field offset: 0x10
	private List<RaycastResult> uiRaycastResults; //Field offset: 0x18
	private BoxCollider groundCollider; //Field offset: 0x20
	private Camera cam; //Field offset: 0x28

	public RaycastingDetector(BoxCollider groundCollider, Camera camera) { }

	protected TouchableObject RaycastTouchableObjects(Vector2 position) { }

	protected bool RaycastUI(Vector2 position) { }

	protected TouchableObject RaycastUnits(Vector2 position) { }

}

