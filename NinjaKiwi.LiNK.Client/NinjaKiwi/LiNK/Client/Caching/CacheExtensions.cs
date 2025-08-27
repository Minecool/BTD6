namespace NinjaKiwi.LiNK.Client.Caching;

[Extension]
internal static class CacheExtensions
{
	[CompilerGenerated]
	private struct <ToCacheEntry>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CacheEntry> <>t__builder; //Field offset: 0x8
		public Task<DataAndEtag> dataTask; //Field offset: 0x20
		public string key; //Field offset: 0x28
		public float ttlMinutes; //Field offset: 0x30
		private TaskAwaiter<DataAndEtag> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<ToCacheEntry>d__0))]
	[Extension]
	internal static Task<CacheEntry> ToCacheEntry(Task<DataAndEtag> dataTask, string key, float ttlMinutes) { }

}

