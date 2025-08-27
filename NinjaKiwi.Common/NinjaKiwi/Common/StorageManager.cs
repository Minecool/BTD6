namespace NinjaKiwi.Common;

public class StorageManager
{
	[CompilerGenerated]
	private struct <_GetAsync>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public StorageManager <>4__this; //Field offset: 0x0
		public string key; //Field offset: 0x0
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_GetBytesAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public StorageManager <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_WriteAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string key; //Field offset: 0x0
		public StorageManager <>4__this; //Field offset: 0x0
		public T obj; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_WriteBytesAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string key; //Field offset: 0x20
		public StorageManager <>4__this; //Field offset: 0x28
		public Byte[] bytes; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public StorageManager <>4__this; //Field offset: 0x0
		public string key; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBytesAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public StorageManager <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PendingWriteLock>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StorageManager <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PurgeAllFilesAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StorageManager <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public StorageManager <>4__this; //Field offset: 0x0
		public string key; //Field offset: 0x0
		public T obj; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteBytesAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StorageManager <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public Byte[] bytes; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected readonly string name; //Field offset: 0x10
	protected readonly IFileIO storageInterface; //Field offset: 0x18
	private readonly Func<Byte[], String> decode; //Field offset: 0x20
	private readonly Func<String, Byte[]> encode; //Field offset: 0x28
	private readonly IStorageManagerSerialiser serialiser; //Field offset: 0x30
	private readonly Dictionary<String, Task> writeLockTasks; //Field offset: 0x38
	private readonly Dictionary<String, Task> readTasks; //Field offset: 0x40

	[AsyncStateMachine(typeof(<_GetAsync>d__18`1))]
	private Task<T> _GetAsync(string key) { }

	[AsyncStateMachine(typeof(<_GetBytesAsync>d__20))]
	private Task<Byte[]> _GetBytesAsync(string key) { }

	[AsyncStateMachine(typeof(<_WriteAsync>d__12`1))]
	private Task _WriteAsync(T obj, string key) { }

	[AsyncStateMachine(typeof(<_WriteBytesAsync>d__14))]
	private Task _WriteBytesAsync(Byte[] bytes, string key) { }

	public StorageManager(string name, IFileIO storageInterface, Func<Byte[], String> decode = null, Func<String, Byte[]> encode = null, IStorageManagerSerialiser serialiser = null) { }

	[CompilerGenerated]
	private DateTime <Keys>b__8_0(string relPath) { }

	public void Delete(string key) { }

	private void EnsureDirectoryForFilePath(string filePath) { }

	public override T Get(string key) { }

	[AsyncStateMachine(typeof(<GetAsync>d__17`1))]
	public override Task<T> GetAsync(string key) { }

	public override Byte[] GetBytes(string key) { }

	[AsyncStateMachine(typeof(<GetBytesAsync>d__19))]
	public override Task<Byte[]> GetBytesAsync(string key) { }

	protected string GetFilePath(string key) { }

	public IEnumerable<String> Keys() { }

	[AsyncStateMachine(typeof(<PendingWriteLock>d__24))]
	private Task PendingWriteLock(string key) { }

	public void PurgeAllFiles() { }

	[AsyncStateMachine(typeof(<PurgeAllFilesAsync>d__23))]
	public Task PurgeAllFilesAsync() { }

	public override void Write(T obj, string key) { }

	[AsyncStateMachine(typeof(<WriteAsync>d__11`1))]
	public override Task WriteAsync(T obj, string key) { }

	public override void WriteBytes(Byte[] bytes, string key) { }

	[AsyncStateMachine(typeof(<WriteBytesAsync>d__13))]
	public override Task WriteBytesAsync(Byte[] bytes, string key) { }

}

