namespace NinjaKiwi.GUTS;

[Extension]
internal static class WebRequests
{
	[CompilerGenerated]
	private struct <_SendWebRequest>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string endpoint; //Field offset: 0x0
		public string payloadJson; //Field offset: 0x0
		public string playerId; //Field offset: 0x0
		public Action<UnityWebRequest> prepareWebRequest; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		private string <url>5__2; //Field offset: 0x0
		private UnityWebRequest <webRequest>5__3; //Field offset: 0x0
		private TimeSpan <startTime>5__4; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendWebRequest>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public string endpoint; //Field offset: 0x0
		public string payloadJson; //Field offset: 0x0
		public string playerId; //Field offset: 0x0
		public Action<UnityWebRequest> prepareWebRequest; //Field offset: 0x0
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<T> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static TimeSpan holdNextRequestUntil; //Field offset: 0x0
	private static readonly Random random; //Field offset: 0x8

	private static TimeSpan Now
	{
		private get { } //Length: 271
	}

	[AsyncStateMachine(typeof(<_SendWebRequest>d__5`1))]
	private static Task<T> _SendWebRequest(string endpoint, string payloadJson, string playerId, Action<UnityWebRequest> prepareWebRequest, CancellationToken cancellationToken) { }

	private static WebRequests() { }

	internal static void AddSessionHeaders(UnityWebRequest webRequest) { }

	[Extension]
	internal static void EnsureLinkAccount(Player<T> player) { }

	private static TimeSpan get_Now() { }

	private static string GetRandomNonce() { }

	[AsyncStateMachine(typeof(<SendWebRequest>d__3`1))]
	internal static Task<T> SendWebRequest(string endpoint, string payloadJson, string playerId, Action<UnityWebRequest> prepareWebRequest, Nullable<CancellationToken> cancellationToken = null) { }

	private static T ValidateAndParseResponse(string url, string response, Result result, long responseCode, string error) { }

}

