namespace Assets.Twitch;

internal class Authenticator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetAuthentication>b__8_0(string x) { }

	}

	[CompilerGenerated]
	private struct <GetAuthentication>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Authentication> <>t__builder; //Field offset: 0x8
		public HttpListenerContext httpContext; //Field offset: 0x20
		public Authenticator <>4__this; //Field offset: 0x28
		private StreamReader <reader>5__2; //Field offset: 0x30
		private string <requestContent>5__3; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private IEnumerator<String> <>7__wrap3; //Field offset: 0x50
		private TaskAwaiter<Authentication> <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadHtml>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string htmlContent; //Field offset: 0x20
		public HttpListenerResponse httpResponse; //Field offset: 0x28
		private Stream <output>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetBroadcasterType>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Authentication authentication; //Field offset: 0x20
		public Authenticator <>4__this; //Field offset: 0x28
		private string <url>5__2; //Field offset: 0x30
		private UnityWebRequest <webRequest>5__3; //Field offset: 0x38
		private TaskAwaiter<List`1<User>> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SignIn>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Authentication> <>t__builder; //Field offset: 0x8
		public Authenticator <>4__this; //Field offset: 0x20
		public Scope[] requiredScopes; //Field offset: 0x28
		private HttpListener <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<HttpListenerContext> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40
		private Authentication <authentication>5__3; //Field offset: 0x48
		private TaskAwaiter<Authentication> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SignOut>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Authenticator <>4__this; //Field offset: 0x20
		private UnityWebRequest <webRequest>5__2; //Field offset: 0x28
		private DateTime <startTime>5__3; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ValidateToken>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Authentication> <>t__builder; //Field offset: 0x8
		public string token; //Field offset: 0x20
		public Authenticator <>4__this; //Field offset: 0x28
		private HttpClient <httpClient>5__2; //Field offset: 0x30
		private HttpResponseMessage <twitchResponse>5__3; //Field offset: 0x38
		private TaskAwaiter<HttpResponseMessage> <>u__1; //Field offset: 0x40
		private TaskAwaiter<String> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Client client; //Field offset: 0x10
	private readonly string redirectUrl; //Field offset: 0x18
	private HttpListener httpListener; //Field offset: 0x20

	internal Authenticator(Client client, string redirectUrl) { }

	[AsyncStateMachine(typeof(<GetAuthentication>d__8))]
	private Task<Authentication> GetAuthentication(HttpListenerContext httpContext) { }

	private string GetAuthUrl(Scope[] scopes) { }

	private BroadcasterType GetBroadcasterType(string broadcasterTypeStr) { }

	[AsyncStateMachine(typeof(<LoadHtml>d__7))]
	private Task LoadHtml(string htmlContent, HttpListenerResponse httpResponse) { }

	[AsyncStateMachine(typeof(<SetBroadcasterType>d__9))]
	private Task SetBroadcasterType(Authentication authentication) { }

	[AsyncStateMachine(typeof(<SignIn>d__5))]
	internal Task<Authentication> SignIn(Scope[] requiredScopes) { }

	[AsyncStateMachine(typeof(<SignOut>d__4))]
	internal Task SignOut() { }

	[AsyncStateMachine(typeof(<ValidateToken>d__11))]
	private Task<Authentication> ValidateToken(string token) { }

}

