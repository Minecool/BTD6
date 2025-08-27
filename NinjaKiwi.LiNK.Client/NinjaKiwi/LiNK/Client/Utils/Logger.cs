namespace NinjaKiwi.LiNK.Client.Utils;

public class Logger : LogEmitter, LogConsumer
{
	[CompilerGenerated]
	private LogLevel <Level>k__BackingField; //Field offset: 0x10
	private readonly int maxEntries; //Field offset: 0x14
	private readonly Queue<LogEntry> entries; //Field offset: 0x18
	private LogConsumer _parent; //Field offset: 0x20
	[CompilerGenerated]
	private Action<String> _logEvent; //Field offset: 0x28

	private event Action<String> _logEvent
	{
		[CompilerGenerated]
		private add { } //Length: 172
		[CompilerGenerated]
		private remove { } //Length: 172
	}

	public override event Action<String> LogEvent
	{
		 add { } //Length: 190
		 remove { } //Length: 172
	}

	public override LogLevel Level
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private LogConsumer Parent
	{
		private get { } //Length: 5
		 set { } //Length: 11
	}

	public Logger() { }

	public Logger(int maxMessageStorageLength) { }

	[CompilerGenerated]
	private void add__logEvent(Action<String> value) { }

	public override void add_LogEvent(Action<String> value) { }

	private void Enqueue(LogLevel level, string message) { }

	[CompilerGenerated]
	public override LogLevel get_Level() { }

	private LogConsumer get_Parent() { }

	public override void Log(LogEntry logEntry) { }

	public override void Log(LogLevel level, string message) { }

	public override void Log(LogLevel level, string message, object arg0) { }

	public override void Log(LogLevel level, string message, object arg0, object arg1) { }

	public override void Log(LogLevel level, string message, object arg0, object arg1, object arg2) { }

	[CompilerGenerated]
	private void remove__logEvent(Action<String> value) { }

	public override void remove_LogEvent(Action<String> value) { }

	[CompilerGenerated]
	public override void set_Level(LogLevel value) { }

	public void set_Parent(LogConsumer value) { }

	private void TryEmit() { }

}

