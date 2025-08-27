namespace NinjaKiwi.LiNK.Client.Utils;

public interface LogConsumer
{

	public void Log(LogEntry logEntry) { }

	public void Log(LogLevel level, string message) { }

	public void Log(LogLevel level, string message, object arg0) { }

	public void Log(LogLevel level, string message, object arg0, object arg1) { }

	public void Log(LogLevel level, string message, object arg0, object arg1, object arg2) { }

}

