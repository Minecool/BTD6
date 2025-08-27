namespace NinjaKiwi.LiNK.Endpoints;

public abstract class EndpointBase
{
	[CompilerGenerated]
	private struct <SendAndReceive>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public EndpointBase <>4__this; //Field offset: 0x20
		public string endpoint; //Field offset: 0x28
		public Byte[] payloadBytes; //Field offset: 0x30
		private string <url>5__2; //Field offset: 0x38
		private TaskAwaiter<HttpResponse> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendRequestAndParseResponse>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public EndpointBase <>4__this; //Field offset: 0x20
		public object data; //Field offset: 0x28
		public string endpoint; //Field offset: 0x30
		private string <dataJson>5__2; //Field offset: 0x38
		private int <sessionRefreshCount>5__3; //Field offset: 0x40
		private TaskAwaiter<String> <>u__1; //Field offset: 0x48
		private TemporarySessionExpiredException <ex>5__4; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly object emptyObject; //Field offset: 0x0
	private static readonly int sessionRefreshLimit; //Field offset: 0x8
	private readonly HttpRequestFactory requestFactory; //Field offset: 0x10
	private readonly Authority authority; //Field offset: 0x18
	private readonly ApiOptions options; //Field offset: 0x20
	private readonly UriBuilder uriBuilder; //Field offset: 0x28
	protected TimeSpan timeoutOverride; //Field offset: 0x30

	protected bool HasLiNKAccount
	{
		 get { } //Length: 51
	}

	protected string NoLiNKID
	{
		 get { } //Length: 27
	}

	private static EndpointBase() { }

	internal EndpointBase(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	protected U Deserialise(string value) { }

	protected U DeserialiseAnonymousType(string value, U anonymousTypeObject) { }

	protected bool get_HasLiNKAccount() { }

	protected string get_NoLiNKID() { }

	[AsyncStateMachine(typeof(<SendAndReceive>d__9))]
	private Task<String> SendAndReceive(string endpoint, Byte[] payloadBytes) { }

	[AsyncStateMachine(typeof(<SendRequestAndParseResponse>d__8))]
	protected Task<String> SendRequestAndParseResponse(string endpoint, object data = null) { }

	private string Serialise(object value) { }

}

