namespace NinjaKiwi.LiNK.Endpoints;

public abstract class EndpointBase
{
	[CompilerGenerated]
	private struct <SendRequestAndParseResponse>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public EndpointBase <>4__this; //Field offset: 0x20
		public object data; //Field offset: 0x28
		public string endpoint; //Field offset: 0x30
		private Request <request>5__2; //Field offset: 0x38
		private TaskAwaiter<HttpResponse> <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly object emptyObject; //Field offset: 0x0
	private readonly HttpRequestFactory requestFactory; //Field offset: 0x10
	private readonly Authority authority; //Field offset: 0x18
	private readonly ApiOptions options; //Field offset: 0x20

	protected bool HasLiNKAccount
	{
		 get { } //Length: 31
	}

	protected string NoLiNKID
	{
		 get { } //Length: 27
	}

	private static EndpointBase() { }

	internal EndpointBase(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	protected U DeserialiseAnonymousType(string value, U anonymousTypeObject) { }

	protected U DeserialiseObject(string value) { }

	protected bool get_HasLiNKAccount() { }

	protected string get_NoLiNKID() { }

	[AsyncStateMachine(typeof(<SendRequestAndParseResponse>d__5))]
	protected Task<String> SendRequestAndParseResponse(string endpoint, object data = null) { }

	private string Serialise(object value) { }

}

