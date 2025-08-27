namespace NinjaKiwi.LiNK.Client.Caching;

public class TaskCache : ICache
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string keyMatch; //Field offset: 0x10
		public string keyNotMatch; //Field offset: 0x18
		public Func<KeyValuePair`2<String, Task`1<CacheEntry>>, Boolean> <>9__0; //Field offset: 0x20
		public Func<KeyValuePair`2<String, Task`1<CacheEntry>>, Boolean> <>9__1; //Field offset: 0x28

		public <>c__DisplayClass7_0() { }

		internal bool <Delete>b__0(KeyValuePair<String, Task`1<CacheEntry>> x) { }

		internal bool <Delete>b__1(KeyValuePair<String, Task`1<CacheEntry>> x) { }

	}

	[CompilerGenerated]
	private struct <Get>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public TaskCache <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public float ttlMinutes; //Field offset: 0x30
		public IDataLoader dataLoader; //Field offset: 0x38
		private TaskAwaiter<CacheEntry> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Get>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public TaskCache <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public float ttlMinutes; //Field offset: 0x30
		public IDataLoader dataLoader; //Field offset: 0x38
		public bool skipExpirationCheck; //Field offset: 0x40
		private TaskAwaiter<CacheEntry> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCacheEntry>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CacheEntry> <>t__builder; //Field offset: 0x8
		public TaskCache <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public IDataLoader dataLoader; //Field offset: 0x30
		public float ttlMinutes; //Field offset: 0x38
		public bool skipExpirationCheck; //Field offset: 0x3C
		private TaskAwaiter<CacheEntry> <>u__1; //Field offset: 0x40
		private DataAndEtag <existingExpiredData>5__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCacheEntry>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CacheEntry> <>t__builder; //Field offset: 0x8
		public TaskCache <>4__this; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public float ttlMinutes; //Field offset: 0x30
		public IDataLoader dataLoader; //Field offset: 0x38
		private TaskAwaiter<CacheEntry> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Dictionary<String, Task`1<CacheEntry>> existingTasks; //Field offset: 0x10

	public TaskCache() { }

	public override void Clear() { }

	public override bool Delete(string key) { }

	public void Delete(string keyMatch, string keyNotMatch) { }

	[AsyncStateMachine(typeof(<Get>d__3))]
	public override Task<Byte[]> Get(string key, float ttlMinutes, IDataLoader dataLoader) { }

	[AsyncStateMachine(typeof(<Get>d__4))]
	public Task<Byte[]> Get(string key, float ttlMinutes, IDataLoader dataLoader, bool skipExpirationCheck) { }

	[AsyncStateMachine(typeof(<GetCacheEntry>d__1))]
	public Task<CacheEntry> GetCacheEntry(string key, float ttlMinutes, IDataLoader dataLoader, bool skipExpirationCheck) { }

	[AsyncStateMachine(typeof(<GetCacheEntry>d__2))]
	public override Task<CacheEntry> GetCacheEntry(string key, float ttlMinutes, IDataLoader dataLoader) { }

}

