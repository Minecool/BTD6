namespace UnityEngine;

public class TextEditor
{
	internal enum DblClickSnapping
	{
		WORDS = 0,
		PARAGRAPHS = 1,
	}

	private readonly GUIContent m_Content; //Field offset: 0x10
	private TextSelectingUtilities m_TextSelecting; //Field offset: 0x18
	internal TextEditingUtilities m_TextEditing; //Field offset: 0x20
	internal IMGUITextHandle m_TextHandle; //Field offset: 0x28
	public TouchScreenKeyboard keyboardOnScreen; //Field offset: 0x30
	public int controlID; //Field offset: 0x38
	public GUIStyle style; //Field offset: 0x40
	[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", True)]
	public bool hasHorizontalCursorPos; //Field offset: 0x48
	public bool isPasswordField; //Field offset: 0x49
	public Vector2 scrollOffset; //Field offset: 0x4C
	private string m_TextWithWhitespace; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <position>k__BackingField; //Field offset: 0x60
	public Vector2 graphicalCursorPos; //Field offset: 0x70
	private Vector2 lastCursorPos; //Field offset: 0x78
	private Vector2 previousContentSize; //Field offset: 0x80

	public Rect position
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool showCursor
	{
		 get { } //Length: 27
	}

	public string text
	{
		 get { } //Length: 27
		 set { } //Length: 169
	}

	internal string textWithWhitespace
	{
		internal get { } //Length: 110
		internal set { } //Length: 112
	}

	[RequiredByNativeCode]
	public TextEditor() { }

	[CompilerGenerated]
	public Rect get_position() { }

	public bool get_showCursor() { }

	public string get_text() { }

	internal string get_textWithWhitespace() { }

	private void OnContentTextChangedHandle() { }

	internal override void OnCursorIndexChange() { }

	internal override void OnSelectIndexChange() { }

	private void OnTextChangedHandle() { }

	public void set_text(string value) { }

	internal void set_textWithWhitespace(string value) { }

	[VisibleToOtherModules]
	internal void UpdateScrollOffset() { }

	internal void UpdateTextHandle() { }

}

