namespace Assets.Scripts.Unity.UI_New.InGame;

public class HotkeyModifierKey
{
	public bool isPressed; //Field offset: 0x10
	public Key left; //Field offset: 0x14
	public Key right; //Field offset: 0x18

	public HotkeyModifierKey(Key left, Key right) { }

	public void Reset() { }

	public void Update() { }

}

