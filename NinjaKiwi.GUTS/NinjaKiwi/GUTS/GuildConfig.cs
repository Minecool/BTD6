namespace NinjaKiwi.GUTS;

public static class GuildConfig
{
	[CompilerGenerated]
	private struct <RefreshGuildToken>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Guild_GetMemberResponse> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Validate>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private string <errorMessage>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static string <GuildId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static GuildToken <GuildToken>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static Func<Task`1<Guild_GetMemberResponse>> <GetGuildInfo>k__BackingField; //Field offset: 0x10

	internal static Func<Task`1<Guild_GetMemberResponse>> GetGuildInfo
	{
		[CompilerGenerated]
		internal get { } //Length: 55
		[CompilerGenerated]
		private set { } //Length: 61
	}

	public private static string GuildId
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	internal static GuildToken GuildToken
	{
		[CompilerGenerated]
		internal get { } //Length: 55
		[CompilerGenerated]
		private set { } //Length: 61
	}

	[CompilerGenerated]
	internal static Func<Task`1<Guild_GetMemberResponse>> get_GetGuildInfo() { }

	[CompilerGenerated]
	public static string get_GuildId() { }

	[CompilerGenerated]
	internal static GuildToken get_GuildToken() { }

	public static void Initialize(Func<Task`1<Guild_GetMemberResponse>> getGuildInfo) { }

	[AsyncStateMachine(typeof(<RefreshGuildToken>d__15))]
	internal static Task RefreshGuildToken() { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_GetGuildInfo(Func<Task`1<Guild_GetMemberResponse>> value) { }

	[CompilerGenerated]
	private static void set_GuildId(string value) { }

	[CompilerGenerated]
	private static void set_GuildToken(GuildToken value) { }

	public static void Update(string guildId, string guildKey) { }

	[AsyncStateMachine(typeof(<Validate>d__16))]
	internal static Task Validate() { }

}

