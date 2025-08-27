namespace Assets.Scripts.Unity.UI_New.InGame;

public class HotkeyButtonSet
{
	public static HotkeyButtonSet instance; //Field offset: 0x0
	private Dictionary<String, HotkeyButton> buttons; //Field offset: 0x10
	private HotkeysData2 data; //Field offset: 0x18
	private Btd6ActionMap actionMap; //Field offset: 0x20

	public HotkeyButtonSet() { }

	public void Add(InputActionMap map, Dictionary<String, HotKey> hotkeys, Dictionary<String, HotKey> defaultHotkeys) { }

	public HotkeyButton GetButton(string key) { }

	public void LateUpdate() { }

	private void Setup(HotkeysData2 data) { }

	public static void SetupInstance(HotkeysData2 data) { }

	public void UpdateBinding(string name, HotKey hotKey) { }

	public void UpdateBindings() { }

}

