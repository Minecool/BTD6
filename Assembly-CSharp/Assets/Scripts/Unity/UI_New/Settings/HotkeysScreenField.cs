namespace Assets.Scripts.Unity.UI_New.Settings;

public class HotkeysScreenField : MonoBehaviour
{
	private string commandName; //Field offset: 0x20
	private HotKey initialHotkey; //Field offset: 0x28
	private HotKey currentHotkey; //Field offset: 0x30
	public Button button; //Field offset: 0x38
	public NK_TextMeshProUGUI commandNameText; //Field offset: 0x40
	public NK_TextMeshProUGUI keyText; //Field offset: 0x48
	public GameObject changedHighlight; //Field offset: 0x50
	private HotkeysScreen hotkeysScreen; //Field offset: 0x58
	private Animator buttonAnimator; //Field offset: 0x60

	public string CommandName
	{
		 get { } //Length: 5
	}

	public HotKey CurrentHotkey
	{
		 get { } //Length: 5
	}

	public HotKey InitialHotkey
	{
		 get { } //Length: 5
	}

	public HotkeysScreenField() { }

	private string FirstCharToUpper(string input) { }

	public string get_CommandName() { }

	public HotKey get_CurrentHotkey() { }

	public HotKey get_InitialHotkey() { }

	public bool HasKeyCode() { }

	public void Initialise(string commandName, HotKey hotkey, HotkeysScreen hotkeysScreen) { }

	public void Modify(HotkeyModifier modifier, string path, bool changeInitial = false) { }

	public void OnUiButtonPressed() { }

	public void UpdateUi() { }

	public bool WasModified() { }

}

