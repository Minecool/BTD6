namespace Assets.Scripts.Unity.Player;

[Extension]
public static class PlayerSharing
{
	[CompilerGenerated]
	private struct <UploadPublicFile>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string json; //Field offset: 0x28
		public string fileName; //Field offset: 0x30
		private string <hash>5__2; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40
		private TaskAwaiter<StorageModel> <>u__2; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string kPublicStatsFilename = "public-stats"; //Field offset: 0x0
	public const string kPublicProfileFilename = "PublicProfile"; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly StorageManager <HashCache>k__BackingField; //Field offset: 0x0
	public static readonly JsonSerializerSettings SerializerSettings; //Field offset: 0x8

	private static StorageManager HashCache
	{
		[CompilerGenerated]
		private get { } //Length: 78
	}

	private static PlayerSharing() { }

	[CompilerGenerated]
	private static StorageManager get_HashCache() { }

	[AsyncStateMachine(typeof(<UploadPublicFile>d__7))]
	private static Task UploadPublicFile(Btd6Player player, string fileName, string json) { }

	[Extension]
	public static Task UploadPublicProfile(Btd6Player player) { }

	[Extension]
	public static Task UploadStats(Btd6Player player) { }

}

