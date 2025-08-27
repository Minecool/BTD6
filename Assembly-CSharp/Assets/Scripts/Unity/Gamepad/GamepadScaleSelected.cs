namespace Assets.Scripts.Unity.Gamepad;

[RequireComponent(typeof(ScrollRect))]
public class GamepadScaleSelected : MonoBehaviour
{
	private Transform currentSelection; //Field offset: 0x20
	public Transform content; //Field offset: 0x28

	public GamepadScaleSelected() { }

	[CompilerGenerated]
	private void <Start>b__2_0(InputSystemMode mode) { }

	private void Start() { }

	private void UpdateSelected(GameObject obj) { }

}

