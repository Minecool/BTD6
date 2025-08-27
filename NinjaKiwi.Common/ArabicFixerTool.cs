//Type is in global namespace

internal class ArabicFixerTool
{
	[CompilerGenerated]
	private struct <>c__DisplayClass4_0
	{
		public int lastSplitIndex; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass6_0
	{
		public List<Char> numberList; //Field offset: 0x0

	}

	internal static bool showTashkeel; //Field offset: 0x0
	internal static bool combineTashkeel; //Field offset: 0x1
	internal static bool useHinduNumbers; //Field offset: 0x2
	internal static StringBuilder internalStringBuilder; //Field offset: 0x8

	private static ArabicFixerTool() { }

	public ArabicFixerTool() { }

	[CompilerGenerated]
	internal static void <FixLine>g__AddNumber|6_0(char value, ref <>c__DisplayClass6_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static void <FixLine>g__AppendNumbers|6_1(ref <>c__DisplayClass6_0 unnamed_param_0) { }

	[CompilerGenerated]
	internal static void <RemoveTashkeel>g__IncrementSB|4_0(ref string str, int i, ref <>c__DisplayClass4_0 unnamed_param_2) { }

	internal static string FixLine(string str) { }

	internal static ushort HandleInduNumber(ushort letterOrigin, ushort letterFinal) { }

	internal static bool IsFinishingLetter(Char[] letters, int index) { }

	internal static bool IsIgnoredCharacter(char ch) { }

	internal static bool IsLeadingLetter(Char[] letters, int index) { }

	internal static bool IsMiddleLetter(Char[] letters, int index) { }

	internal static void RemoveTashkeel(ref string str, out List<TashkeelLocation>& tashkeelLocation) { }

	internal static void ReturnTashkeel(ref Char[] letters, List<TashkeelLocation> tashkeelLocation) { }

}

