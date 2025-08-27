namespace Assets.Scripts.Unity.Gamepad;

[RequireComponent(typeof(ScrollRect))]
public class GamepadScrollConstraint : MonoBehaviour
{
	private MovementType origMovementType; //Field offset: 0x20
	public bool forceUpdate; //Field offset: 0x24
	private ScrollRect scrollRect; //Field offset: 0x28
	public float padding; //Field offset: 0x30

	public GamepadScrollConstraint() { }

	[CompilerGenerated]
	private void <Start>b__4_0(InputSystemMode mode) { }

	private void LateUpdate() { }

	private void Start() { }

	private void UpdatePos(GameObject obj) { }

}

