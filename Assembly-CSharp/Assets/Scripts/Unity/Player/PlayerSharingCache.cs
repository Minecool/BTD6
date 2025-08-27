namespace Assets.Scripts.Unity.Player;

[Extension]
public static class PlayerSharingCache
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		public static EventHandler<ErrorEventArgs> <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <get_SerializerSettings>b__17_0(object _, ErrorEventArgs args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <GetStats>b__0(Tuple<String, String, Task> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetPublicProfile>b__0(Tuple<String, String, Task> x) { }

	}

	[CompilerGenerated]
	private struct <Download>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string playerId; //Field offset: 0x0
		public string fileName; //Field offset: 0x0
		private Task<Byte[]> <getTask>5__2; //Field offset: 0x0
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFromCacheOrDownload>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string playerId; //Field offset: 0x0
		public string fileName; //Field offset: 0x0
		private string <cacheKey>5__2; //Field offset: 0x0
		private T <obj>5__3; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0
		private TaskAwaiter<CacheObject`1<T>> <>u__2; //Field offset: 0x0
		private TaskAwaiter <>u__3; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPublicProfile>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PublicProfileModel> <>t__builder; //Field offset: 0x8
		public string playerId; //Field offset: 0x20
		private Tuple<String, String, Task> <getTask>5__2; //Field offset: 0x28
		private TaskAwaiter<PublicProfileModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetStats>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Btd6PlayerStats> <>t__builder; //Field offset: 0x8
		public string playerId; //Field offset: 0x20
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x28
		private Tuple<String, String, Task> <getTask>5__2; //Field offset: 0x30
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class CacheObject
	{
		public string json; //Field offset: 0x0
		public TimeSpan creationTime; //Field offset: 0x0

		[JsonIgnore]
		public bool IsValid
		{
			 get { } //Length: 202
		}

		[JsonConstructor]
		public CacheObject`1() { }

		public CacheObject`1(T obj) { }

		public T Deserialize() { }

		public bool get_IsValid() { }

	}

	private static readonly Dictionary<String, Task> runningDownloads; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly StorageManager <ObjectCacheStorage>k__BackingField; //Field offset: 0x8
	private static readonly List<Tuple`3<String, String, Task>> loadingTasks; //Field offset: 0x10

	private static PlayerCacheSettings CachingSettings
	{
		private get { } //Length: 150
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	private static StorageManager ObjectCacheStorage
	{
		[CompilerGenerated]
		private get { } //Length: 79
	}

	private static Btd6Player Player
	{
		private get { } //Length: 7
	}

	private static JsonSerializerSettings SerializerSettings
	{
		private get { } //Length: 285
	}

	private static PlayerSharingCache() { }

	[AsyncStateMachine(typeof(<Download>d__15`1))]
	private static Task<T> Download(string playerId, string fileName) { }

	private static PlayerCacheSettings get_CachingSettings() { }

	private static TimeSpan get_Now() { }

	[CompilerGenerated]
	private static StorageManager get_ObjectCacheStorage() { }

	private static Btd6Player get_Player() { }

	private static JsonSerializerSettings get_SerializerSettings() { }

	[AsyncStateMachine(typeof(<GetFromCacheOrDownload>d__14`1))]
	private static Task<T> GetFromCacheOrDownload(string playerId, string fileName) { }

	[AsyncStateMachine(typeof(<GetPublicProfile>d__13))]
	public static Task<PublicProfileModel> GetPublicProfile(string playerId) { }

	[AsyncStateMachine(typeof(<GetStats>d__11))]
	public static Task<Btd6PlayerStats> GetStats(string playerId) { }

	[Extension]
	private static Btd6PlayerStats Validate(Btd6PlayerStats playerStats, string playerId) { }

}

