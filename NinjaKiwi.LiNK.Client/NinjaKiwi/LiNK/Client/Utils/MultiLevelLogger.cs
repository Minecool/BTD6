namespace NinjaKiwi.LiNK.Client.Utils;

public class MultiLevelLogger : LogConsumer
{
	private readonly Logger trace; //Field offset: 0x10
	private readonly Logger debug; //Field offset: 0x18
	private readonly Logger info; //Field offset: 0x20

	public event Action<String> DebugEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action<String> InfoEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public event Action<String> TraceEvent
	{
		 add { } //Length: 30
		 remove { } //Length: 30
	}

	public MultiLevelLogger() { }

	public void add_DebugEvent(Action<String> value) { }

	public void add_InfoEvent(Action<String> value) { }

	public void add_TraceEvent(Action<String> value) { }

	public override void Log(LogEntry logEntry) { }

	public override void Log(LogLevel level, string message) { }

	public override void Log(LogLevel level, string message, object arg0) { }

	public override void Log(LogLevel level, string message, object arg0, object arg1) { }

	public override void Log(LogLevel level, string message, object arg0, object arg1, object arg2) { }

	public void remove_DebugEvent(Action<String> value) { }

	public void remove_InfoEvent(Action<String> value) { }

	public void remove_TraceEvent(Action<String> value) { }

}

