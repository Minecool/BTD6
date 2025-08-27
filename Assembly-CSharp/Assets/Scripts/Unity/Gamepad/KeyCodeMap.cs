namespace Assets.Scripts.Unity.Gamepad;

public class KeyCodeMap
{
	private static KeyCodeMap instance; //Field offset: 0x0
	private Dictionary<Key, KeyCode> key; //Field offset: 0x10
	private Dictionary<KeyCode, Key> keyCode; //Field offset: 0x18

	public static KeyCodeMap Instance
	{
		 get { } //Length: 153
	}

	public KeyCodeMap() { }

	private void Add(Key key, KeyCode code) { }

	public Key Convert(KeyCode keyCode) { }

	public static string ConvertToString(Key key) { }

	public static KeyCodeMap get_Instance() { }

	private void Init() { }

}

