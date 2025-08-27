namespace UnityEngine;

[NativeHeader("IMGUIScriptingClasses.h")]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[RequiredByNativeCode]
public sealed class GUIStyle
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(GUIStyle guiStyle) { }

	}

	internal static bool showKeyboardFocus; //Field offset: 0x0
	private static GUIStyle s_None; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x10
	private GUIStyleState m_Normal; //Field offset: 0x18
	private GUIStyleState m_Hover; //Field offset: 0x20
	private GUIStyleState m_Active; //Field offset: 0x28
	private GUIStyleState m_Focused; //Field offset: 0x30
	private GUIStyleState m_OnNormal; //Field offset: 0x38
	private GUIStyleState m_OnHover; //Field offset: 0x40
	private GUIStyleState m_OnActive; //Field offset: 0x48
	private GUIStyleState m_OnFocused; //Field offset: 0x50
	private RectOffset m_Border; //Field offset: 0x58
	private RectOffset m_Padding; //Field offset: 0x60
	private RectOffset m_Margin; //Field offset: 0x68
	private RectOffset m_Overflow; //Field offset: 0x70
	private string m_Name; //Field offset: 0x78

	[NativeProperty("m_Alignment", False, TargetType::Field (1))]
	public TextAnchor alignment
	{
		 get { } //Length: 139
		 set { } //Length: 152
	}

	[NativeProperty("m_Clipping", False, TargetType::Field (1))]
	public TextClipping clipping
	{
		 get { } //Length: 139
	}

	[NativeProperty("m_ContentOffset", False, TargetType::Field (1))]
	public Vector2 contentOffset
	{
		 get { } //Length: 158
	}

	[NativeProperty("m_FixedHeight", False, TargetType::Field (1))]
	public float fixedHeight
	{
		 get { } //Length: 139
	}

	[NativeProperty("m_FixedWidth", False, TargetType::Field (1))]
	public float fixedWidth
	{
		 get { } //Length: 139
	}

	[NativeProperty("Font", False, TargetType::Function (0))]
	public Font font
	{
		 get { } //Length: 165
	}

	[NativeProperty("m_FontSize", False, TargetType::Field (1))]
	public int fontSize
	{
		 get { } //Length: 139
	}

	[NativeProperty("m_FontStyle", False, TargetType::Field (1))]
	public FontStyle fontStyle
	{
		 get { } //Length: 139
	}

	[NativeProperty("m_ImagePosition", False, TargetType::Field (1))]
	public ImagePosition imagePosition
	{
		 get { } //Length: 139
	}

	public bool isHeightDependantOnWidth
	{
		 get { } //Length: 398
	}

	public float lineHeight
	{
		 get { } //Length: 303
	}

	public RectOffset margin
	{
		 get { } //Length: 226
	}

	public string name
	{
		 get { } //Length: 35
		 set { } //Length: 12
	}

	public static GUIStyle none
	{
		 get { } //Length: 151
	}

	public GUIStyleState normal
	{
		 get { } //Length: 224
	}

	public RectOffset padding
	{
		 get { } //Length: 226
	}

	[NativeProperty("Name", False, TargetType::Function (0))]
	internal string rawName
	{
		internal get { } //Length: 277
		internal set { } //Length: 456
	}

	[NativeProperty("m_RichText", False, TargetType::Field (1))]
	public bool richText
	{
		 get { } //Length: 139
	}

	[NativeProperty("m_StretchHeight", False, TargetType::Field (1))]
	public bool stretchHeight
	{
		 get { } //Length: 139
		 set { } //Length: 155
	}

	[NativeProperty("m_StretchWidth", False, TargetType::Field (1))]
	public bool stretchWidth
	{
		 get { } //Length: 139
		 set { } //Length: 155
	}

	[NativeProperty("m_WordWrap", False, TargetType::Field (1))]
	public bool wordWrap
	{
		 get { } //Length: 139
	}

	private static GUIStyle() { }

	public GUIStyle() { }

	public float CalcHeight(GUIContent content, float width) { }

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID) { }

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[RequiredByNativeCode]
	internal static void EmptyManagedCache() { }

	protected virtual void Finalize() { }

	public TextAnchor get_alignment() { }

	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	public TextClipping get_clipping() { }

	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	public Vector2 get_contentOffset() { }

	private static void get_contentOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_fixedHeight() { }

	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	public float get_fixedWidth() { }

	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	public Font get_font() { }

	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	public int get_fontSize() { }

	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	public FontStyle get_fontStyle() { }

	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	public ImagePosition get_imagePosition() { }

	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	public bool get_isHeightDependantOnWidth() { }

	public float get_lineHeight() { }

	public RectOffset get_margin() { }

	public string get_name() { }

	public static GUIStyle get_none() { }

	public GUIStyleState get_normal() { }

	public RectOffset get_padding() { }

	internal string get_rawName() { }

	private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public bool get_richText() { }

	private static bool get_richText_Injected(IntPtr _unity_self) { }

	public bool get_stretchHeight() { }

	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	public bool get_stretchWidth() { }

	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	public bool get_wordWrap() { }

	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
	internal static Font GetDefaultFont() { }

	private static IntPtr GetDefaultFont_Injected() { }

	[RequiredByNativeCode]
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions) { }

	[RequiredByNativeCode]
	internal static void GetLineHeight(GUIStyle style, ref float lineHeight) { }

	[RequiredByNativeCode]
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId) { }

	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	private IntPtr GetRectOffsetPtr(int idx) { }

	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	private IntPtr GetStyleStatePtr(int idx) { }

	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = True)]
	private float Internal_CalcHeight(GUIContent content, float width) { }

	private static float Internal_CalcHeight_Injected(IntPtr _unity_self, GUIContent content, float width) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = True)]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	private static void Internal_CalcMinMaxWidth_Injected(IntPtr _unity_self, GUIContent content, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = True)]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	private static void Internal_CalcSizeWithConstraints_Injected(IntPtr _unity_self, GUIContent content, in Vector2 maxSize, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = True)]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	private static void Internal_Draw_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = True)]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	private static void Internal_Draw2_Injected(IntPtr _unity_self, in Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = True)]
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, in Vector2 textSize, out Vector2 ret) { }

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	internal static bool IsTooltipActive(string tooltip) { }

	private static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip) { }

	public void set_alignment(TextAnchor value) { }

	private static void set_alignment_Injected(IntPtr _unity_self, TextAnchor value) { }

	public void set_name(string value) { }

	internal void set_rawName(string value) { }

	private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_stretchHeight(bool value) { }

	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	public void set_stretchWidth(bool value) { }

	private static void set_stretchWidth_Injected(IntPtr _unity_self, bool value) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	internal static void SetDefaultFont(Font font) { }

	private static void SetDefaultFont_Injected(IntPtr font) { }

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	private static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, in Rect screenRect) { }

	public virtual string ToString() { }

}

