//Type is in global namespace

public class UniWebViewLogger
{
	internal enum Level
	{
		Verbose = 0,
		Debug = 10,
		Info = 20,
		Critical = 80,
		Off = 99,
	}

	private static UniWebViewLogger instance; //Field offset: 0x0
	private Level level; //Field offset: 0x10

	public static UniWebViewLogger Instance
	{
		 get { } //Length: 126
	}

	public Level LogLevel
	{
		 get { } //Length: 94
		 set { } //Length: 242
	}

	private UniWebViewLogger(Level level) { }

	public void Critical(string message) { }

	public void Debug(string message) { }

	public static UniWebViewLogger get_Instance() { }

	public Level get_LogLevel() { }

	public void Info(string message) { }

	private void Log(Level targetLevel, string message) { }

	public void set_LogLevel(Level value) { }

	public void Verbose(string message) { }

}

