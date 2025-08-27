namespace Assets.Scripts.Utils;

public static class GuildCache
{
	[CompilerGenerated]
	private struct <_GetGuildBadges>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, Int32>> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_GetGuildMembers>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildMemberModel[]> <>t__builder; //Field offset: 0x8
		public string guildID; //Field offset: 0x20
		private TaskAwaiter<PagedCollection`1<GuildMemberModel>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <_GetGuilds>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<GuildModel>> <>t__builder; //Field offset: 0x8
		public IEnumerable<String> guildIds; //Field offset: 0x20
		private List<String> <guildsToDownload>5__2; //Field offset: 0x28
		private List<GuildModel> <requestedGuilds>5__3; //Field offset: 0x30
		private TaskAwaiter<List`1<GuildModel>> <>u__1; //Field offset: 0x38
		private IEnumerator<String> <>7__wrap3; //Field offset: 0x40
		private string <guildId>5__5; //Field offset: 0x48
		private TaskAwaiter<CacheObject`1<GuildModel>> <>u__2; //Field offset: 0x50
		private List<GuildModel> <guilds>5__6; //Field offset: 0x58
		private Enumerator<GuildModel> <>7__wrap6; //Field offset: 0x60
		private TaskAwaiter <>u__3; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__24_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Int64>, Boolean> <>9__41_0; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, Int64>, String> <>9__41_1; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, Int64>, Int32> <>9__41_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <_GetGuildBadges>b__41_0(KeyValuePair<String, Int64> x) { }

		internal string <_GetGuildBadges>b__41_1(KeyValuePair<String, Int64> x) { }

		internal int <_GetGuildBadges>b__41_2(KeyValuePair<String, Int64> x) { }

		internal bool <GetGuilds>b__24_0(string x) { }

	}

	[CompilerGenerated]
	private struct <DownloadGuildMetadata>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildMetadata> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetDeserializedObj>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string cacheKey; //Field offset: 0x0
		private TaskAwaiter<CacheObject`1<T>> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFromCacheOrDownload>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string prefix; //Field offset: 0x0
		public string guildId; //Field offset: 0x0
		public Func<String, Task`1<T>> download; //Field offset: 0x0
		public Nullable<TimeSpan> cacheLifeOverride; //Field offset: 0x0
		private string <cacheKey>5__2; //Field offset: 0x0
		private T <obj>5__3; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGuild>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildModel> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<GuildModel> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGuilds>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<GuildModel>> <>t__builder; //Field offset: 0x8
		public IEnumerable<String> guildIds; //Field offset: 0x20
		private IEnumerable<String> <validGuildIds>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<IEnumerable`1<GuildModel>> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForMultiGuildRequest>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<IEnumerable`1<GuildModel>> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class CacheObject
	{
		public string json; //Field offset: 0x0
		public TimeSpan creationTime; //Field offset: 0x0
		private Nullable<TimeSpan> cacheLifeOverride; //Field offset: 0x0

		[JsonIgnore]
		public bool IsValid
		{
			 get { } //Length: 260
		}

		[JsonConstructor]
		public CacheObject`1() { }

		public CacheObject`1(T obj, Nullable<TimeSpan> cacheLifeOverride = null) { }

		public T Deserialize() { }

		public bool get_IsValid() { }

	}

	private const string kGuildModelKeyPrefix = "guildModel"; //Field offset: 0x0
	private const string kGuildModelPlayerKeyPrefix = "guildModelPlayer"; //Field offset: 0x0
	private const string kGuildMembersKeyPrefix = "guildMembers"; //Field offset: 0x0
	private const string kGuildMedalsKeyPrefix = "guildMedals"; //Field offset: 0x0
	private const string kGuildMetadataKeyPrefix = "guildMeta"; //Field offset: 0x0
	private static readonly Dictionary<String, Task> runningDownloadTasks; //Field offset: 0x0
	private static readonly Dictionary<String, Task> runningGetTasks; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly StorageManager <ObjectCacheStorage>k__BackingField; //Field offset: 0x10
	private static Task<IEnumerable`1<GuildModel>> multiGuildTask; //Field offset: 0x18
	[CompilerGenerated]
	private static readonly JsonSerializerSettings <SerializerSettings>k__BackingField; //Field offset: 0x20

	private static TimeSpan CacheLife
	{
		private get { } //Length: 159
	}

	private static TimeSpan MedalsCacheLife
	{
		private get { } //Length: 159
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
		[CompilerGenerated]
		private get { } //Length: 79
	}

	private static bool UseCache
	{
		private get { } //Length: 281
	}

	[AsyncStateMachine(typeof(<_GetGuildBadges>d__41))]
	private static Task<Dictionary`2<String, Int32>> _GetGuildBadges(string guildId) { }

	[AsyncStateMachine(typeof(<_GetGuildMembers>d__28))]
	private static Task<GuildMemberModel[]> _GetGuildMembers(string guildID) { }

	[AsyncStateMachine(typeof(<_GetGuilds>d__25))]
	private static Task<IEnumerable`1<GuildModel>> _GetGuilds(IEnumerable<String> guildIds) { }

	public static Task<Guild_GetMemberResponse> _GetPlayersGuild(string playerId) { }

	private static GuildCache() { }

	private static void ClearCache(string prefix, string id) { }

	public static void ClearCache(string guildId) { }

	[AsyncStateMachine(typeof(<DownloadGuildMetadata>d__21))]
	private static Task<GuildMetadata> DownloadGuildMetadata(string guildId) { }

	private static Task<GuildModel> DownloadGuildModel(string guildId) { }

	private static Task<List`1<GuildModel>> DownloadGuildModels(String[] guildId) { }

	private static TimeSpan get_CacheLife() { }

	private static TimeSpan get_MedalsCacheLife() { }

	private static TimeSpan get_Now() { }

	[CompilerGenerated]
	private static StorageManager get_ObjectCacheStorage() { }

	private static Btd6Player get_Player() { }

	[CompilerGenerated]
	private static JsonSerializerSettings get_SerializerSettings() { }

	private static bool get_UseCache() { }

	private static string GetCacheKey(string prefix, string id) { }

	[AsyncStateMachine(typeof(<GetDeserializedObj>d__34`1))]
	private static Task<T> GetDeserializedObj(string cacheKey) { }

	[AsyncStateMachine(typeof(<GetFromCacheOrDownload>d__35`1))]
	private static Task<T> GetFromCacheOrDownload(string prefix, string guildId, Func<String, Task`1<T>> download, Nullable<TimeSpan> cacheLifeOverride = null) { }

	[AsyncStateMachine(typeof(<GetGuild>d__26))]
	public static Task<GuildModel> GetGuild(string guildId) { }

	public static Task<Dictionary`2<String, Int32>> GetGuildBadges(string guildId) { }

	public static Task<GuildMemberModel[]> GetGuildMembers(string guildId) { }

	public static Task<GuildMetadata> GetGuildMetaData(string guildId) { }

	[AsyncStateMachine(typeof(<GetGuilds>d__24))]
	public static Task<IEnumerable`1<GuildModel>> GetGuilds(IEnumerable<String> guildIds) { }

	public static Task<Guild_GetMemberResponse> GetPlayersGuild(string playerId) { }

	[AsyncStateMachine(typeof(<WaitForMultiGuildRequest>d__23))]
	private static Task WaitForMultiGuildRequest() { }

}

