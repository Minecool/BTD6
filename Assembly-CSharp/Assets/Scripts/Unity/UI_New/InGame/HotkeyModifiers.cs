namespace Assets.Scripts.Unity.UI_New.InGame;

public class HotkeyModifiers : MonoBehaviour
{
	private static HotkeyModifiers instance; //Field offset: 0x0
	public HotkeyModifierKey alt; //Field offset: 0x20
	public HotkeyModifierKey shift; //Field offset: 0x28
	public HotkeyModifierKey ctrl; //Field offset: 0x30

	public static HotkeyModifiers Instance
	{
		 get { } //Length: 266
	}

	public HotkeyModifiers() { }

	public static HotkeyModifiers get_Instance() { }

	public HotkeyModifier GetPressedModifier() { }

	private void OnApplicationFocus(bool focus) { }

	private void Update() { }

}

