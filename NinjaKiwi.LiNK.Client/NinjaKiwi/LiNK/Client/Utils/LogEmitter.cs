namespace NinjaKiwi.LiNK.Client.Utils;

public interface LogEmitter
{

	public event Action<String> LogEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public LogLevel Level
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	[CompilerGenerated]
	public void add_LogEvent(Action<String> value) { }

	public LogLevel get_Level() { }

	[CompilerGenerated]
	public void remove_LogEvent(Action<String> value) { }

	public void set_Level(LogLevel value) { }

}

