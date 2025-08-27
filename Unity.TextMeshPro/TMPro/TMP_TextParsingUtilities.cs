namespace TMPro;

public class TMP_TextParsingUtilities
{
	private static readonly TMP_TextParsingUtilities s_Instance; //Field offset: 0x0
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; //Field offset: 0x0
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; //Field offset: 0x0
	private static readonly HashSet<UInt32> k_EmojiLookup; //Field offset: 0x8
	private static readonly HashSet<UInt32> k_EmojiPresentationFormLookup; //Field offset: 0x10

	public static TMP_TextParsingUtilities instance
	{
		 get { } //Length: 78
	}

	private static TMP_TextParsingUtilities() { }

	public TMP_TextParsingUtilities() { }

	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	public static TMP_TextParsingUtilities get_instance() { }

	public static int GetHashCode(string s) { }

	public static int GetHashCodeCaseSensitive(string s) { }

	internal static bool IsBaseGlyph(uint c) { }

	internal static bool IsCJK(uint c) { }

	internal static bool IsDiacriticalMark(uint c) { }

	internal static bool IsEmoji(uint c) { }

	internal static bool IsEmojiPresentationForm(uint c) { }

	internal static bool IsHangul(uint c) { }

	public static bool IsHighSurrogate(uint c) { }

	public static bool IsLowSurrogate(uint c) { }

	public static char ToLowerASCIIFast(char c) { }

	public static uint ToLowerASCIIFast(uint c) { }

	public static char ToUpperASCIIFast(char c) { }

	public static uint ToUpperASCIIFast(uint c) { }

}

