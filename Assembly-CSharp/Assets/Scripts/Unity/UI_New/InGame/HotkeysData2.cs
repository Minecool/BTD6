namespace Assets.Scripts.Unity.UI_New.InGame;

public class HotkeysData2
{
	public readonly Dictionary<String, HotKey> monkeys; //Field offset: 0x10
	public readonly Dictionary<String, HotKey> gameplay; //Field offset: 0x18
	public readonly Dictionary<String, HotKey> sandbox; //Field offset: 0x20
	public readonly Dictionary<String, HotKey> gameplayAdvanced; //Field offset: 0x28
	public readonly Dictionary<String, HotKey> sandboxAdvanced; //Field offset: 0x30

	public HotkeysData2() { }

	public static HotkeyModifier GetPressedModifier() { }

}

