namespace System.IO;

public sealed class BufferedStream : Stream
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SemaphoreSlim> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal SemaphoreSlim <LazyEnsureAsyncActiveSemaphoreInitialized>b__10_0() { }

	}

	[CompilerGenerated]
	private struct <CopyToAsyncCore>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BufferedStream <>4__this; //Field offset: 0x20
		public Stream destination; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public int bufferSize; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DisposeAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BufferedStream <>4__this; //Field offset: 0x28
		private object <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FlushAsyncInternal>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BufferedStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private SemaphoreSlim <sem>5__2; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FlushWriteAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BufferedStream <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x30
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReadFromUnderlyingStreamAsync>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncValueTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public Task semaphoreLockTask; //Field offset: 0x28
		public BufferedStream <>4__this; //Field offset: 0x30
		public Memory<Byte> buffer; //Field offset: 0x38
		public int bytesAlreadySatisfied; //Field offset: 0x48
		public CancellationToken cancellationToken; //Field offset: 0x50
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x58
		private int <>7__wrap1; //Field offset: 0x68
		private ConfiguredValueTaskAwaiter<Int32> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteToUnderlyingStreamAsync>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task semaphoreLockTask; //Field offset: 0x20
		public BufferedStream <>4__this; //Field offset: 0x28
		public ReadOnlyMemory<Byte> buffer; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x48
		private ConfiguredValueTaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Stream _stream; //Field offset: 0x28
	private Byte[] _buffer; //Field offset: 0x30
	private readonly int _bufferSize; //Field offset: 0x38
	private int _readPos; //Field offset: 0x3C
	private int _readLen; //Field offset: 0x40
	private int _writePos; //Field offset: 0x44
	private Task<Int32> _lastSyncCompletedReadTask; //Field offset: 0x48
	private SemaphoreSlim _asyncActiveSemaphore; //Field offset: 0x50

	public virtual bool CanRead
	{
		 get { } //Length: 32
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 32
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 32
	}

	public virtual long Length
	{
		 get { } //Length: 202
	}

	public virtual long Position
	{
		 get { } //Length: 154
		 set { } //Length: 274
	}

	public BufferedStream(Stream stream, int bufferSize) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	private void ClearReadBufferBeforeWrite() { }

	public virtual void CopyTo(Stream destination, int bufferSize) { }

	public virtual Task CopyToAsync(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<CopyToAsyncCore>d__71))]
	private Task CopyToAsyncCore(Stream destination, int bufferSize, CancellationToken cancellationToken) { }

	protected virtual void Dispose(bool disposing) { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__34))]
	public virtual ValueTask DisposeAsync() { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	private void EnsureBufferAllocated() { }

	private void EnsureCanRead() { }

	private void EnsureCanSeek() { }

	private void EnsureCanWrite() { }

	private void EnsureNotClosed() { }

	private void EnsureShadowBufferAllocated() { }

	public virtual void Flush() { }

	public virtual Task FlushAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<FlushAsyncInternal>d__38))]
	private Task FlushAsyncInternal(CancellationToken cancellationToken) { }

	private void FlushRead() { }

	private void FlushWrite() { }

	[AsyncStateMachine(typeof(<FlushWriteAsync>d__42))]
	private Task FlushWriteAsync(CancellationToken cancellationToken) { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	private Task<Int32> LastSyncCompletedReadTask(int val) { }

	internal SemaphoreSlim LazyEnsureAsyncActiveSemaphoreInitialized() { }

	public virtual int Read(Span<Byte> destination) { }

	public virtual int Read(Byte[] array, int offset, int count) { }

	public virtual ValueTask<Int32> ReadAsync(Memory<Byte> buffer, CancellationToken cancellationToken = null) { }

	public virtual Task<Int32> ReadAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual int ReadByte() { }

	private int ReadByteSlow() { }

	private int ReadFromBuffer(Byte[] array, int offset, int count) { }

	private int ReadFromBuffer(Span<Byte> destination) { }

	private int ReadFromBuffer(Byte[] array, int offset, int count, out Exception error) { }

	[AsyncStateMachine(typeof(<ReadFromUnderlyingStreamAsync>d__51))]
	private ValueTask<Int32> ReadFromUnderlyingStreamAsync(Memory<Byte> buffer, CancellationToken cancellationToken, int bytesAlreadySatisfied, Task semaphoreLockTask) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(ReadOnlySpan<Byte> buffer) { }

	public virtual void Write(Byte[] array, int offset, int count) { }

	public virtual ValueTask WriteAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken = null) { }

	public virtual Task WriteAsync(Byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	public virtual void WriteByte(byte value) { }

	private int WriteToBuffer(ReadOnlySpan<Byte> buffer) { }

	private void WriteToBuffer(Byte[] array, ref int offset, ref int count) { }

	[AsyncStateMachine(typeof(<WriteToUnderlyingStreamAsync>d__63))]
	private Task WriteToUnderlyingStreamAsync(ReadOnlyMemory<Byte> buffer, CancellationToken cancellationToken, Task semaphoreLockTask) { }

}

