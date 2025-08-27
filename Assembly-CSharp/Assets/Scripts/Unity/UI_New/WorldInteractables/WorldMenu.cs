namespace Assets.Scripts.Unity.UI_New.WorldInteractables;

public abstract class WorldMenu : MonoBehaviour
{
	protected WorldGestures gameGestures; //Field offset: 0x20
	public Canvas uiCanvas; //Field offset: 0x28
	public BoxCollider groundCollider; //Field offset: 0x30
	public WorldCameraController cameraController; //Field offset: 0x38
	public WorldConfig config; //Field offset: 0x40
	public Camera cam; //Field offset: 0x48
	protected List<TouchableObject> touchableObjects; //Field offset: 0x50

	protected WorldMenu() { }

	public override void Init() { }

	private void LateUpdate() { }

	private void OnApplicationFocus(bool focused) { }

	protected abstract void OnTouchedEnvironment(TouchableObject o) { }

	public void SetCameraToStartPosition() { }

	public override void SetMaxPostiveXWorldCameraValue(int difficultyState) { }

	public void Start() { }

	private void Update() { }

}

