namespace NinjaKiwi.LiNK.Net;

public class DotNetHttpRequestFactory : HttpRequestFactory
{
	[CompilerGenerated]
	private struct <Send>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<HttpResponse> <>t__builder; //Field offset: 0x8
		public DotNetHttpRequestFactory <>4__this; //Field offset: 0x20
		public HttpRequestMessage request; //Field offset: 0x28
		private HttpResponseMessage <response>5__2; //Field offset: 0x30
		private string <responseEtag>5__3; //Field offset: 0x38
		private TaskAwaiter<HttpResponseMessage> <>u__1; //Field offset: 0x40
		private TaskAwaiter<Byte[]> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendAndMonitor>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<HttpResponse> <>t__builder; //Field offset: 0x8
		public HttpRequestMessage request; //Field offset: 0x20
		public DotNetHttpRequestFactory <>4__this; //Field offset: 0x28
		private HttpRequestMessage <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<HttpResponse> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly HttpClient _httpClient; //Field offset: 0x40

	public DotNetHttpRequestFactory() { }

	public DotNetHttpRequestFactory(HttpClient httpClient) { }

	public virtual Task<HttpResponse> Get(string url, string etag) { }

	public virtual Task<HttpResponse> Head(string url, string etag) { }

	public virtual Task<HttpResponse> Post(string url, Byte[] data) { }

	[AsyncStateMachine(typeof(<Send>d__11))]
	private Task<HttpResponse> Send(HttpRequestMessage request) { }

	[AsyncStateMachine(typeof(<SendAndMonitor>d__10))]
	private Task<HttpResponse> SendAndMonitor(HttpRequestMessage request) { }

	private static void SetRequestEtagHeader(string etag, HttpRequestMessage request) { }

	private void SetRequestInfoHeaders(HttpRequestMessage request) { }

	private void SetResponseInfoHeaders(HttpRequestMessage request) { }

	private static void SetUserAgentHeader(HttpRequestMessage request) { }

}

