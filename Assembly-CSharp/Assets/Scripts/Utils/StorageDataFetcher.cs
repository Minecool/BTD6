namespace Assets.Scripts.Utils;

public static class StorageDataFetcher
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ObjectCache, String> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetQueryFiles>b__8_0(ObjectCache cacheObject) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ObjectCache cacheObject; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <UpdateCache>b__0(StorageFile x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public ObjectCache cacheObject; //Field offset: 0x10

		public <>c__DisplayClass6_1() { }

		internal bool <UpdateCache>b__1(StorageFile x) { }

	}

	[CompilerGenerated]
	private struct <Get>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string dataFolder; //Field offset: 0x0
		public string fileName; //Field offset: 0x0
		private ObjectCache <existingCache>5__2; //Field offset: 0x0
		private float <waitStart>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private YieldAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateCache>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool throwExceptions; //Field offset: 0x20
		public IEnumerable<StorageFile> storageFiles; //Field offset: 0x28
		public string fileSystemCacheKey; //Field offset: 0x30
		private List<ObjectCache> <cacheObjectsToDownload>5__2; //Field offset: 0x38
		private bool <isSingleFileDownload>5__3; //Field offset: 0x40
		private string <absoluteUri>5__4; //Field offset: 0x48
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly List<ObjectCache> cache; //Field offset: 0x0
	private static readonly TimeSpan downloadTimeout; //Field offset: 0x8

	private static TimeSpan CacheLife
	{
		private get { } //Length: 147
	}

	private static StorageDataFetcher() { }

	[AsyncStateMachine(typeof(<Get>d__4`1))]
	public static Task<T> Get(string dataFolder, string fileName) { }

	private static TimeSpan get_CacheLife() { }

	private static List<ObjectCache> GetCacheObjectsToDownload(IEnumerable<StorageFile> storageFiles) { }

	private static string GetQueryFiles(List<ObjectCache> cacheObjects) { }

	private static void Log(string message) { }

	public static Task UpdateCache(string dataFolder, string fileName, Type dataType, bool throwExceptions = false) { }

	[AsyncStateMachine(typeof(<UpdateCache>d__6))]
	public static Task UpdateCache(IEnumerable<StorageFile> storageFiles, string fileSystemCacheKey, bool throwExceptions = false) { }

}

