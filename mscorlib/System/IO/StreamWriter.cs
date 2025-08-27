namespace System.IO;

public class StreamWriter : TextWriter
{
	[CompilerGenerated]
	private struct <DisposeAsyncCore>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StreamWriter <>4__this; //Field offset: 0x28
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FlushAsyncInternal>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool haveWrittenPreamble; //Field offset: 0x20
		public StreamWriter _this; //Field offset: 0x28
		public Encoding encoding; //Field offset: 0x30
		public Stream stream; //Field offset: 0x38
		public CancellationToken cancellationToken; //Field offset: 0x40
		public Encoder encoder; //Field offset: 0x48
		public Char[] charBuffer; //Field offset: 0x50
		public int charPos; //Field offset: 0x58
		public Byte[] byteBuffer; //Field offset: 0x60
		public bool flushEncoder; //Field offset: 0x68
		public bool flushStream; //Field offset: 0x69
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x70
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAsyncInternal>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string value; //Field offset: 0x20
		public int charPos; //Field offset: 0x28
		public int charLen; //Field offset: 0x2C
		public StreamWriter _this; //Field offset: 0x30
		public Char[] charBuffer; //Field offset: 0x38
		public bool appendNewLine; //Field offset: 0x40
		public Char[] coreNewLine; //Field offset: 0x48
		public bool autoFlush; //Field offset: 0x50
		private int <count>5__2; //Field offset: 0x54
		private int <index>5__3; //Field offset: 0x58
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x60
		private int <i>5__4; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly StreamWriter Null; //Field offset: 0x0
	private Stream _stream; //Field offset: 0x30
	private Encoding _encoding; //Field offset: 0x38
	private Encoder _encoder; //Field offset: 0x40
	private Byte[] _byteBuffer; //Field offset: 0x48
	private Char[] _charBuffer; //Field offset: 0x50
	private int _charPos; //Field offset: 0x58
	private int _charLen; //Field offset: 0x5C
	private bool _autoFlush; //Field offset: 0x60
	private bool _haveWrittenPreamble; //Field offset: 0x61
	private bool _closable; //Field offset: 0x62
	private Task _asyncWriteTask; //Field offset: 0x68

	public override bool AutoFlush
	{
		 set { } //Length: 125
	}

	public override Stream BaseStream
	{
		 get { } //Length: 5
	}

	private int CharPos_Prop
	{
		private set { } //Length: 4
	}

	public virtual Encoding Encoding
	{
		 get { } //Length: 5
	}

	private bool HaveWrittenPreamble_Prop
	{
		private set { } //Length: 4
	}

	internal bool LeaveOpen
	{
		internal get { } //Length: 8
	}

	private static Encoding UTF8NoBOM
	{
		private get { } //Length: 64
	}

	private static StreamWriter() { }

	public StreamWriter(string path, bool append, Encoding encoding, int bufferSize) { }

	public StreamWriter(string path, bool append) { }

	internal StreamWriter() { }

	public StreamWriter(Stream stream) { }

	public StreamWriter(Stream stream, Encoding encoding) { }

	public StreamWriter(Stream stream, Encoding encoding, int bufferSize) { }

	public StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	public StreamWriter(string path) { }

	private void CheckAsyncTaskInProgress() { }

	public virtual void Close() { }

	private void CloseStreamFromDispose(bool disposing) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual ValueTask DisposeAsync() { }

	[AsyncStateMachine(typeof(<DisposeAsyncCore>d__33))]
	private ValueTask DisposeAsyncCore() { }

	private void Flush(bool flushStream, bool flushEncoder) { }

	public virtual void Flush() { }

	public virtual Task FlushAsync() { }

	private Task FlushAsyncInternal(bool flushStream, bool flushEncoder, Char[] sCharBuffer, int sCharPos, CancellationToken cancellationToken = null) { }

	[AsyncStateMachine(typeof(<FlushAsyncInternal>d__74))]
	private static Task FlushAsyncInternal(StreamWriter _this, bool flushStream, bool flushEncoder, Char[] charBuffer, int charPos, bool haveWrittenPreamble, Encoding encoding, Encoder encoder, Byte[] byteBuffer, Stream stream, CancellationToken cancellationToken) { }

	public override Stream get_BaseStream() { }

	public virtual Encoding get_Encoding() { }

	internal bool get_LeaveOpen() { }

	private static Encoding get_UTF8NoBOM() { }

	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	public override void set_AutoFlush(bool value) { }

	private void set_CharPos_Prop(int value) { }

	private void set_HaveWrittenPreamble_Prop(bool value) { }

	private static void ThrowAsyncIOInProgress() { }

	public virtual void Write(string value) { }

	public virtual void Write(Char[] buffer, int index, int count) { }

	public virtual void Write(Char[] buffer) { }

	public virtual void Write(char value) { }

	public virtual Task WriteAsync(string value) { }

	[AsyncStateMachine(typeof(<WriteAsyncInternal>d__59))]
	private static Task WriteAsyncInternal(StreamWriter _this, string value, Char[] charBuffer, int charPos, int charLen, Char[] coreNewLine, bool autoFlush, bool appendNewLine) { }

	public virtual void WriteLine(string value) { }

	private void WriteSpan(ReadOnlySpan<Char> buffer, bool appendNewLine) { }

}

