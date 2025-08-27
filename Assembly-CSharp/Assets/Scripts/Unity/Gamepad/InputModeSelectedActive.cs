namespace Assets.Scripts.Unity.Gamepad;

public class InputModeSelectedActive : MonoBehaviour
{
	public Selectable selectable; //Field offset: 0x20
	public GameObject activeTarget; //Field offset: 0x28
	public GameObject[] standardTargets; //Field offset: 0x30
	public GameObject[] gamepadTargets; //Field offset: 0x38

	public InputModeSelectedActive() { }

	private void LateUpdate() { }

	private void Start() { }

}

