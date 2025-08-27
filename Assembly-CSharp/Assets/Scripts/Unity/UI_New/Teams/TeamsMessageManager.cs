namespace Assets.Scripts.Unity.UI_New.Teams;

public static class TeamsMessageManager
{
	[CompilerGenerated]
	private struct <_GetTeamMessages>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<GuildMessage>> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		private LiNKAccount <linkAccount>5__2; //Field offset: 0x28
		private TeamMessageData <storedMessageData>5__3; //Field offset: 0x30
		private List<GuildMessage> <guildMessages>5__4; //Field offset: 0x38
		private TaskAwaiter<TeamMessageData> <>u__1; //Field offset: 0x40
		private TaskAwaiter<PubSubChannelModel> <>u__2; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public PubSubMessageModel pubsubMessage; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <MergePubsubIntoGuildMessagesByCreationTime>b__0(GuildMessage x) { }

	}

	[CompilerGenerated]
	private struct <GetTeamMessages>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<GuildMessage>> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		private TaskAwaiter<IEnumerable`1<GuildMessage>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kLogTag = "TeamMessages"; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly StorageManager <MessageStorage>k__BackingField; //Field offset: 0x0
	private static Task<IEnumerable`1<GuildMessage>> getTeamMessagesTask; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <CanUseCache>k__BackingField; //Field offset: 0x10

	private static bool CanUseCache
	{
		[CompilerGenerated]
		private get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	private static StorageManager MessageStorage
	{
		[CompilerGenerated]
		private get { } //Length: 78
	}

	private static TeamSettings TeamSettings
	{
		private get { } //Length: 150
	}

	[AsyncStateMachine(typeof(<_GetTeamMessages>d__13))]
	private static Task<IEnumerable`1<GuildMessage>> _GetTeamMessages(string guildId) { }

	private static TeamsMessageManager() { }

	public static void ForceNextDownload() { }

	[CompilerGenerated]
	private static bool get_CanUseCache() { }

	[CompilerGenerated]
	private static StorageManager get_MessageStorage() { }

	private static TeamSettings get_TeamSettings() { }

	public static string GetGuildChannel(string guildId) { }

	private static long GetMsTimeStamp(DateTime dateTime) { }

	[AsyncStateMachine(typeof(<GetTeamMessages>d__11))]
	public static Task<IEnumerable`1<GuildMessage>> GetTeamMessages(string guildId) { }

	private static void MergePubsubIntoGuildMessagesByCreationTime(List<GuildMessage> guildMessages, PubSubMessageModel[] pubsubMessages) { }

	[CompilerGenerated]
	private static void set_CanUseCache(bool value) { }

}

