namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
public struct Unicode
{
	[GenerateTestsForBurstCompatibility]
	internal struct Rune
	{
		public int value; //Field offset: 0x0

		[ExcludeFromBurstCompatTesting("Takes managed object")]
		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}


	public static Rune ReplacementCharacter
	{
		 get { } //Length: 6
	}

	public static Rune get_ReplacementCharacter() { }

	public static bool IsValidCodePoint(int codepoint) { }

	public static bool NotTrailer(byte b) { }

	public static ConversionError UcsToUtf16(Char* buffer, ref int index, int capacity, Rune rune) { }

	public static ConversionError Utf8ToUcs(out Rune rune, Byte* buffer, ref int index, int capacity) { }

	public static ConversionError Utf8ToUtf16(Byte* utf8Buffer, int utf8Length, Char* utf16Buffer, out int utf16Length, int utf16Capacity) { }

}

