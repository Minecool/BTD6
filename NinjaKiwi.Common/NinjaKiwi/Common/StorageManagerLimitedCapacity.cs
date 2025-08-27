namespace NinjaKiwi.Common;

public class StorageManagerLimitedCapacity : StorageManager
{
	[CompilerGenerated]
	private struct <GetAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public StorageManagerLimitedCapacity <>4__this; //Field offset: 0x0
		public string key; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBytesAsync>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public StorageManagerLimitedCapacity <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public StorageManagerLimitedCapacity <>4__this; //Field offset: 0x0
		public T obj; //Field offset: 0x0
		public string key; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WriteBytesAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StorageManagerLimitedCapacity <>4__this; //Field offset: 0x20
		public Byte[] bytes; //Field offset: 0x28
		public string key; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly long maximumBytes; //Field offset: 0x48
	private readonly int maximumFileCount; //Field offset: 0x50

	private bool HasLimits
	{
		private get { } //Length: 18
	}

	public static StorageSize UnlimitedStorageSize
	{
		 get { } //Length: 15
	}

	public StorageManagerLimitedCapacity(string name, IFileIO storageInterface, StorageSize maximumStorageSize, int maximumFileCount, Func<Byte[], String> decode = null, Func<String, Byte[]> encode = null, IStorageManagerSerialiser serialiser = null) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(T obj, string key) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__1(Byte[] bytes, string key) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task<T> <>n__2(string key) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task<Byte[]> <>n__3(string key) { }

	public virtual T Get(string key) { }

	private bool get_HasLimits() { }

	public static StorageSize get_UnlimitedStorageSize() { }

	[AsyncStateMachine(typeof(<GetAsync>d__13`1))]
	public virtual Task<T> GetAsync(string key) { }

	public virtual Byte[] GetBytes(string key) { }

	[AsyncStateMachine(typeof(<GetBytesAsync>d__14))]
	public virtual Task<Byte[]> GetBytesAsync(string key) { }

	private void KeepStorageFolderWithinLimits() { }

	private void UpdateLastAccessTime(string key) { }

	public virtual void Write(T obj, string key) { }

	[AsyncStateMachine(typeof(<WriteAsync>d__9`1))]
	public virtual Task WriteAsync(T obj, string key) { }

	public virtual void WriteBytes(Byte[] bytes, string key) { }

	[AsyncStateMachine(typeof(<WriteBytesAsync>d__10))]
	public virtual Task WriteBytesAsync(Byte[] bytes, string key) { }

}

