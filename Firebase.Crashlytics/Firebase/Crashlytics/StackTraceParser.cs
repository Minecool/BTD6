namespace Firebase.Crashlytics;

internal class StackTraceParser
{
	private static readonly string FrameArgsRegex; //Field offset: 0x0
	private static readonly string FrameRegexWithoutFileInfo; //Field offset: 0x8
	private static readonly string FrameRegexWithFileInfo; //Field offset: 0x10
	private static readonly string MonoFilenameUnknownString; //Field offset: 0x18
	private static readonly String[] StringDelimiters; //Field offset: 0x20

	private static StackTraceParser() { }

	private static Dictionary<String, String> ParseFrameString(string regex, string frameString) { }

	public static Dictionary<String, String>[] ParseStackTraceString(string stackTrace) { }

}

