namespace NinjaKiwi.GUTS.CT;

public static class CtConfig
{
	[CompilerGenerated]
	private struct <ValidateBaseIds>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static string <EventId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static UserServerIds <UserServerIds>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly HashSet<String> <CheckedEventIds>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static Func<CtSettings> <GetCtSettings>k__BackingField; //Field offset: 0x18

	internal static HashSet<String> CheckedEventIds
	{
		[CompilerGenerated]
		internal get { } //Length: 79
	}

	internal static string EventId
	{
		[CompilerGenerated]
		internal get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 84
	}

	internal static Func<CtSettings> GetCtSettings
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	internal static UserServerIds UserServerIds
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	private static CtConfig() { }

	[CompilerGenerated]
	internal static HashSet<String> get_CheckedEventIds() { }

	[CompilerGenerated]
	internal static string get_EventId() { }

	[CompilerGenerated]
	internal static Func<CtSettings> get_GetCtSettings() { }

	[CompilerGenerated]
	internal static UserServerIds get_UserServerIds() { }

	public static void Initialize(Func<CtSettings> getCtSettings) { }

	internal static void RefreshEventData(string eventId = null) { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_EventId(string value) { }

	[CompilerGenerated]
	private static void set_GetCtSettings(Func<CtSettings> value) { }

	[CompilerGenerated]
	private static void set_UserServerIds(UserServerIds value) { }

	internal static void SetEventData(string eventId, UserServerIds userServerIds) { }

	[AsyncStateMachine(typeof(<ValidateBaseIds>d__19))]
	internal static Task ValidateBaseIds(string eventId) { }

	internal static void ValidateEventId(string eventId) { }

}

