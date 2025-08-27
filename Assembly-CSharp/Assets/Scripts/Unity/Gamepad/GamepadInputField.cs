namespace Assets.Scripts.Unity.Gamepad;

public class GamepadInputField : MonoBehaviour
{
	public Button gamepadButton; //Field offset: 0x20
	private TMP_InputField inputField; //Field offset: 0x28
	private string inputValue; //Field offset: 0x30

	public GamepadInputField() { }

	[CompilerGenerated]
	private void <Start>b__4_0() { }

	[CompilerGenerated]
	private void <Start>b__4_1(InputSystemMode x) { }

	[CompilerGenerated]
	private void <Start>b__4_2(string x) { }

	private string CapLimit(string value) { }

	private void LateUpdate() { }

	private void OnEnable() { }

	public void ShowInputPopup(Action<String> onReturn) { }

	private void Start() { }

}

