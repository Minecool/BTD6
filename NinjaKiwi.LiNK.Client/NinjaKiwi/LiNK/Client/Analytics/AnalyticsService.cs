namespace NinjaKiwi.LiNK.Client.Analytics;

[Extension]
public static class AnalyticsService
{
	[CompilerGenerated]
	private struct <Send>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string eventName; //Field offset: 0x28
		public WWWForm form; //Field offset: 0x30
		private UnityWebRequest <www>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendAsync>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UnityWebRequest www; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static bool isDisabled; //Field offset: 0x0
	private const string URL = "https://analytics.ninjakiwi.com/link/mobile/"; //Field offset: 0x0
	private const string TIME_FORMAT = "yyyy-MM-dd HH:mm:ss"; //Field offset: 0x0
	public static string salt; //Field offset: 0x8
	public static string noLiNKID; //Field offset: 0x10
	private static Byte[] saltBytes; //Field offset: 0x18
	private static readonly List<String> disabledEventNames; //Field offset: 0x20
	private static int versionInt; //Field offset: 0x28

	private static AnalyticsService() { }

	private static void AddInfo(WWWForm form) { }

	private static void CheckDisabled(UnityWebRequest www, string eventName) { }

	private static int GetVersion() { }

	public static void Send(AnalyticsEvent analyticsEvent) { }

	[AsyncStateMachine(typeof(<Send>d__8))]
	public static void Send(string eventName, WWWForm form) { }

	[AsyncStateMachine(typeof(<SendAsync>d__11))]
	[Extension]
	private static Task SendAsync(UnityWebRequest www) { }

	private static void Sign(UnityWebRequest www) { }

}

