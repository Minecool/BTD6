namespace Firebase.Crashlytics;

internal class LoggedException : Exception
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Name>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <CustomStackTrace>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Dictionary<String, String>[] <ParsedStackTrace>k__BackingField; //Field offset: 0xA0

	public private string CustomStackTrace
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private Dictionary<String, String>[] ParsedStackTrace
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public LoggedException(string name, string message, string stackTrace) { }

	public static LoggedException FromException(Exception exception) { }

	[CompilerGenerated]
	public string get_CustomStackTrace() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public Dictionary<String, String>[] get_ParsedStackTrace() { }

	[CompilerGenerated]
	private void set_CustomStackTrace(string value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	[CompilerGenerated]
	private void set_ParsedStackTrace(Dictionary<String, String>[] value) { }

}

