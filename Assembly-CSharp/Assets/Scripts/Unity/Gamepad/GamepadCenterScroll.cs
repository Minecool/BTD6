namespace Assets.Scripts.Unity.Gamepad;

[RequireComponent(typeof(ScrollRect))]
public class GamepadCenterScroll : MonoBehaviour
{
	private MovementType origMovementType; //Field offset: 0x20
	public bool forceUpdate; //Field offset: 0x24
	private ScrollRect scrollRect; //Field offset: 0x28
	public bool horizontal; //Field offset: 0x30
	public Vector2 testOffset; //Field offset: 0x34
	public Vector2 offsetRatio; //Field offset: 0x3C
	private Vector2 restPos; //Field offset: 0x44

	public GamepadCenterScroll() { }

	[CompilerGenerated]
	private void <Start>b__7_0(InputSystemMode mode) { }

	private void LateUpdate() { }

	private void Start() { }

	private void UpdatePos(GameObject obj) { }

}

