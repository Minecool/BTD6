namespace Assets.Scripts.Unity.UI_New.Settings;

public class HotkeysScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, HotKey>, Int32> <>9__26_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, HotKey>, Boolean> <>9__26_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <PopulateFields>b__26_0(KeyValuePair<String, HotKey> hotkeyDictionaryPair) { }

		internal bool <PopulateFields>b__26_1(KeyValuePair<String, HotKey> hotkeyDictionaryPair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public KeyValuePair<String, HotKey> hotkeyDictionaryPair; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <PopulateFields>b__2(string towerId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public HotkeysScreen <>4__this; //Field offset: 0x10
		public String[] excludeKeys; //Field offset: 0x18
		public HotkeysScreenField fieldBeingChanged; //Field offset: 0x20

		public <>c__DisplayClass28_0() { }

		internal void <OnStartChangingHotkey>b__0(RebindingOperation x) { }

		internal void <OnStartChangingHotkey>b__1(RebindingOperation x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public HotkeysScreen <>4__this; //Field offset: 0x10
		public String[] excludeKeys; //Field offset: 0x18
		public HotkeyModifier keyModifier; //Field offset: 0x20

		public <>c__DisplayClass29_0() { }

		internal void <BindWithModifier>b__0(RebindingOperation z) { }

		internal void <BindWithModifier>b__1(RebindingOperation x) { }

	}

	private static List<HotkeysScreenField> monkeyFields; //Field offset: 0x0
	private static List<HotkeysScreenField> gameplayFields; //Field offset: 0x8
	private static List<HotkeysScreenField> sandboxFields; //Field offset: 0x10
	private static List<HotkeysScreenField> monkeysAdvancedFields; //Field offset: 0x18
	private static List<HotkeysScreenField> gameplayAdvancedFields; //Field offset: 0x20
	private static List<HotkeysScreenField> sandboxAdvancedFields; //Field offset: 0x28
	private static List<HotkeysScreenField> allFields; //Field offset: 0x30
	public GameObject monkeysContainer; //Field offset: 0x48
	public GameObject gameplayContainer; //Field offset: 0x50
	public GameObject sandboxContainer; //Field offset: 0x58
	public GameObject monkeysAdvancedContainer; //Field offset: 0x60
	public GameObject gameplayAdvancedContainer; //Field offset: 0x68
	public GameObject sandboxAdvancedContainer; //Field offset: 0x70
	private HotkeysScreenField fieldBeingChanged; //Field offset: 0x78
	public Toggle standardCursorToggle; //Field offset: 0x80
	public Toggle largeCursorToggle; //Field offset: 0x88
	public Toggle xLargeCursorToggle; //Field offset: 0x90
	public List<Transform> cursorPerformanceWarnings; //Field offset: 0x98
	private InputAction actionToRebind; //Field offset: 0xA0
	private RebindingOperation rebindingOperation; //Field offset: 0xA8
	private float modifierKeyTimeout; //Field offset: 0xB0
	private HotkeyModifier currentKeyModifier; //Field offset: 0xB4
	private string currentModifierPath; //Field offset: 0xB8
	private bool saved; //Field offset: 0xC0

	private static HotkeysScreen() { }

	public HotkeysScreen() { }

	[CompilerGenerated]
	private void <Open>b__23_0(bool isOn) { }

	[CompilerGenerated]
	private void <Open>b__23_1(bool isOn) { }

	[CompilerGenerated]
	private void <Open>b__23_2(bool isOn) { }

	private void ActionToRebind_performed(CallbackContext obj) { }

	private bool AreThereChanges() { }

	private void BindWithModifier(HotkeyModifier keyModifier) { }

	private void ChangeField(HotkeysScreenField field, HotkeyModifier modifier, string path) { }

	private void HotkeyTimeout() { }

	private void OnRevert() { }

	private void OnSave() { }

	public void OnStartChangingHotkey(HotkeysScreenField fieldBeingChanged) { }

	public virtual void Open(object menuData) { }

	public virtual bool OverrideClose() { }

	private void PopulateFields(List<HotkeysScreenField> fields, GameObject container, Dictionary<String, HotKey> hotkeyDictionary) { }

	public void RestoreDefaults() { }

	private void SaveChanges() { }

	private void SetCursorConfig(CursorConfig config) { }

	private void Update() { }

}

