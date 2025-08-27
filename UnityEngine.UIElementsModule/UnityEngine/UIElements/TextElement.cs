namespace UnityEngine.UIElements;

public class TextElement : BindableElement, INotifyValueChanged<String>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x90
		private UxmlBoolAttributeDescription m_EnableRichText; //Field offset: 0x98
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport; //Field offset: 0xA0
		private UxmlBoolAttributeDescription m_ParseEscapeSequences; //Field offset: 0xA8
		private UxmlBoolAttributeDescription m_Selectable; //Field offset: 0xB0
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick; //Field offset: 0xB8
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick; //Field offset: 0xC0
		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; //Field offset: 0xC8

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId displayTooltipWhenElidedProperty; //Field offset: 0x0
	private const string ZeroWidthSpace = "​"; //Field offset: 0x0
	internal static readonly BindingId emojiFallbackSupportProperty; //Field offset: 0x98
	internal static readonly BindingId enableRichTextProperty; //Field offset: 0x130
	internal static readonly BindingId isElidedProperty; //Field offset: 0x1C8
	internal static readonly BindingId parseEscapeSequencesProperty; //Field offset: 0x260
	internal static readonly BindingId textProperty; //Field offset: 0x2F8
	internal static readonly BindingId valueProperty; //Field offset: 0x390
	public static readonly string ussClassName; //Field offset: 0x428
	public static readonly string selectableUssClassName; //Field offset: 0x430
	internal static readonly string k_EllipsisText; //Field offset: 0x438
	internal static readonly BindingId autoCorrectionProperty; //Field offset: 0x440
	internal static readonly BindingId hideMobileInputProperty; //Field offset: 0x4D8
	internal static readonly BindingId keyboardTypeProperty; //Field offset: 0x570
	internal static readonly BindingId isReadOnlyProperty; //Field offset: 0x608
	internal static readonly BindingId isPasswordProperty; //Field offset: 0x6A0
	internal static readonly BindingId maxLengthProperty; //Field offset: 0x738
	internal static readonly BindingId maskCharProperty; //Field offset: 0x7D0
	internal static readonly BindingId isSelectableProperty; //Field offset: 0x868
	internal static readonly BindingId cursorIndexProperty; //Field offset: 0x900
	internal static readonly BindingId selectIndexProperty; //Field offset: 0x998
	internal static readonly BindingId doubleClickSelectsWordProperty; //Field offset: 0xA30
	internal static readonly BindingId tripleClickSelectsLineProperty; //Field offset: 0xAC8
	internal static readonly BindingId cursorPositionProperty; //Field offset: 0xB60
	internal static readonly BindingId selectAllOnFocusProperty; //Field offset: 0xBF8
	internal static readonly BindingId selectAllOnMouseUpProperty; //Field offset: 0xC90
	internal static readonly BindingId selectionProperty; //Field offset: 0xD28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UITKTextHandle <uitkTextHandle>k__BackingField; //Field offset: 0x4B8
	private string m_Text; //Field offset: 0x4C0
	private bool m_EnableRichText; //Field offset: 0x4C8
	private bool m_EmojiFallbackSupport; //Field offset: 0x4C9
	private bool m_ParseEscapeSequences; //Field offset: 0x4CA
	private bool m_DisplayTooltipWhenElided; //Field offset: 0x4CB
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isElided>k__BackingField; //Field offset: 0x4CC
	internal string elidedText; //Field offset: 0x4D0
	private bool m_WasElided; //Field offset: 0x4D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private TextEditingManipulator <editingManipulator>k__BackingField; //Field offset: 0x4E0
	internal bool isInputField; //Field offset: 0x4E8
	private bool m_Multiline; //Field offset: 0x4E9
	internal TouchScreenKeyboard m_TouchScreenKeyboard; //Field offset: 0x4F0
	internal Action<Boolean> onIsReadOnlyChanged; //Field offset: 0x4F8
	internal TouchScreenKeyboardType m_KeyboardType; //Field offset: 0x500
	private bool m_HideMobileInput; //Field offset: 0x504
	private bool m_IsReadOnly; //Field offset: 0x505
	private int m_MaxLength; //Field offset: 0x508
	private string m_PlaceholderText; //Field offset: 0x510
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; //Field offset: 0x518
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Char, Boolean> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; //Field offset: 0x520
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Boolean> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; //Field offset: 0x528
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; //Field offset: 0x530
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; //Field offset: 0x538
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; //Field offset: 0x540
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action <OnPlaceholderChanged>k__BackingField; //Field offset: 0x548
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<String> <UnityEngine.UIElements.ITextEdition.GetDefaultValueType>k__BackingField; //Field offset: 0x550
	private string m_RenderedText; //Field offset: 0x558
	private string m_OriginalText; //Field offset: 0x560
	private char m_MaskChar; //Field offset: 0x568
	private bool m_IsPassword; //Field offset: 0x56A
	private bool m_HidePlaceholderTextOnFocus; //Field offset: 0x56B
	private bool m_AutoCorrection; //Field offset: 0x56C
	private TextSelectingManipulator m_SelectingManipulator; //Field offset: 0x570
	private bool m_IsSelectable; //Field offset: 0x578
	private bool m_DoubleClickSelectsWord; //Field offset: 0x579
	private bool m_TripleClickSelectsLine; //Field offset: 0x57A
	private bool m_SelectAllOnFocus; //Field offset: 0x57B
	private bool m_SelectAllOnMouseUp; //Field offset: 0x57C
	private Color m_SelectionColor; //Field offset: 0x580
	private Color m_CursorColor; //Field offset: 0x590
	private float m_CursorWidth; //Field offset: 0x5A0

	[CreateProperty]
	private bool autoCorrection
	{
		private get { } //Length: 72
		private set { } //Length: 88
	}

	internal Color cursorColor
	{
		internal get { } //Length: 14
		internal set { } //Length: 124
	}

	[CreateProperty]
	private int cursorIndex
	{
		private get { } //Length: 72
		private set { } //Length: 86
	}

	[CreateProperty(ReadOnly = True)]
	private Vector2 cursorPosition
	{
		private get { } //Length: 72
	}

	[CreateProperty]
	public bool displayTooltipWhenElided
	{
		 get { } //Length: 8
		 set { } //Length: 140
	}

	[CreateProperty]
	internal bool doubleClickSelectsWord
	{
		internal get { } //Length: 72
		internal set { } //Length: 88
	}

	internal TextEditingManipulator editingManipulator
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	internal ITextEdition edition
	{
		internal get { } //Length: 4
	}

	private char effectiveMaskChar
	{
		private get { } //Length: 92
	}

	[CreateProperty]
	public bool emojiFallbackSupport
	{
		 get { } //Length: 8
		 set { } //Length: 137
	}

	[CreateProperty]
	public bool enableRichText
	{
		 get { } //Length: 8
		 set { } //Length: 137
	}

	internal bool hasFocus
	{
		internal get { } //Length: 114
	}

	[CreateProperty]
	private bool hideMobileInput
	{
		private get { } //Length: 72
		private set { } //Length: 88
	}

	[CreateProperty(ReadOnly = True)]
	public private bool isElided
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[CreateProperty]
	private bool isPassword
	{
		private get { } //Length: 72
		private set { } //Length: 88
	}

	[CreateProperty]
	private bool isReadOnly
	{
		private get { } //Length: 72
		private set { } //Length: 88
	}

	[CreateProperty]
	internal bool isSelectable
	{
		internal get { } //Length: 69
		internal set { } //Length: 88
	}

	[CreateProperty]
	private TouchScreenKeyboardType keyboardType
	{
		private get { } //Length: 72
		private set { } //Length: 86
	}

	[CreateProperty]
	private char maskChar
	{
		private get { } //Length: 187
		private set { } //Length: 177
	}

	[CreateProperty]
	private int maxLength
	{
		private get { } //Length: 72
		private set { } //Length: 86
	}

	internal Action OnPlaceholderChanged
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal string originalText
	{
		internal get { } //Length: 8
	}

	[CreateProperty]
	public bool parseEscapeSequences
	{
		 get { } //Length: 8
		 set { } //Length: 137
	}

	internal RenderedText renderedText
	{
		internal get { } //Length: 792
	}

	[CreateProperty]
	private bool selectAllOnFocus
	{
		private get { } //Length: 72
		private set { } //Length: 88
	}

	[CreateProperty]
	private bool selectAllOnMouseUp
	{
		private get { } //Length: 72
		private set { } //Length: 88
	}

	[CreateProperty]
	private int selectIndex
	{
		private get { } //Length: 72
		private set { } //Length: 86
	}

	internal TextSelectingManipulator selectingManipulator
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
		internal get { } //Length: 104
	}

	[CreateProperty(ReadOnly = True)]
	public ITextSelection selection
	{
		 get { } //Length: 4
	}

	internal Color selectionColor
	{
		internal get { } //Length: 14
		internal set { } //Length: 124
	}

	internal bool showPlaceholderText
	{
		internal get { } //Length: 263
	}

	[CreateProperty]
	public override string text
	{
		 get { } //Length: 59
		 set { } //Length: 77
	}

	[CreateProperty]
	internal bool tripleClickSelectsLine
	{
		internal get { } //Length: 72
		internal set { } //Length: 88
	}

	internal UITKTextHandle uitkTextHandle
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.value
	{
		private get { } //Length: 30
		private set { } //Length: 494
	}

	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.AcceptCharacter
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private override bool UnityEngine.UIElements.ITextEdition.autoCorrection
	{
		private get { } //Length: 8
		private set { } //Length: 127
	}

	private override Func<String> UnityEngine.UIElements.ITextEdition.GetDefaultValueType
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private override bool UnityEngine.UIElements.ITextEdition.hideMobileInput
	{
		private get { } //Length: 49
		private set { } //Length: 137
	}

	private override bool UnityEngine.UIElements.ITextEdition.hidePlaceholderOnFocus
	{
		private get { } //Length: 8
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.ITextEdition.isDelayed
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private override bool UnityEngine.UIElements.ITextEdition.isPassword
	{
		private get { } //Length: 8
		private set { } //Length: 143
	}

	private override bool UnityEngine.UIElements.ITextEdition.isReadOnly
	{
		private get { } //Length: 40
		private set { } //Length: 244
	}

	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.keyboardType
	{
		private get { } //Length: 7
		private set { } //Length: 124
	}

	private override char UnityEngine.UIElements.ITextEdition.maskChar
	{
		private get { } //Length: 8
		private set { } //Length: 179
	}

	private override int UnityEngine.UIElements.ITextEdition.maxLength
	{
		private get { } //Length: 7
		private set { } //Length: 208
	}

	private override Action UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private override bool UnityEngine.UIElements.ITextEdition.multiline
	{
		private get { } //Length: 8
		private set { } //Length: 125
	}

	private override string UnityEngine.UIElements.ITextEdition.placeholder
	{
		private get { } //Length: 8
		private set { } //Length: 434
	}

	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.UpdateScrollOffset
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateTextFromValue
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private override Action UnityEngine.UIElements.ITextEdition.UpdateValueFromText
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private override int UnityEngine.UIElements.ITextSelection.cursorIndex
	{
		private get { } //Length: 109
		private set { } //Length: 241
	}

	private override Vector2 UnityEngine.UIElements.ITextSelection.cursorPosition
	{
		private get { } //Length: 206
	}

	private override float UnityEngine.UIElements.ITextSelection.cursorWidth
	{
		private get { } //Length: 9
	}

	private override bool UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord
	{
		private get { } //Length: 8
		private set { } //Length: 127
	}

	private override bool UnityEngine.UIElements.ITextSelection.isSelectable
	{
		private get { } //Length: 57
		private set { } //Length: 186
	}

	private override float UnityEngine.UIElements.ITextSelection.lineHeightAtCursorPosition
	{
		private get { } //Length: 130
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnFocus
	{
		private get { } //Length: 8
		private set { } //Length: 127
	}

	private override bool UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp
	{
		private get { } //Length: 8
		private set { } //Length: 127
	}

	private override int UnityEngine.UIElements.ITextSelection.selectIndex
	{
		private get { } //Length: 109
		private set { } //Length: 241
	}

	private override bool UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine
	{
		private get { } //Length: 8
		private set { } //Length: 127
	}

	[CreateProperty]
	private string value
	{
		private get { } //Length: 59
		private set { } //Length: 77
	}

	private static TextElement() { }

	public TextElement() { }

	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	private void Copy(DropdownMenuAction a) { }

	private Status CopyActionStatus(DropdownMenuAction a) { }

	private void Cut(DropdownMenuAction a) { }

	private Status CutActionStatus(DropdownMenuAction a) { }

	protected private virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	internal void DrawCaret(MeshGenerationContext mgc) { }

	private void DrawHighlighting(MeshGenerationContext mgc) { }

	private void DrawNativeHighlighting(MeshGenerationContext mgc) { }

	private void EditionHandleEvent(EventBase evt) { }

	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	private bool get_autoCorrection() { }

	internal Color get_cursorColor() { }

	private int get_cursorIndex() { }

	private Vector2 get_cursorPosition() { }

	public bool get_displayTooltipWhenElided() { }

	internal bool get_doubleClickSelectsWord() { }

	[CompilerGenerated]
	internal TextEditingManipulator get_editingManipulator() { }

	internal ITextEdition get_edition() { }

	private char get_effectiveMaskChar() { }

	public bool get_emojiFallbackSupport() { }

	public bool get_enableRichText() { }

	internal bool get_hasFocus() { }

	private bool get_hideMobileInput() { }

	[CompilerGenerated]
	public bool get_isElided() { }

	private bool get_isPassword() { }

	private bool get_isReadOnly() { }

	internal bool get_isSelectable() { }

	private TouchScreenKeyboardType get_keyboardType() { }

	private char get_maskChar() { }

	private int get_maxLength() { }

	[CompilerGenerated]
	internal Action get_OnPlaceholderChanged() { }

	internal string get_originalText() { }

	public bool get_parseEscapeSequences() { }

	internal RenderedText get_renderedText() { }

	private bool get_selectAllOnFocus() { }

	private bool get_selectAllOnMouseUp() { }

	private int get_selectIndex() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal TextSelectingManipulator get_selectingManipulator() { }

	public ITextSelection get_selection() { }

	internal Color get_selectionColor() { }

	internal bool get_showPlaceholderText() { }

	public override string get_text() { }

	internal bool get_tripleClickSelectsLine() { }

	[CompilerGenerated]
	internal UITKTextHandle get_uitkTextHandle() { }

	private string get_value() { }

	private string GetDefaultValueType() { }

	private int GetLastCharacterAt(int lineIndex) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(ContextualMenuPopulateEvent), typeof(KeyDownEvent), typeof(KeyUpEvent), typeof(ValidateCommandEvent), typeof(ExecuteCommandEvent), typeof(FocusEvent), typeof(BlurEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(PointerDownEvent), typeof(PointerUpEvent), typeof(PointerMoveEvent), typeof(NavigationMoveEvent), typeof(NavigationSubmitEvent), typeof(NavigationCancelEvent), typeof(IMEEvent), typeof(GeometryChangedEvent), typeof(AttachToPanelEvent), typeof(DetachFromPanelEvent)}])]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	private void OnDetachFromPanel(DetachFromPanelEvent detachEvent) { }

	internal void OnGenerateTextOver(MeshGenerationContext mgc) { }

	internal void OnGenerateTextOverNative(MeshGenerationContext mgc) { }

	internal static void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	private void OnGeometryChanged(GeometryChangedEvent e) { }

	private void Paste(DropdownMenuAction a) { }

	private Status PasteActionStatus(DropdownMenuAction a) { }

	private void ProcessMenuCommand(string command) { }

	private void set_autoCorrection(bool value) { }

	internal void set_cursorColor(Color value) { }

	private void set_cursorIndex(int value) { }

	public void set_displayTooltipWhenElided(bool value) { }

	internal void set_doubleClickSelectsWord(bool value) { }

	[CompilerGenerated]
	private void set_editingManipulator(TextEditingManipulator value) { }

	public void set_emojiFallbackSupport(bool value) { }

	public void set_enableRichText(bool value) { }

	private void set_hideMobileInput(bool value) { }

	[CompilerGenerated]
	private void set_isElided(bool value) { }

	private void set_isPassword(bool value) { }

	private void set_isReadOnly(bool value) { }

	internal void set_isSelectable(bool value) { }

	private void set_keyboardType(TouchScreenKeyboardType value) { }

	private void set_maskChar(char value) { }

	private void set_maxLength(int value) { }

	[CompilerGenerated]
	internal void set_OnPlaceholderChanged(Action value) { }

	public void set_parseEscapeSequences(bool value) { }

	private void set_selectAllOnFocus(bool value) { }

	private void set_selectAllOnMouseUp(bool value) { }

	private void set_selectIndex(int value) { }

	internal void set_selectionColor(Color value) { }

	public override void set_text(string value) { }

	internal void set_tripleClickSelectsLine(bool value) { }

	[CompilerGenerated]
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	private void set_value(string value) { }

	private void SetRenderedText(string value) { }

	private bool ShouldElide() { }

	private override string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	private override void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	private override string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	[CompilerGenerated]
	private override Func<Char, Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	[CompilerGenerated]
	private override Func<String> UnityEngine.UIElements.ITextEdition.get_GetDefaultValueType() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_hidePlaceholderOnFocus() { }

	[CompilerGenerated]
	private override bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	private override TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	private override char UnityEngine.UIElements.ITextEdition.get_maskChar() { }

	private override int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	private override bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	private override string UnityEngine.UIElements.ITextEdition.get_placeholder() { }

	[CompilerGenerated]
	private override Action<Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	[CompilerGenerated]
	private override Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	private override void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	private override void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(Func<Char, Boolean> value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_GetDefaultValueType(Func<String> value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_hidePlaceholderOnFocus(bool value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_maskChar(char value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	private override void UnityEngine.UIElements.ITextEdition.set_placeholder(string value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(Action<Boolean> value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	[CompilerGenerated]
	private override void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	private override void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	private override int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	private override Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	private override float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	private override float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	private override int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	private override bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	private override bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	private override void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	private override void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	private override void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_doubleClickSelectsWord(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	private override void UnityEngine.UIElements.ITextSelection.set_tripleClickSelectsLine(bool value) { }

	private void UpdateTooltip() { }

	private void UpdateVisibleText() { }

}

