namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"}])]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"}])]
	internal static Func<Boolean> IsEditorTextRenderingModeBitmap; //Field offset: 0x0
	public const bool useMaxVisibleDescender = False; //Field offset: 0x0
	public const int firstVisibleCharacter = 0; //Field offset: 0x0
	public const int maxVisibleLines = 99999; //Field offset: 0x0
	public const int maxVisibleWords = 99999; //Field offset: 0x0
	public const int maxVisibleCharacters = 99999; //Field offset: 0x0
	public const float lineSpacingMax = 0; //Field offset: 0x0
	public const float lineSpacing = 0; //Field offset: 0x0
	public const bool tagNoParsing = False; //Field offset: 0x0
	public const float fontSizeMax = 0; //Field offset: 0x0
	public const float fontSizeMin = 0; //Field offset: 0x0
	public const bool autoSize = False; //Field offset: 0x0
	public const float charWidthMaxAdj = 0; //Field offset: 0x0
	public const float wordWrappingRatio = 0.4; //Field offset: 0x0
	internal static readonly List<OTL_FeatureTag> fontFeatures; //Field offset: 0x8
	private RenderedText m_RenderedText; //Field offset: 0x10
	private string m_CachedRenderedText; //Field offset: 0x30
	public Rect screenRect; //Field offset: 0x38
	public float pixelsPerPoint; //Field offset: 0x48
	public bool isEditorRenderingModeBitmap; //Field offset: 0x4C
	public FontAsset fontAsset; //Field offset: 0x50
	public FontStyles fontStyle; //Field offset: 0x58
	public TextSettings textSettings; //Field offset: 0x60
	public TextAlignment textAlignment; //Field offset: 0x68
	public TextOverflowMode overflowMode; //Field offset: 0x6C
	public Color color; //Field offset: 0x70
	public bool shouldConvertToLinearSpace; //Field offset: 0x80
	public float fontSize; //Field offset: 0x84
	public bool emojiFallbackSupport; //Field offset: 0x88
	public bool richText; //Field offset: 0x89
	public bool isRightToLeft; //Field offset: 0x8A
	public float extraPadding; //Field offset: 0x8C
	public bool parseControlCharacters; //Field offset: 0x90
	public bool isPlaceholder; //Field offset: 0x91
	public float characterSpacing; //Field offset: 0x94
	public float wordSpacing; //Field offset: 0x98
	public float paragraphSpacing; //Field offset: 0x9C
	public TextWrappingMode textWrappingMode; //Field offset: 0xA0
	public TextFontWeight fontWeight; //Field offset: 0xA4
	public bool isIMGUI; //Field offset: 0xA8

	public RenderedText renderedText
	{
		 get { } //Length: 19
		 set { } //Length: 24
	}

	public string text
	{
		 get { } //Length: 58
		 set { } //Length: 197
	}

	private static TextGenerationSettings() { }

	public TextGenerationSettings() { }

	public override bool Equals(TextGenerationSettings other) { }

	public virtual bool Equals(object obj) { }

	public RenderedText get_renderedText() { }

	public string get_text() { }

	public virtual int GetHashCode() { }

	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	public void set_renderedText(RenderedText value) { }

	public void set_text(string value) { }

	public virtual string ToString() { }

}

