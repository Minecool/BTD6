namespace Assets.Scripts.Unity.UI_New.InGame;

public class HotkeyButton : IDisposable
{
	[JsonIgnore]
	private InputAction _inputAction; //Field offset: 0x10
	[JsonIgnore]
	private HotKey hotkey; //Field offset: 0x18
	private string boundPath; //Field offset: 0x20
	[CompilerGenerated]
	private bool <isPressed>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <wasPressedThisFrame>k__BackingField; //Field offset: 0x29
	[CompilerGenerated]
	private bool <wasReleasedThisFrame>k__BackingField; //Field offset: 0x2A

	public private bool isPressed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool wasPressedThisFrame
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool wasReleasedThisFrame
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private void _inputAction_canceled(CallbackContext obj) { }

	private void _inputAction_performed(CallbackContext obj) { }

	public HotkeyButton(InputAction action, HotKey hotkey, string defaultPath) { }

	public override void Dispose() { }

	[CompilerGenerated]
	public bool get_isPressed() { }

	[CompilerGenerated]
	public bool get_wasPressedThisFrame() { }

	[CompilerGenerated]
	public bool get_wasReleasedThisFrame() { }

	private bool HotkeysEnabled() { }

	public void LateUpdate() { }

	[CompilerGenerated]
	private void set_isPressed(bool value) { }

	[CompilerGenerated]
	private void set_wasPressedThisFrame(bool value) { }

	[CompilerGenerated]
	private void set_wasReleasedThisFrame(bool value) { }

	public void UpdateBinding() { }

	public void UpdateHotkey(HotKey hotkey) { }

}

