namespace UnityEngine.InputSystem.LowLevel;

public struct KeyboardState : IInputStateTypeInfo
{
	[CompilerGenerated]
	[UnsafeValueType]
	internal struct <keys>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	private const int kSizeInBits = 123; //Field offset: 0x0
	internal const int kSizeInBytes = 16; //Field offset: 0x0
	[FixedBuffer(typeof(byte, 16)]
	[InputControl(name = "numpad6", displayName = "Numpad 6", layout = "Key", bit = 90)]
	[InputControl(name = "numpad5", displayName = "Numpad 5", layout = "Key", bit = 89)]
	[InputControl(name = "numpad4", displayName = "Numpad 4", layout = "Key", bit = 88)]
	[InputControl(name = "numpad3", displayName = "Numpad 3", layout = "Key", bit = 87)]
	[InputControl(name = "numpad2", displayName = "Numpad 2", layout = "Key", bit = 86)]
	[InputControl(name = "numpad1", displayName = "Numpad 1", layout = "Key", bit = 85)]
	[InputControl(name = "numpadEquals", displayName = "Numpad =", layout = "Key", bit = 83)]
	[InputControl(name = "numpadPeriod", displayName = "Numpad .", layout = "Key", bit = 82)]
	[InputControl(name = "numpadMinus", displayName = "Numpad -", layout = "Key", bit = 81)]
	[InputControl(name = "numpadPlus", displayName = "Numpad +", layout = "Key", bit = 80)]
	[InputControl(name = "numpadMultiply", displayName = "Numpad *", layout = "Key", bit = 79)]
	[InputControl(name = "numpadDivide", displayName = "Numpad /", layout = "Key", bit = 78)]
	[InputControl(name = "numpadEnter", displayName = "Numpad Enter", layout = "Key", bit = 77)]
	[InputControl(name = "numpad7", displayName = "Numpad 7", layout = "Key", bit = 91)]
	[InputControl(name = "pause", displayName = "Pause/Break", layout = "Key", bit = 76)]
	[InputControl(name = "printScreen", displayName = "Print Screen", layout = "Key", bit = 74)]
	[InputControl(name = "numLock", displayName = "Num Lock", layout = "Key", bit = 73)]
	[InputControl(name = "capsLock", displayName = "Caps Lock", layout = "Key", bit = 72)]
	[InputControl(name = "delete", displayName = "Delete", layout = "Key", bit = 71)]
	[InputControl(name = "insert", displayName = "Insert", layout = "Key", bit = 70)]
	[InputControl(name = "end", displayName = "End", layout = "Key", bit = 69)]
	[InputControl(name = "home", displayName = "Home", layout = "Key", bit = 68)]
	[InputControl(name = "pageUp", displayName = "Page Up", layout = "Key", bit = 67)]
	[InputControl(name = "pageDown", displayName = "Page Down", layout = "Key", bit = 66)]
	[InputControl(name = "backspace", displayName = "Backspace", layout = "Key", bit = 65)]
	[InputControl(name = "contextMenu", displayName = "Context Menu", layout = "Key", usage = "Modifier", bit = 59)]
	[InputControl(name = "rightMeta", displayName = "Right System", layout = "Key", usage = "Modifier", bit = 58, aliases = new IL2CPP_TYPE_STRING[] {"RightWindows", "RightApple", "RightCommand"}])]
	[InputControl(name = "leftMeta", displayName = "Left System", layout = "Key", usage = "Modifier", bit = 57, aliases = new IL2CPP_TYPE_STRING[] {"LeftWindows", "LeftApple", "LeftCommand"}])]
	[InputControl(name = "scrollLock", displayName = "Scroll Lock", layout = "Key", bit = 75)]
	[InputControl(name = "ctrl", displayName = "Control", layout = "DiscreteButton", usage = "Modifier", bit = 55, sizeInBits = 2, synthetic = True, parameters = "minValue=1,maxValue=3,writeMode=1")]
	[InputControl(name = "numpad8", displayName = "Numpad 8", layout = "Key", bit = 92)]
	[InputControl(name = "numpad0", displayName = "Numpad 0", layout = "Key", bit = 84)]
	[InputControl(name = "f23", displayName = "F23", layout = "Key", bit = 122)]
	[InputControl(name = "f22", displayName = "F22", layout = "Key", bit = 121)]
	[InputControl(name = "f21", displayName = "F21", layout = "Key", bit = 120)]
	[InputControl(name = "f20", displayName = "F20", layout = "Key", bit = 119)]
	[InputControl(name = "f19", displayName = "F19", layout = "Key", bit = 118)]
	[InputControl(name = "f18", displayName = "F18", layout = "Key", bit = 117)]
	[InputControl(name = "f17", displayName = "F17", layout = "Key", bit = 116)]
	[InputControl(name = "f16", displayName = "F16", layout = "Key", bit = 115)]
	[InputControl(name = "f15", displayName = "F15", layout = "Key", bit = 114)]
	[InputControl(name = "f14", displayName = "F14", layout = "Key", bit = 113)]
	[InputControl(name = "f13", displayName = "F13", layout = "Key", bit = 112)]
	[InputControl(name = "OEM5", layout = "Key", bit = 110)]
	[InputControl(name = "OEM4", layout = "Key", bit = 109)]
	[InputControl(name = "numpad9", displayName = "Numpad 9", layout = "Key", bit = 93)]
	[InputControl(name = "OEM3", layout = "Key", bit = 108)]
	[InputControl(name = "OEM1", layout = "Key", bit = 106)]
	[InputControl(name = "f12", displayName = "F12", layout = "Key", bit = 105)]
	[InputControl(name = "f11", displayName = "F11", layout = "Key", bit = 104)]
	[InputControl(name = "f10", displayName = "F10", layout = "Key", bit = 103)]
	[InputControl(name = "f9", displayName = "F9", layout = "Key", bit = 102)]
	[InputControl(name = "f8", displayName = "F8", layout = "Key", bit = 101)]
	[InputControl(name = "f7", displayName = "F7", layout = "Key", bit = 100)]
	[InputControl(name = "f6", displayName = "F6", layout = "Key", bit = 99)]
	[InputControl(name = "f5", displayName = "F5", layout = "Key", bit = 98)]
	[InputControl(name = "f4", displayName = "F4", layout = "Key", bit = 97)]
	[InputControl(name = "f3", displayName = "F3", layout = "Key", bit = 96)]
	[InputControl(name = "f2", displayName = "F2", layout = "Key", bit = 95)]
	[InputControl(name = "f1", displayName = "F1", layout = "Key", bit = 94)]
	[InputControl(name = "OEM2", layout = "Key", bit = 107)]
	[InputControl(name = "rightCtrl", displayName = "Right Control", layout = "Key", usage = "Modifier", bit = 56)]
	[InputControl(name = "leftCtrl", displayName = "Left Control", layout = "Key", usage = "Modifier", bit = 55)]
	[InputControl(name = "alt", displayName = "Alt", layout = "DiscreteButton", usage = "Modifier", bit = 53, sizeInBits = 2, synthetic = True, parameters = "minValue=1,maxValue=3,writeMode=1")]
	[InputControl(name = "h", displayName = "H", layout = "Key", bit = 22)]
	[InputControl(name = "g", displayName = "G", layout = "Key", bit = 21)]
	[InputControl(name = "f", displayName = "F", layout = "Key", bit = 20)]
	[InputControl(name = "e", displayName = "E", layout = "Key", bit = 19)]
	[InputControl(name = "d", displayName = "D", layout = "Key", bit = 18)]
	[InputControl(name = "c", displayName = "C", layout = "Key", bit = 17)]
	[InputControl(name = "b", displayName = "B", layout = "Key", bit = 16)]
	[InputControl(name = "a", displayName = "A", layout = "Key", bit = 15)]
	[InputControl(name = "rightArrow", displayName = "Right Arrow", layout = "Key", bit = 62)]
	[InputControl(name = "leftArrow", displayName = "Left Arrow", layout = "Key", bit = 61)]
	[InputControl(name = "downArrow", displayName = "Down Arrow", layout = "Key", bit = 64)]
	[InputControl(name = "upArrow", displayName = "Up Arrow", layout = "Key", bit = 63)]
	[InputControl(name = "equals", displayName = "=", layout = "Key", bit = 14)]
	[InputControl(name = "i", displayName = "I", layout = "Key", bit = 23)]
	[InputControl(name = "minus", displayName = "-", layout = "Key", bit = 13)]
	[InputControl(name = "leftBracket", displayName = "[", layout = "Key", bit = 11)]
	[InputControl(name = "backslash", displayName = "\\", layout = "Key", bit = 10)]
	[InputControl(name = "slash", displayName = "/", layout = "Key", bit = 9)]
	[InputControl(name = "period", displayName = ".", layout = "Key", bit = 8)]
	[InputControl(name = "comma", displayName = ",", layout = "Key", bit = 7)]
	[InputControl(name = "semicolon", displayName = ";", layout = "Key", bit = 6)]
	[InputControl(name = "quote", displayName = "'", layout = "Key", bit = 5)]
	[InputControl(name = "backquote", displayName = "`", layout = "Key", bit = 4)]
	[InputControl(name = "tab", displayName = "Tab", layout = "Key", bit = 3)]
	[InputControl(name = "enter", displayName = "Enter", layout = "Key", usage = "Submit", bit = 2)]
	[InputControl(name = "space", displayName = "Space", layout = "Key", bit = 1)]
	[InputControl(name = "escape", displayName = "Escape", layout = "Key", usages = new IL2CPP_TYPE_STRING[] {"Back", "Cancel"}], bit = 60)]
	[InputControl(name = "anyKey", displayName = "Any Key", layout = "AnyKey", bit = 1, sizeInBits = 123, synthetic = True)]
	[InputControl(name = "rightBracket", displayName = "]", layout = "Key", bit = 12)]
	[InputControl(name = "j", displayName = "J", layout = "Key", bit = 24)]
	[InputControl(name = "k", displayName = "K", layout = "Key", bit = 25)]
	[InputControl(name = "l", displayName = "L", layout = "Key", bit = 26)]
	[InputControl(name = "rightAlt", displayName = "Right Alt", layout = "Key", usage = "Modifier", bit = 54, alias = "AltGr")]
	[InputControl(name = "leftAlt", displayName = "Left Alt", layout = "Key", usage = "Modifier", bit = 53)]
	[InputControl(name = "shift", displayName = "Shift", layout = "DiscreteButton", usage = "Modifier", bit = 51, sizeInBits = 2, synthetic = True, parameters = "minValue=1,maxValue=3,writeMode=1")]
	[InputControl(name = "rightShift", displayName = "Right Shift", layout = "Key", usage = "Modifier", bit = 52)]
	[InputControl(name = "leftShift", displayName = "Left Shift", layout = "Key", usage = "Modifier", bit = 51)]
	[InputControl(name = "0", displayName = "0", layout = "Key", bit = 50)]
	[InputControl(name = "9", displayName = "9", layout = "Key", bit = 49)]
	[InputControl(name = "8", displayName = "8", layout = "Key", bit = 48)]
	[InputControl(name = "7", displayName = "7", layout = "Key", bit = 47)]
	[InputControl(name = "6", displayName = "6", layout = "Key", bit = 46)]
	[InputControl(name = "5", displayName = "5", layout = "Key", bit = 45)]
	[InputControl(name = "4", displayName = "4", layout = "Key", bit = 44)]
	[InputControl(name = "3", displayName = "3", layout = "Key", bit = 43)]
	[InputControl(name = "2", displayName = "2", layout = "Key", bit = 42)]
	[InputControl(name = "1", displayName = "1", layout = "Key", bit = 41)]
	[InputControl(name = "z", displayName = "Z", layout = "Key", bit = 40)]
	[InputControl(name = "y", displayName = "Y", layout = "Key", bit = 39)]
	[InputControl(name = "x", displayName = "X", layout = "Key", bit = 38)]
	[InputControl(name = "w", displayName = "W", layout = "Key", bit = 37)]
	[InputControl(name = "v", displayName = "V", layout = "Key", bit = 36)]
	[InputControl(name = "u", displayName = "U", layout = "Key", bit = 35)]
	[InputControl(name = "t", displayName = "T", layout = "Key", bit = 34)]
	[InputControl(name = "s", displayName = "S", layout = "Key", bit = 33)]
	[InputControl(name = "r", displayName = "R", layout = "Key", bit = 32)]
	[InputControl(name = "q", displayName = "Q", layout = "Key", bit = 31)]
	[InputControl(name = "p", displayName = "P", layout = "Key", bit = 30)]
	[InputControl(name = "o", displayName = "O", layout = "Key", bit = 29)]
	[InputControl(name = "n", displayName = "N", layout = "Key", bit = 28)]
	[InputControl(name = "m", displayName = "M", layout = "Key", bit = 27)]
	[InputControl(name = "f24", displayName = "F24", layout = "Key", bit = 123)]
	[InputControl(name = "IMESelected", layout = "Button", bit = 127, synthetic = True)]
	public <keys>e__FixedBuffer keys; //Field offset: 0x0

	public override FourCC format
	{
		 get { } //Length: 53
	}

	public static FourCC Format
	{
		 get { } //Length: 53
	}

	public KeyboardState(Key[] pressedKeys) { }

	public KeyboardState(bool IMESelected, Key[] pressedKeys) { }

	internal bool Get(Key key) { }

	public override FourCC get_format() { }

	public static FourCC get_Format() { }

	public void Press(Key key) { }

	public void Release(Key key) { }

	public void Set(Key key, bool state) { }

}

