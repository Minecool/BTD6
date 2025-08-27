namespace NinjaKiwi.LiNK;

[Extension]
public static class PlayerNameCache
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Api liNK; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal Task <CacheAppropriateDisplayNames>b__0(List<String> l) { }

	}

	[CompilerGenerated]
	private struct <CacheAppropriateDisplayName>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string liNKID; //Field offset: 0x20
		public Api liNK; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CacheAppropriateDisplayNames>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Api liNK; //Field offset: 0x20
		public IEnumerable<String> liNKIDs; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAppropriateDisplayName>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string liNKID; //Field offset: 0x20
		public Api liNK; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAppropriateDisplayNames>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, String>> <>t__builder; //Field offset: 0x8
		public IEnumerable<String> liNKIDs; //Field offset: 0x20
		public Api liNK; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RetrieveAndStoreNames>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Api liNK; //Field offset: 0x20
		public String[] liNKIDs; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, UserModel>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int maxBatchSize = 100; //Field offset: 0x0
	private const string defaultName = "Player"; //Field offset: 0x0
	private static readonly Dictionary<String, String> cache; //Field offset: 0x0

	private static PlayerNameCache() { }

	[AsyncStateMachine(typeof(<CacheAppropriateDisplayName>d__4))]
	public static Task CacheAppropriateDisplayName(string liNKID, Api liNK = null) { }

	[AsyncStateMachine(typeof(<CacheAppropriateDisplayNames>d__3))]
	public static Task CacheAppropriateDisplayNames(IEnumerable<String> liNKIDs, Api liNK = null) { }

	private static string CachedNameOrDefault(string liNKID) { }

	public static string ChooseAppropriateDisplayName(string displayName, string safeName, bool isAppleArcadePlayer, bool isNetflixPlayer) { }

	public static void ClearCache() { }

	[AsyncStateMachine(typeof(<GetAppropriateDisplayName>d__7))]
	public static Task<String> GetAppropriateDisplayName(string liNKID, Api liNK = null) { }

	[AsyncStateMachine(typeof(<GetAppropriateDisplayNames>d__6))]
	public static Task<Dictionary`2<String, String>> GetAppropriateDisplayNames(IEnumerable<String> liNKIDs, Api liNK = null) { }

	[Extension]
	private static bool IsValidLinkID(string liNKID) { }

	private static bool NeedsLookup(string liNKID) { }

	private static string RepeatID(string liNKID) { }

	[AsyncStateMachine(typeof(<RetrieveAndStoreNames>d__8))]
	private static Task RetrieveAndStoreNames(Api liNK, String[] liNKIDs) { }

	public static void UpdateCacheForId(string liNKID, string displayName) { }

}

