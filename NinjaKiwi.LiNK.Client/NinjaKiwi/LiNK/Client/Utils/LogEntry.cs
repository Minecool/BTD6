namespace NinjaKiwi.LiNK.Client.Utils;

[IsReadOnly]
public struct LogEntry
{
	public readonly LogLevel level; //Field offset: 0x0
	public readonly string message; //Field offset: 0x8
	public readonly DateTime created; //Field offset: 0x10

	public LogEntry(LogLevel level, string message) { }

}

