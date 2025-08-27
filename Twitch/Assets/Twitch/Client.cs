namespace Assets.Twitch;

public class Client
{
	[CompilerGenerated]
	private struct <SendWebRequest>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<T>> <>t__builder; //Field offset: 0x0
		public UnityWebRequest webRequest; //Field offset: 0x0
		public CancellationTokenSource canceller; //Field offset: 0x0
		public Client <>4__this; //Field offset: 0x0
		private DateTime <startTime>5__2; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SignIn>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		public Scope[] requiredScopes; //Field offset: 0x28
		private TaskAwaiter<Authentication> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SignOut>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Client <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kAuthCacheFile = "auth"; //Field offset: 0x0
	[CompilerGenerated]
	private static Client <Instance>k__BackingField; //Field offset: 0x0
	public Action OnAuthenticationChanged; //Field offset: 0x10
	internal readonly string clientId; //Field offset: 0x18
	internal readonly TimeSpan webRequestTimeout; //Field offset: 0x20
	[CompilerGenerated]
	private readonly StorageManager <Storage>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly Authenticator <Authenticator>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly Polls <Polls>k__BackingField; //Field offset: 0x38
	private Authentication _authentication; //Field offset: 0x40

	public private Authentication Authentication
	{
		 get { } //Length: 190
		private set { } //Length: 158
	}

	private Authenticator Authenticator
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public private static Client Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	public bool IsAuthenticated
	{
		 get { } //Length: 62
	}

	public Polls Polls
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private StorageManager Storage
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public Client(string clientId, string redirectUrl, TimeSpan webRequestTimeout) { }

	private static string Decode(Byte[] data) { }

	private static Byte[] Encode(string data) { }

	public Authentication get_Authentication() { }

	[CompilerGenerated]
	private Authenticator get_Authenticator() { }

	[CompilerGenerated]
	public static Client get_Instance() { }

	public bool get_IsAuthenticated() { }

	[CompilerGenerated]
	public Polls get_Polls() { }

	[CompilerGenerated]
	private StorageManager get_Storage() { }

	private UnityWebRequest GetBaseWebRequest(string url, string authToken = null) { }

	internal UnityWebRequest GetWebRequest(string url, string authToken = null) { }

	public static void Initialize(string clientId, string redirectUrl, TimeSpan webRequestTimeout) { }

	internal UnityWebRequest PatchWebRequest(string url, object payload = null) { }

	internal UnityWebRequest PostWebRequest(string url, object payload = null) { }

	[AsyncStateMachine(typeof(<SendWebRequest>d__29`1))]
	internal Task<List`1<T>> SendWebRequest(UnityWebRequest webRequest, CancellationTokenSource canceller = null) { }

	private void set_Authentication(Authentication value) { }

	[CompilerGenerated]
	private static void set_Instance(Client value) { }

	private void SetPayload(UnityWebRequest uwr, object payload) { }

	[AsyncStateMachine(typeof(<SignIn>d__28))]
	public Task SignIn(Scope[] requiredScopes) { }

	[AsyncStateMachine(typeof(<SignOut>d__27))]
	public Task SignOut() { }

}

